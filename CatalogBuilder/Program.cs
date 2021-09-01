using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using MediaDatabase.Dashboard.Cache;
using MediaDatabase.Dashboard.Data.Anime;

namespace CatalogBuilder
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var anime = new List<Anime>();
            var i = 0;
            while (i < 100)
            {
                anime.AddRange(await KitsuClient.GetAnime(i));

                Console.WriteLine($"Rep {i + 1} complete!\n");
                i++;
            }
            
            await WriteToJson(anime);
        }

        private static async Task WriteToJson(List<Anime> anime)
        {
            var cacheModel = new CacheModel<Anime>
            {
                Data = anime,
                ExpirationDate = DateTime.Now.AddDays(14)
            };

            var json = JsonSerializer.Serialize(cacheModel);

            await using var sw = new StreamWriter("e:/Documents/anime.json");
            await sw.WriteAsync(json);
        }
    }
}