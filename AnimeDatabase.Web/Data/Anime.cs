using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AnimeDatabase.Web.Data
{
    public class Anime
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("attributes")]
        public Attributes Attributes { get; set; }
    }

    public class Attributes
    {
        [JsonPropertyName("canonicalTitle")]
        public string CanonicalTitle { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("coverImage")]
        public CoverImage CoverImage { get; set; }
    }

    public class CoverImage
    {
        [JsonPropertyName("tiny")]
        public string Tiny { get; set; }
    }
}
