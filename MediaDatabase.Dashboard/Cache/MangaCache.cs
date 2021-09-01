using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using MediaDatabase.Dashboard.Data.Manga;
using MediaDatabase.Dashboard.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;

namespace MediaDatabase.Dashboard.Cache
{
    public class MangaCache : Cache<Manga>
    {
        private string _path;

        public MangaCache()
        {
            _path = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development" ? "wwwroot/anime.json" : "/wwwroot/anime.json";
        }

        private List<Manga> _manga { get; set; }

        public override async Task Init()
        {
            await PopulateData();
        }

        public override List<Manga> Get()
        {
            return _manga;
        }

        public override async Task PopulateData()
        {
            var cacheModel = await ReadFromJsonCache();
            _manga = cacheModel.Data.GroupBy(x => x.Id).Select(x => x.First()).ToList();
        }

        public override async Task<bool> WriteToJsonCache()
        {
            var cacheModel = new CacheModel<Manga>
            {
                Data = _manga,
                ExpirationDate = DateTime.Now.AddDays(14)
            };

            var json = JsonSerializer.Serialize(cacheModel);

            await using var sw = new StreamWriter(_path);
            await sw.WriteAsync(json);

            return !string.IsNullOrEmpty(json);
        }

        public override async Task<CacheModel<Manga>> ReadFromJsonCache()
        {
            using var sw = new StreamReader(_path);
            var json = await sw.ReadToEndAsync();
            return JsonSerializer.Deserialize<CacheModel<Manga>>(json);
        }
    }
}