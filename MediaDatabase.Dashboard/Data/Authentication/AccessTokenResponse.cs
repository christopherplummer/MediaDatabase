using System.Text.Json.Serialization;

namespace MediaDatabase.Dashboard.Data.Authentication
{
    public class AccessTokenResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }
        
        [JsonPropertyName("created_at")]
        public long? CreatedAt { get; set; }
        
        [JsonPropertyName("expires_in")]
        public long? ExpiresIn { get; set; }
        
        [JsonPropertyName("refresh_Token")]
        public string RefreshToken { get; set; }
        
        [JsonPropertyName("scope")]
        public string Scope { get; set; }
        
        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }
        
        [JsonPropertyName("error")]
        public string Error { get; set; }
        
        [JsonPropertyName("error_description")]
        public string ErrorDescription { get; set; }
    }
}