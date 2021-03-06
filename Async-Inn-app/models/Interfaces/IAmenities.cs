using Async_Inn_app.models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models.Interfaces
{
    public interface IAmenities
    {

        Task<AmenitiesDto> Create(AmenitiesDto amenities);
        Task<List<AmenitiesDto>> GetAmenities();
        Task<AmenitiesDto> GetAmenitie(int id);
        Task<Amenities> UpdateAmenities(int id, Amenities amenities);
        Task Delete(int id);
    }
}
