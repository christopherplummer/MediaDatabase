using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using MediaDatabase.Dashboard.Data.Common;

namespace MediaDatabase.Dashboard.Data.Manga
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

        [JsonPropertyName("chapterCount")] public int ChapterCount { get; set; }

        [JsonPropertyName("volumeCount")] public int? VolumeCount { get; set; }

        [JsonPropertyName("serialization")] public string Serialization { get; set; }

        [JsonPropertyName("mangaType")] public string MangaType { get; set; }
    }
}