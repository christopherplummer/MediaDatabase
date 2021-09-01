using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;
using MediaDatabase.Dashboard.Data;
using MediaDatabase.Dashboard.Data.Anime;
using RestSharp;

namespace CatalogBuilder
{
    public static class KitsuClient
    {
        private static RestClient _client = new RestClient("https://kitsu.io/api");

        public static async Task<List<Anime>> GetAnime()
        {
            var request = new RestRequest($"/edge/anime?page[limit]=20");
            request.AddHeader("Accept", "application/vnd.api+json");
            var response = await _client.ExecuteAsync<Response<List<Anime>>>(request);

            return response.Data.Data;
        }
        
        public static async Task<List<Anime>> GetAnime(int offset)
        {
            var request = new RestRequest($"/edge/anime?page[limit]=20&page[offset]={offset}");
            request.AddHeader("Accept", "application/vnd.api+json");
            var response = await _client.ExecuteAsync<Response<List<Anime>>>(request);

            return response.Data.Data;
        }
    }
}