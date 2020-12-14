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
            
            var cacheModel = new CacheModel<Anime>
            {
                Data = response.Data.Data.ToList(),
                ExpirationDate = DateTime.Now.AddDays(14)
            };

            var json = JsonSerializer.Serialize(cacheModel);

            await using var sw = new StreamWriter("Cache/anime.json");
            await sw.WriteAsync(json);
            
            return response.Data.Data.ToList();
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