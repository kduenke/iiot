namespace IIoT.CSharp.AssetProcessor.Tests;

public static class AssetEndpointsTestsData
{
    public static IEnumerable<object[]> Assets =>
        [
            // A full set of sample data
            new object[]
            {

                @"{
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
                }"
            }
        ];
}
