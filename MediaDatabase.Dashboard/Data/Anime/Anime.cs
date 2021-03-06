using System.Text.Json.Serialization;
using MediaDatabase.Dashboard.Data.Common;

namespace MediaDatabase.Dashboard.Data.Anime
{
    public class Anime
    {
        [JsonPropertyName("id")] public string Id { get; set; }

        [JsonPropertyName("type")] public string Type { get; set; }

        [JsonPropertyName("links")] public Links Links { get; set; }

        [JsonPropertyName("attributes")] public Attributes Attributes { get; set; }

        [JsonPropertyName("relationships")] public Relationships Relationships { get; set; }
    }
}