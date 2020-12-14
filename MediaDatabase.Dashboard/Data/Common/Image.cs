using System.Text.Json.Serialization;

namespace MediaDatabase.Dashboard.Data.Common
{
    public class Image
    {
        [JsonPropertyName("tiny")] public string Tiny { get; set; }

        [JsonPropertyName("small")] public string Small { get; set; }

        [JsonPropertyName("medium")] public string Medium { get; set; }

        [JsonPropertyName("large")] public string Large { get; set; }

        [JsonPropertyName("original")] public string Original { get; set; }
    }
}