using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RickMorty.Models.Dtos;

namespace RickMorty.Services
{
    public abstract class BaseService
    {
        private HttpClient httpClient { get; }

        protected BaseService()
        {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://rickandmortyapi.com/")
            };
        }

        protected async Task<PageDto<T>> Get<T>(string path)
        {
            var response = await httpClient.GetAsync(path);
            var content = await response.Content.ReadAsStringAsync();

            var result = response.IsSuccessStatusCode ? JsonConvert.DeserializeObject<PageDto<T>>(content) :
                default;

            return result;
        }
    }
}
