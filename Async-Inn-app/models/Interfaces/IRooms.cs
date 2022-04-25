using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models.Interfaces
{
    public interface IRooms
    {

       public Task<Rooms> Create(Rooms rooms);
       public Task<List<Rooms>> GetRooms();

      public  Task<Rooms> GetRoom(int hotelId, int roomId );
       public Task<Rooms> UpdateRoom(int hotelId, int roomId, Rooms rooms);
        public Task Delete(int hotelId, int roomId);

        public Task<RoomsAmenities> AddAmenityToRoom(RoomsAmenities roomsAmenities);
        public Task RemoveAmentityFromRoom(int hotelId, int roomId, int amenityId);
    
    }
}
