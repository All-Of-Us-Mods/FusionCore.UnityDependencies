using System.Text.Json.Serialization;

namespace Generator.ResponseModels;

public class ChangesetResponse
{
    [JsonPropertyName("version")] public string Version { get; set; } = null!;

    [JsonPropertyName("changeset")] public string Changeset { get; set; } = null!;
}