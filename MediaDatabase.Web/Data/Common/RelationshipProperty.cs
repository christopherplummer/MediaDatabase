using System.Text.Json.Serialization;

namespace MediaDatabase.Web.Data.Common
{
    public class RelationshipProperty
    {
        [JsonPropertyName("links")] public Links Links { get; set; }
    }
}