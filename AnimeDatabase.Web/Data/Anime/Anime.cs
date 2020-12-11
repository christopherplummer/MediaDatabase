using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AnimeDatabase.Web.Data.Anime
{
    public class AnimeContainer
    {
        [JsonPropertyName("data")]
        public IEnumerable<Anime> Data { get; set; }

        [JsonPropertyName("data")]
        public ContainerMeta Meta { get; set; }

        [JsonPropertyName("data")]
        public ContainerLinks Links { get; set; }

        public class ContainerMeta
        {
            [JsonPropertyName("count")]
            public int Count { get; set; }
        }

        public class ContainerLinks
        {
            [JsonPropertyName("first")]
            public string First { get; set; }

            [JsonPropertyName("next")]
            public string Next { get; set; }

            [JsonPropertyName("last")]
            public string Last { get; set; }
        }
    }

    public class Anime
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("links")]
        public Links Links { get; set; }

        [JsonPropertyName("attributes")]
        public Attributes Attributes { get; set; }

        [JsonPropertyName("relationships")]
        public Relationships Relationships { get; set; }
    }

    public class Attributes
    {
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("synopsis")]
        public string Synopsis { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("coverImageTopOffset")]
        public int CoverImageTopOffset { get; set; }

        [JsonPropertyName("titles")]
        public Titles Titles { get; set; }

        [JsonPropertyName("canonicalTitle")]
        public string CanonicalTitle { get; set; }

        [JsonPropertyName("abbreviatedTitles")]
        public IList<string> AbbreviatedTitles { get; set; }

        [JsonPropertyName("averageRating")]
        public string AverageRating { get; set; }

        [JsonPropertyName("userCount")]
        public int UserCount { get; set; }

        [JsonPropertyName("favoritesCount")]
        public int FavoritesCount { get; set; }

        [JsonPropertyName("startDate")]
        public string StartDate { get; set; }

        [JsonPropertyName("endDate")]
        public string EndDate { get; set; }

        [JsonPropertyName("nextRelease")]
        public object NextRelease { get; set; }

        [JsonPropertyName("popularityRank")]
        public int PopularityRank { get; set; }

        [JsonPropertyName("ratingRank")]
        public int RatingRank { get; set; }

        [JsonPropertyName("ageRating")]
        public string AgeRating { get; set; }

        [JsonPropertyName("ageRatingGuide")]
        public string AgeRatingGuide { get; set; }

        [JsonPropertyName("subtype")]
        public string Subtype { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("tba")]
        public string Tba { get; set; }

        [JsonPropertyName("posterImage")]
        public Image PosterImage { get; set; }

        [JsonPropertyName("coverImage")]
        public Image CoverImage { get; set; }

        [JsonPropertyName("episodeCount")]
        public int EpisodeCount { get; set; }

        [JsonPropertyName("episodeLength")]
        public int? EpisodeLength { get; set; }

        [JsonPropertyName("totalLength")]
        public int TotalLength { get; set; }

        [JsonPropertyName("youtubeVideoId")]
        public string YoutubeVideoId { get; set; }

        [JsonPropertyName("showType")]
        public string ShowType { get; set; }

        [JsonPropertyName("nsfw")]
        public bool Nsfw { get; set; }
    }

    public class Image
    {
        [JsonPropertyName("tiny")]
        public string Tiny { get; set; }

        [JsonPropertyName("small")]
        public string Small { get; set; }

        [JsonPropertyName("medium")]
        public string Medium { get; set; }

        [JsonPropertyName("large")]
        public string Large { get; set; }

        [JsonPropertyName("original")]
        public string Original { get; set; }
    }

    public class Links
    {

        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonPropertyName("related")]
        public string Related { get; set; }
    }

    public class Titles
    {

        [JsonPropertyName("en")]
        public string En { get; set; }

        [JsonPropertyName("en_jp")]
        public string EnJp { get; set; }

        [JsonPropertyName("ja_jp")]
        public string JaJp { get; set; }

        [JsonPropertyName("en_us")]
        public string EnUs { get; set; }
    }

    public class RelationshipProperty
    {
        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }

    public class Relationships
    {
        [JsonPropertyName("genres")]
        public RelationshipProperty Genres { get; set; }

        [JsonPropertyName("categories")]
        public RelationshipProperty Categories { get; set; }

        [JsonPropertyName("castings")]
        public RelationshipProperty Castings { get; set; }

        [JsonPropertyName("installments")]
        public RelationshipProperty Installments { get; set; }

        [JsonPropertyName("mappings")]
        public RelationshipProperty Mappings { get; set; }

        [JsonPropertyName("reviews")]
        public RelationshipProperty Reviews { get; set; }

        [JsonPropertyName("mediaRelationships")]
        public RelationshipProperty MediaRelationships { get; set; }

        [JsonPropertyName("characters")]
        public RelationshipProperty Characters { get; set; }

        [JsonPropertyName("staff")]
        public RelationshipProperty Staff { get; set; }

        [JsonPropertyName("productions")]
        public RelationshipProperty Productions { get; set; }

        [JsonPropertyName("quotes")]
        public RelationshipProperty Quotes { get; set; }

        [JsonPropertyName("episodes")]
        public RelationshipProperty Episodes { get; set; }

        [JsonPropertyName("streamingLinks")]
        public RelationshipProperty StreamingLinks { get; set; }

        [JsonPropertyName("animeProductions")]
        public RelationshipProperty AnimeProductions { get; set; }

        [JsonPropertyName("animeCharacters")]
        public RelationshipProperty AnimeCharacters { get; set; }

        [JsonPropertyName("animeStaff")]
        public RelationshipProperty AnimeStaff { get; set; }
    }
}
