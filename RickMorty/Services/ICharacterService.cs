using System.Collections.Generic;
using System.Threading.Tasks;
using RickMorty.Models.Dtos;

namespace RickMorty.Services
{
    public interface ICharacterService
    {
        Task<IEnumerable<CharacterDto>> GetCharacters();

        Task<IEnumerable<CharacterDto>> Next(string next);
    }
}
