using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Async_Inn_app.data;
using Async_Inn_app.models.DTO;
using Async_Inn_app.models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Async_Inn_app.models.Services
{
    public class RoomsServices : IRooms
    {
        private readonly AsyncInnDbContext _context;

        public RoomsServices(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task<RoomsDto> Create(Rooms rooms)
        {
            _context.Entry(rooms).State = EntityState.Added;

            await _context.SaveChangesAsync();
            RoomsDto roomsDto = await GetRoom(rooms.hotelId,rooms.roomId);
            return roomsDto;
        }


        public async Task<RoomsDto> GetRoom(int hotelId, int roomId )
        {

            // Rooms rooms = await _context.Rooms.FindAsync(hotelId,roomId);


            //return rooms;

          //  return await _context.Rooms.Include(a => a.roomsAmenities).ThenInclude(b => b.Amenities).FirstOrDefaultAsync(c => c.hotelId == hotelId && c.roomId == roomId);
            
            return await _context.Rooms.Select(
                Rooms => new RoomsDto {
                
                        hotelId = Rooms.hotelId,
                        roomId = Rooms.roomId,
                       nickName = Rooms.nickName,
                        space = Rooms.space,
                    PetFriendly = Rooms.PetFriendly,

                    Amenities = Rooms.roomsAmenities
                      .Select(x => new AmenitiesDto
                      {
                          amenitiesId = x.Amenities.amenitiesId,
                          name = x.Amenities.name
                        


                      }).ToList()


                }).FirstOrDefaultAsync(c => c.hotelId == hotelId && c.roomId == roomId);


        }

        public async Task<List<RoomsDto>> GetRooms()
        {
            //var rooms = await _context.Rooms.ToListAsync();

            //return rooms;
            //   return await _context.Rooms.Include(a => a.roomsAmenities).ThenInclude(b => b.Amenities).ToListAsync();
            return await _context.Rooms.Select(
                  Rooms => new RoomsDto
                  {

                      hotelId = Rooms.hotelId,
                      roomId = Rooms.roomId,
                      nickName = Rooms.nickName,
                      space = Rooms.space,
                      PetFriendly = Rooms.PetFriendly,
                     
                      Amenities = Rooms.roomsAmenities
                      .Select(x=> new AmenitiesDto {

                      amenitiesId  = x.Amenities.amenitiesId,
                          name = x.Amenities.name,
                        

                         }).ToList()


                  }).ToListAsync();

        }


        public async Task<RoomsDto> UpdateRoom(int hotelId, int roomId, RoomsDto roomsDto)

        {
            Rooms rooms = await _context.Rooms.FindAsync(hotelId, roomId);

            _context.Entry(rooms).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            RoomsDto roomsDto2 = await GetRoom(rooms.hotelId, rooms.roomId);

            return roomsDto2;
        }

        public async Task Delete(int hotelId, int roomId)
        {
            // Rooms rooms = await GetRoom(hotelId, roomId);
            Rooms rooms = await _context.Rooms.FindAsync(hotelId,roomId);
            if (rooms != null)
            {
                _context.Entry(rooms).State = EntityState.Deleted;

                await _context.SaveChangesAsync();
            }


        }



        public async Task<RoomsAmenities> AddAmenityToRoom(RoomsAmenities roomsAmenities)
        {
            _context.Entry(roomsAmenities).State = EntityState.Added;

            await _context.SaveChangesAsync();
            return roomsAmenities;
        }

        public async Task RemoveAmentityFromRoom(int hotelId, int roomId, int amenityId)
        {
            RoomsAmenities roomsAmenities = await _context.RoomsAmenities.FirstOrDefaultAsync(c => c.hotelId == hotelId && c.roomId == roomId && c.amenitiesId ==amenityId);
            if (roomsAmenities != null)
            {
                _context.Entry(roomsAmenities).State = EntityState.Deleted;

                await _context.SaveChangesAsync();
            }
        }


    }
}
