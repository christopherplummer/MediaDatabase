using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AnimeDatabase.Web.Data.Common;

namespace AnimeDatabase.Web.Data.Anime
{
    public class Attributes
    {
        [JsonPropertyName("createdAt")] public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updatedAt")] public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("slug")] public string Slug { get; set; }

        [JsonPropertyName("synopsis")] public string Synopsis { get; set; }

        [JsonPropertyName("description")] public string Description { get; set; }

        [JsonPropertyName("coverImageTopOffset")]
        public int CoverImageTopOffset { get; set; }

        [JsonPropertyName("titles")] public Titles Titles { get; set; }

        [JsonPropertyName("canonicalTitle")] public string CanonicalTitle { get; set; }

        [JsonPropertyName("abbreviatedTitles")]
        public IList<string> AbbreviatedTitles { get; set; }

        [JsonPropertyName("averageRating")] public string AverageRating { get; set; }

        [JsonPropertyName("userCount")] public int UserCount { get; set; }

        [JsonPropertyName("favoritesCount")] public int FavoritesCount { get; set; }

        [JsonPropertyName("startDate")] public string StartDate { get; set; }

        [JsonPropertyName("endDate")] public string EndDate { get; set; }

        [JsonPropertyName("nextRelease")] public object NextRelease { get; set; }

        [JsonPropertyName("popularityRank")] public int PopularityRank { get; set; }

        [JsonPropertyName("ratingRank")] public int RatingRank { get; set; }

        [JsonPropertyName("ageRating")] public string AgeRating { get; set; }

        [JsonPropertyName("ageRatingGuide")] public string AgeRatingGuide { get; set; }

        [JsonPropertyName("subtype")] public string Subtype { get; set; }

        [JsonPropertyName("status")] public string Status { get; set; }

        [JsonPropertyName("tba")] public string Tba { get; set; }

        [JsonPropertyName("posterImage")] public Image PosterImage { get; set; }

        [JsonPropertyName("coverImage")] public Image CoverImage { get; set; }

        [JsonPropertyName("episodeCount")] public int EpisodeCount { get; set; }

        [JsonPropertyName("episodeLength")] public int? EpisodeLength { get; set; }

        [JsonPropertyName("totalLength")] public int TotalLength { get; set; }

        [JsonPropertyName("youtubeVideoId")] public string YoutubeVideoId { get; set; }

        [JsonPropertyName("showType")] public string ShowType { get; set; }

        [JsonPropertyName("nsfw")] public bool Nsfw { get; set; }
    }
}