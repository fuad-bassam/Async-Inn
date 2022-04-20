using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models.Interfaces
{
    public interface IAmenities
    {

        Task<Amenities> Create(Amenities amenities);
        Task<List<Amenities>> GetAmenities();
        Task<Amenities> GetAmenitie(int id);
        Task<Amenities> UpdateAmenities(int id, Amenities amenities);
        Task Delete(int id);
    }
}
