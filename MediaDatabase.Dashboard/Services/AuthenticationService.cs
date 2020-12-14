using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using MediaDatabase.Dashboard.Data;
using MediaDatabase.Dashboard.Data.Anime;
using MediaDatabase.Dashboard.Data.Authentication;
using Microsoft.Extensions.Configuration;
using RestSharp;

namespace MediaDatabase.Dashboard.Services
{
    public class AuthenticationService : EntityService<Authentication>
    {
        public AuthenticationService(IRestClient restClient, IConfiguration config) : base(restClient, config)
        {
        }

        public override async Task<List<Authentication>> Get()
        {
            throw new NotImplementedException();
        }

        public override async Task<Authentication> Get(int id)
        {
            throw new NotImplementedException();
        }
        
        public override async Task<Authentication> Post(Authentication model)
        {
            var request = new RestRequest("/oauth/anime", Method.POST);
            request.AddJsonBody(model);
            var test = JsonSerializer.Serialize(model);
            var response = await _restClient.ExecuteAsync<Authentication>(request);
            return response.Data;
        }

        public async Task<AccessTokenResponse> CreateAuth()
        {
            return await PostPasswordGrant();
        }

        private async Task<AccessTokenResponse> PostPasswordGrant()
        {
            var password = "|RO%5!iQ<XhN";

            var model = new PasswordGrant()
            {
                GrantType = "password",
                Username = "chrisplummer0194@gmail.com",
                Password = Uri.EscapeDataString(password)
            };
            var request = new RestRequest("/oauth/token", Method.POST);
            request.AddJsonBody(model);
            var test = JsonSerializer.Serialize(model);
            var response = await _restClient.ExecuteAsync<AccessTokenResponse>(request);
            return response.Data;
        }
    }
}