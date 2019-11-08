using System.Collections.Generic;
using System.Threading.Tasks;
using RickMorty.Models;

namespace RickMorty.Services
{
    public interface ICharacterService
    {
        Task<IEnumerable<Character>> GetAll();
    }
}
