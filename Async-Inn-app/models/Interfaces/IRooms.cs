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
        Task<Rooms> GetRoom(int id);
        Task<Rooms> UpdateRoom(int id, Rooms rooms);
        Task Delete(int id);

        public Task AddAmenityToRoom(int hotelIdRoomId, int amenityId);

        public Task RemoveAmentityFromRoom(int hotelIdRoomId, int amenityId);
    }
}
