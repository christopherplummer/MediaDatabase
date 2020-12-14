using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaDatabase.Web.Data;
using MediaDatabase.Web.Data.Manga;
using Microsoft.Extensions.Configuration;
using RestSharp;

namespace MediaDatabase.Web.Services
{
    public class MangaService : EntityService<Manga>
    {
        public MangaService(IRestClient restClient, IConfiguration config) : base(restClient, config)
        {
        }

        public override async Task<List<Manga>> Get()
        {
            var request = new RestRequest("manga");
            request.AddHeader("Accept", "application/vnd.api+json");
            var response = await _restClient.ExecuteAsync<Response<List<Manga>>>(request);
            return response.Data.Data.ToList();
        }

        public override async Task<Manga> Get(int id)
        {
            var request = new RestRequest($"manga/{id}");
            request.AddHeader("Accept", "application/vnd.api+json");
            var response = await _restClient.ExecuteAsync<Response<Manga>>(request);
            return response.Data.Data;
        }
    }
}