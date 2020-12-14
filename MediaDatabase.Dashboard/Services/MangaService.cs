using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using MediaDatabase.Dashboard.Data;
using MediaDatabase.Dashboard.Data.Manga;
using Microsoft.Extensions.Configuration;
using RestSharp;

namespace MediaDatabase.Dashboard.Services
{
    public class MangaService : EntityService<Manga>
    {
        public MangaService(IRestClient restClient, IConfiguration config) : base(restClient, config)
        {
        }

        public override async Task<List<Manga>> Get()
        {
            var request = new RestRequest("/edge/manga");
            request.AddHeader("Accept", "application/vnd.api+json");
            var response = await _restClient.ExecuteAsync<Response<List<Manga>>>(request);
            return response.Data.Data.ToList();
        }

        public override async Task<Manga> Get(int id)
        {
            var request = new RestRequest($"/edge/manga/{id}");
            request.AddHeader("Accept", "application/vnd.api+json");
            var response = await _restClient.ExecuteAsync<Response<Manga>>(request);
            return response.Data.Data;
        }
        
        public override async Task<Manga> Post(Manga model)
        {
            var request = new RestRequest("/edge/manga", Method.POST);
            request.AddJsonBody(model);
            var test = JsonSerializer.Serialize(model);
            var response = await _restClient.ExecuteAsync<Manga>(request);
            return response.Data;
        }
    }
}