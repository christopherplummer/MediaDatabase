namespace MediaDatabase.Dashboard.Data.Authentication
{
    public class Authentication
    {
        public AccessTokenResponse AccessTokenResponse { get; set; }
        
        public PasswordGrant PasswordGrant { get; set; }
        
        public RefreshTokenResponse RefreshTokenResponse { get; set; }
    }
}