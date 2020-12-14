using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using MediaDatabase.Dashboard.Data.Manga;
using MediaDatabase.Dashboard.Services.Interfaces;

namespace MediaDatabase.Dashboard.Cache
{
    public class MangaCache : Cache<List<Manga>>
    {
        private const string _path = "Cache/manga.json";

        private readonly IEntityService<Manga> _mangaService;

        public MangaCache(IEntityService<Manga> mangaService)
        {
            _mangaService = mangaService;
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

            if (cacheModel == null)
            {
                _manga = await _mangaService.Get();
                await WriteToJsonCache();
            }
            else
            {
                _manga = cacheModel.Data;
            }
        }

        public override async Task<bool> WriteToJsonCache()
        {
            var cacheModel = new CacheModel<List<Manga>>
            {
                Data = _manga,
                ExpirationDate = DateTime.Now.AddDays(14)
            };

            var json = JsonSerializer.Serialize(cacheModel);

            await using var sw = new StreamWriter(_path);
            await sw.WriteAsync(json);

            return !string.IsNullOrEmpty(json);
        }

        public override async Task<CacheModel<List<Manga>>> ReadFromJsonCache()
        {
            using var sw = new StreamReader(_path);
            var json = await sw.ReadToEndAsync();
            return JsonSerializer.Deserialize<CacheModel<List<Manga>>>(json);
        }
    }
}