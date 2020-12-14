using System.Text.Json.Serialization;

namespace MediaDatabase.Dashboard.Data.Authentication
{
    public class PasswordGrant
    {
        [JsonPropertyName("grant_type")]
        public string GrantType { get; set; }
        
        [JsonPropertyName("username")]
        public string Username { get; set; }
        
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}