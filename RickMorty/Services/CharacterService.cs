using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RickMorty.Models;
using RickMorty.Models.Dtos;

namespace RickMorty.Services
{
    public class CharacterService : ICharacterService
    {
        PageDto<CharacterDto> CurrentPageDto = new PageDto<CharacterDto>();

        async Task<IEnumerable<CharacterDto>> GetAll(string uri)
        {
            var client = new HttpClient();

            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    var content = await response.Content.ReadAsStringAsync();

                    var page = JsonConvert.DeserializeObject<PageDto<CharacterDto>>(content);

                    CurrentPageDto = page;

                    return page.Results;

                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.StackTrace);
                }
            }

            return null;
        }

        public async Task<IEnumerable<CharacterDto>> GetCharacters()
        {
            var uri = "https://rickandmortyapi.com/api/character/";
            return await GetAll(uri);
        }

        public async Task<IEnumerable<CharacterDto>> Next(string next)
        {
            var nextUrl = CurrentPageDto.Info.Next;
            return await GetAll(nextUrl);
        }
    }
}
