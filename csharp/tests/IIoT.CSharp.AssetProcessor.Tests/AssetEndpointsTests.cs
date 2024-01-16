using IIoT.CSharp.AssetProcessor.Endpoints;
using IIoT.CSharp.AssetProcessor.Entities;

namespace IIoT.CSharp.AssetProcessor.Tests;

public class AssetEndpointsTests
{
    [Theory]
    [MemberData(nameof(AssetEndpointsTestsData.Assets), MemberType = typeof(AssetEndpointsTestsData))]
    public async Task PostAsync_Ok(string json)
    {
        // Arrange
        var jsonSerializerOptions = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };
        var asset = JsonSerializer.Deserialize<Asset>(json, jsonSerializerOptions);

        // Act
        var result = await AssetEndpoints.PostAsync(asset).ConfigureAwait(false);

        // Assert
        Assert.IsType<Ok<Asset>>(result);
        asset.Should().BeEquivalentTo(result.Value);
    }
}
