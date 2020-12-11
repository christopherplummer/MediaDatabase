using AnimeDatabase.Web.Data.Anime;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeDatabase.Web.Services
{
    public class AnimeService : EntityService<Anime>
    {
        public AnimeService(IRestClient restClient, IConfiguration config) : base(restClient, config)
        {
        }

        public override async Task<List<Anime>> Get()
        {
            var request = new RestRequest("anime");
            request.AddHeader("Accept", "application/vnd.api+json");
            var response = await _restClient.ExecuteAsync<AnimeContainer>(request);
            return response.Data.Data.ToList();
        }
    }
}