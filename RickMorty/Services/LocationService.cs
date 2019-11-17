using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RickMorty.Models.Dtos;

namespace RickMorty.Services
{
    public class LocationService : BaseService, ILocationService
    {
        public async Task<IEnumerable<LocationDto>> GetLocations()
        {
            var dto = await GetPage();
            return dto.Results;
        }

        private async Task<PageDto<LocationDto>> GetPage()
        {
            var pageDto = await Get<LocationDto>("api/Location");
            return pageDto;
        }
    }
}
