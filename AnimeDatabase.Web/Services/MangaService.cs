using AnimeDatabase.Web.Data.Manga;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeDatabase.Web.Services
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
            var response = await _restClient.ExecuteAsync<MangaContainer>(request);
            return response.Data.Data.ToList();
        }
    }
}
