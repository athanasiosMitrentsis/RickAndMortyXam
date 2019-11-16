using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RickMorty.Models;

namespace RickMorty.Services
{
    public class CharacterService : ICharacterService
    {
        public async Task<IEnumerable<Character>> GetAll()
        {
            var client = new HttpClient();

            var uri = "https://rickandmortyapi.com/api/character/";

            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    var content = await response.Content.ReadAsStringAsync();
                    
                    var characters = JsonConvert.DeserializeObject<Response>(content);

                    return characters.Characters;

                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.StackTrace);
                }
            }

            return null;
        }


    }
}
