using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MediaDatabase.Dashboard.Cache
{
    public class CacheModel<T>
    {
        [JsonPropertyName("data")] public List<T> Data { get; set; }

        [JsonPropertyName("expirationDate")] public DateTime? ExpirationDate { get; set; }

        [JsonPropertyName("count")] public int? Count { get; set; }
    }
}