using System.Collections.Generic;
using System.Threading.Tasks;
using RickMorty.Models.Dtos;

namespace RickMorty.Services
{
    public interface ILocationService
    {
        Task<IEnumerable<LocationDto>> GetLocations();
    }
}
