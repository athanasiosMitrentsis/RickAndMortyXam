using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RickMorty.Models.Dtos;

namespace RickMorty.Services
{
    public class CharacterService : BaseService, ICharacterService
    {
        PageDto<CharacterDto> CurrentPageDto = new PageDto<CharacterDto>();

        public async Task<IEnumerable<CharacterDto>> GetCharacters()
        {
            var dto = await GetPage();
            return dto.Results;
        }

        public async Task<IEnumerable<CharacterDto>> Next(string next)
        {
            throw new NotImplementedException();
        }

        private async Task<PageDto<CharacterDto>> GetPage()
        {
            var pageDto = await Get<CharacterDto>("api/character");
            return CurrentPageDto = pageDto;
        }
    }
}
