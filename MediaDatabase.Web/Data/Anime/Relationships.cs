using System.Text.Json.Serialization;
using MediaDatabase.Web.Data.Common;

namespace MediaDatabase.Web.Data.Anime
{
    public class Relationships
    {
        [JsonPropertyName("genres")] public RelationshipProperty Genres { get; set; }

        [JsonPropertyName("categories")] public RelationshipProperty Categories { get; set; }

        [JsonPropertyName("castings")] public RelationshipProperty Castings { get; set; }

        [JsonPropertyName("installments")] public RelationshipProperty Installments { get; set; }

        [JsonPropertyName("mappings")] public RelationshipProperty Mappings { get; set; }

        [JsonPropertyName("reviews")] public RelationshipProperty Reviews { get; set; }

        [JsonPropertyName("mediaRelationships")]
        public RelationshipProperty MediaRelationships { get; set; }

        [JsonPropertyName("characters")] public RelationshipProperty Characters { get; set; }

        [JsonPropertyName("staff")] public RelationshipProperty Staff { get; set; }

        [JsonPropertyName("productions")] public RelationshipProperty Productions { get; set; }

        [JsonPropertyName("quotes")] public RelationshipProperty Quotes { get; set; }

        [JsonPropertyName("episodes")] public RelationshipProperty Episodes { get; set; }

        [JsonPropertyName("streamingLinks")] public RelationshipProperty StreamingLinks { get; set; }

        [JsonPropertyName("animeProductions")] public RelationshipProperty AnimeProductions { get; set; }

        [JsonPropertyName("animeCharacters")] public RelationshipProperty AnimeCharacters { get; set; }

        [JsonPropertyName("animeStaff")] public RelationshipProperty AnimeStaff { get; set; }
    }
}