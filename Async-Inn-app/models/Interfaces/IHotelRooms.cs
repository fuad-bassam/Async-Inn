using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models.Interfaces
{
    interface IHotelRooms
    {
        Task<HotelBranches> CreateRoomInHotel(HotelBranches hotelBranches);
        Task<List<HotelBranches>> GetHotelRooms();
        Task<HotelBranches> GetHotelRoom(int id);
        Task<HotelBranches> UpdateHotelRoom(int id, HotelBranches hotelBranches);
        Task DeleteHotelRoom(int id);
    }
}
