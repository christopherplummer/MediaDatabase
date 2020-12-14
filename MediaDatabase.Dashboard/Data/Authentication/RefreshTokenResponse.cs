using System.Text.Json.Serialization;

namespace MediaDatabase.Dashboard.Data.Authentication
{
    public class RefreshTokenResponse
    {
        [JsonPropertyName("grant_Type")]
        public string GrantType { get; set; }
        
        [JsonPropertyName("refresh_Token")]
        public string RefreshToken { get; set; }
    }
}