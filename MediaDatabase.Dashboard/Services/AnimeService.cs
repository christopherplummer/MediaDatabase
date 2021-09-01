using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using MediaDatabase.Dashboard.Cache;
using MediaDatabase.Dashboard.Data;
using MediaDatabase.Dashboard.Data.Anime;
using Microsoft.Extensions.Configuration;
using RestSharp;

namespace MediaDatabase.Dashboard.Services
{
    public class AnimeService : EntityService<Anime>
    {
        public AnimeService(IRestClient restClient, IConfiguration config) : base(restClient, config)
        {
        }

        public override async Task<List<Anime>> Get()
        {
            var request = new RestRequest("/edge/anime?page[limit]=20&page[offset]=50");
            request.AddHeader("Accept", "application/vnd.api+json");
            var response = await _restClient.ExecuteAsync<Response<List<Anime>>>(request);

            return response.Data.Data;
        }

        public override async Task<Anime> Get(int id)
        {
            var request = new RestRequest($"/edge/anime/{id}");
            request.AddHeader("Accept", "application/vnd.api+json");
            var response = await _restClient.ExecuteAsync<Response<Anime>>(request);
            return response.Data.Data;
        }
        
        public override async Task<Anime> Post(Anime model)
        {
            var request = new RestRequest("/edge/anime", Method.POST);
            request.AddJsonBody(model);
            var test = JsonSerializer.Serialize(model);
            var response = await _restClient.ExecuteAsync<Anime>(request);
            return response.Data;
        }
    }
}