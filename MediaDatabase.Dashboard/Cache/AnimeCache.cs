using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using MediaDatabase.Dashboard.Data.Anime;
using MediaDatabase.Dashboard.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace MediaDatabase.Dashboard.Cache
{
    public class AnimeCache : Cache<Anime>
    {
        private string _path;

        private List<Anime> _anime { get; set; }

        public AnimeCache()
        {
            _path = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development" ? "wwwroot/anime.json" : "/anime.json";
        }

        public override async Task Init()
        {
            await PopulateData();
        }

        public override List<Anime> Get()
        {
            return _anime;
        }

        public override async Task PopulateData()
        {
            var cacheModel = await ReadFromJsonCache();
            _anime = cacheModel.Data.GroupBy(x => x.Id).Select(x => x.First()).ToList();
        }

        public override async Task<bool> WriteToJsonCache()
        {
            var cacheModel = new CacheModel<Anime>
            {
                Data = _anime,
                ExpirationDate = DateTime.Now.AddDays(14)
            };

            var json = JsonSerializer.Serialize(cacheModel);

            await using var sw = new StreamWriter(_path);
            await sw.WriteAsync(json);

            return !string.IsNullOrEmpty(json);
        }

        public override async Task<CacheModel<Anime>> ReadFromJsonCache()
        {
            using var sw = new StreamReader(_path);
            var json = await sw.ReadToEndAsync();
            return JsonSerializer.Deserialize<CacheModel<Anime>>(json);
        }
    }
}