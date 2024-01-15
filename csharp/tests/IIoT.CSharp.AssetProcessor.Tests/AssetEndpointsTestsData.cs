using IIoT.CSharp.AssetProcessor.Entities;

namespace IIoT.CSharp.AssetProcessor.Tests;

public static class AssetEndpointsTestsData
{
    public static IEnumerable<object[]> Assets =>
        [
            new object[]
            {
                // An asset with a full set of sample data
                new Asset
                {
                    Timestamp = new DateTimeOffset(2024, 1, 12, 20, 30, 45, 448, TimeSpan.Zero),
                    MessageType = "ua-deltaframe",
                    Payload = new Dictionary<string, Tag>
                    {
                        {
                            "temperature",
                            new Tag
                            {
                                SourceTimestamp = new DateTimeOffset(2024, 1, 12, 20, 30, 45, 069, TimeSpan.Zero),
                                Value = 14914
                            }
                        },
                        {
                            "Tag 10",
                            new Tag
                            {
                                SourceTimestamp = new DateTimeOffset(2024, 1, 12, 20, 30, 45, 069, TimeSpan.Zero),
                                Value = 14914
                            }
                        }
                    },
                    DataSetWriterName = "thermostat",
                    SequenceNumber = 14834
                }
            }
        ];
}
