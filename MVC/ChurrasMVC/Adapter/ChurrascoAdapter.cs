using ChurrasMVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ChurrasMVC.Adapter
{
    public class ChurrascoAdapter : IChurrascoAdapter
    {
        private string ChurrasMvcUrl = @"http://localhost:51928/";
        private HttpClient GetHttpClient()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(ChurrasMvcUrl)
            };

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
        /// <summary>
        /// Obtém todos os churrascos
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Churrasco>> GetAllChurrascos()
        {
            using(var client = GetHttpClient())
            {
                var response = await client.GetAsync("getall");

                response.EnsureSuccessStatusCode();
                var responseContent = await response.Content.ReadAsStringAsync();
                var obterChurrascos = JsonConvert.DeserializeObject<IEnumerable<Churrasco>>(responseContent);
                return obterChurrascos;
            }
        }


        public async Task<Churrasco> GetChurrascoById(int id)
        {
            using (var client = GetHttpClient())
            {
                var response = await client.GetAsync($"details/{id}");

                response.EnsureSuccessStatusCode();
                var responseContent = await response.Content.ReadAsStringAsync();
                var obterChurrasco = JsonConvert.DeserializeObject<Churrasco>(responseContent);
                return obterChurrasco;
            }
        }
    }
}
