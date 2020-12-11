using System.Text.Json.Serialization;

namespace AnimeDatabase.Web.Data
{
    public class Response<T>
    {
        [JsonPropertyName("data")] public T Data { get; set; }

        [JsonPropertyName("meta")] public ContainerMeta Meta { get; set; }

        [JsonPropertyName("links")] public ContainerLinks Links { get; set; }

        public class ContainerMeta
        {
            [JsonPropertyName("count")] public int Count { get; set; }
        }

        public class ContainerLinks
        {
            [JsonPropertyName("first")] public string First { get; set; }

            [JsonPropertyName("next")] public string Next { get; set; }

            [JsonPropertyName("last")] public string Last { get; set; }
        }
    }
}