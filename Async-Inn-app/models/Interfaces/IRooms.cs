using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models.Interfaces
{
    public interface IRooms
    {

         Task<Rooms> Create(Rooms rooms);
        Task<List<Rooms>> GetRooms();

        Task<Rooms> GetRoom(int hotelId, int roomId);
        Task<Rooms> UpdateRoom(int hotelId, int roomId, Rooms rooms);
        Task Delete(int hotelId, int roomId);

    }
}
