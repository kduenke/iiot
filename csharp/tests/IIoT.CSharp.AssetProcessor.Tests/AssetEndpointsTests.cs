using IIoT.CSharp.AssetProcessor.Endpoints;
using IIoT.CSharp.AssetProcessor.Entities;

namespace IIoT.CSharp.AssetProcessor.Tests;

public class AssetEndpointsTests
{
    [Fact]
    public async Task PostAsync_FullJsonAsync()
    {
        // Arrange
        var json = @"{
            ""timestamp"": ""2024-01-12T20:30:45.4483418Z"",
            ""messageType"": ""ua-deltaframe"",
            ""payload"": {
                ""temperature"": {
                    ""SourceTimestamp"": ""2024-01-12T20:30:45.069698Z"",
                    ""Value"": 14914
                },
                ""Tag 10"": {
                    ""SourceTimestamp"": ""2024-01-12T20:30:45.0697192Z"",
                    ""Value"": 14914
                }
            },
            ""dataSetWriterName"": ""thermostat"",
            ""sequenceNumber"": 14834
        }";
        var asset = JsonSerializer.Deserialize<Asset>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        // Act
        var result = await AssetEndpoints.PostAsync(asset).ConfigureAwait(false);

        // Assert
        Assert.IsType<Ok<Asset>>(result);
        asset.Should().BeEquivalentTo(result.Value);
    }
}
