using System.Text.Json.Serialization;

namespace MediaDatabase.Web.Data.Common
{
    public class Links
    {
        [JsonPropertyName("self")] public string Self { get; set; }

        [JsonPropertyName("related")] public string Related { get; set; }
    }
}