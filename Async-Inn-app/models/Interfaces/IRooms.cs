using Async_Inn_app.models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models.Interfaces
{
    public interface IRooms
    {

       public Task<RoomsDto> Create(Rooms rooms);
       public Task<List<RoomsDto>> GetRooms();

      public  Task<RoomsDto> GetRoom(int hotelId, int roomId );
       public Task<RoomsDto> UpdateRoom(int hotelId, int roomId, RoomsDto roomsDto);
        public Task Delete(int hotelId, int roomId);

        public Task<RoomsAmenities> AddAmenityToRoom(RoomsAmenities roomsAmenities);
        public Task RemoveAmentityFromRoom(int hotelId, int roomId, int amenityId);
    
    }
}
