using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace AnimeDatabase.Web.Clients
{
    public static class KitsuClient
    {
        private static Uri baseAddress = new("https://kitsu.io/api/edge/");

        public static async Task<string> Get()
        {
            string responseData;
            using (var httpClient = new HttpClient {BaseAddress = baseAddress})
            {
                using (var response = await httpClient.GetAsync("anime"))
                {
                    responseData = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine(responseData);
                }
            }

            return responseData ?? "";
        }
    }
}