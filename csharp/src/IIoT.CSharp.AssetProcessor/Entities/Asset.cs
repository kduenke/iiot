namespace IIoT.CSharp.AssetProcessor.Entities;

public class Asset
{
    public DateTimeOffset? Timestamp { get; set; }
    public string? MessageType { get; set; }
    public Dictionary<string, Tag>? Payload { get; set; }
    public string? DataSetWriterName { get; set; }
    public int? SequenceNumber { get; set; }
}
