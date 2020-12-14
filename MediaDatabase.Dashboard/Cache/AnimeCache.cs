using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using MediaDatabase.Dashboard.Data.Anime;
using MediaDatabase.Dashboard.Services.Interfaces;

namespace MediaDatabase.Dashboard.Cache
{
    public class AnimeCache : Cache<Anime>
    {
        private const string _path = "Cache/anime.json";

        private readonly IEntityService<Anime> _animeService;

        public AnimeCache(IEntityService<Anime> service)
        {
            _animeService = service;
        }

        private List<Anime> _anime { get; set; }

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