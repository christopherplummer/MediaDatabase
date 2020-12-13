using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using AnimeDatabase.Web.Data.Anime;
using AnimeDatabase.Web.Services.Interfaces;

namespace AnimeDatabase.Web.Cache
{
    public class AnimeCache : Cache<List<Anime>>
    {
        private const string _path = "Cache/anime.json";
        private List<Anime> _anime { get; set; }

        private readonly IEntityService<Anime> _animeService;

        public AnimeCache(IEntityService<Anime> service)
        {
            _animeService = service;
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

            if (cacheModel == null)
            {
                _anime = await _animeService.Get();
                await WriteToJsonCache();
            }
            else
            {
                _anime = cacheModel.Data;
            }
        }

        public override async Task<bool> WriteToJsonCache()
        {
            var cacheModel = new CacheModel<List<Anime>>()
            {
                Data = _anime,
                ExpirationDate = DateTime.Now.AddDays(14)
            };

            var json = JsonSerializer.Serialize(cacheModel);

            await using var sw = new StreamWriter(_path);
            await sw.WriteAsync(json);

            return !string.IsNullOrEmpty(json);
        }
        
        public override async Task<CacheModel<List<Anime>>> ReadFromJsonCache()
        {
            using StreamReader sw = new StreamReader(_path);
            var json = await sw.ReadToEndAsync();
            return JsonSerializer.Deserialize<CacheModel<List<Anime>>>(json);
        }
    }
}