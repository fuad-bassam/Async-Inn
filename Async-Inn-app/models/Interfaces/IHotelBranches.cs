using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models.Interfaces
{
   public interface IHotelBranches
    {


        Task<HotelBranches> Create(HotelBranches hotelBranches);
        Task<List<HotelBranches>> GetHotels();
        Task<HotelBranches> GetHotel(int id);
        Task<HotelBranches> UpdateHotel(int id, HotelBranches hotelBranches);
        Task Delete(int id);



    }
}
