using System.Text.Json.Serialization;

namespace MediaDatabase.Web.Data.Common
{
    public class Titles
    {
        [JsonPropertyName("en")] public string En { get; set; }

        [JsonPropertyName("en_jp")] public string EnJp { get; set; }

        [JsonPropertyName("ja_jp")] public string JaJp { get; set; }

        [JsonPropertyName("en_us")] public string EnUs { get; set; }
    }
}