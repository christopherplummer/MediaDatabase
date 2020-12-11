using System.Text.Json.Serialization;

namespace AnimeDatabase.Web.Data.Common
{
    public class RelationshipProperty
    {
        [JsonPropertyName("links")] public Links Links { get; set; }
    }
}