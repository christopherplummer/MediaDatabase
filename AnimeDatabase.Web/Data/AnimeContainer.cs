using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AnimeDatabase.Web.Data
{
    public class AnimeContainer
    {
        [JsonPropertyName("data")]
        public IEnumerable<Anime> Data { get; set; }
    }
}
