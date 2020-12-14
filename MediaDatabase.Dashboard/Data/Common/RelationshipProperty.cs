using System.Text.Json.Serialization;

namespace MediaDatabase.Dashboard.Data.Common
{
    public class RelationshipProperty
    {
        [JsonPropertyName("links")] public Links Links { get; set; }
    }
}