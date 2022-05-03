using Async_Inn_app.data;
using Async_Inn_app.models.DTO;
using Async_Inn_app.models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models.Services
{
    public class HotelBranchesService : IHotelBranches
    {

        private readonly AsyncInnDbContext _context;

        public HotelBranchesService(AsyncInnDbContext context)
        {
            _context = context;
        }
        public async Task<HotelBranchesDTO> Create(HotelBranchesDTO hotelBranchesDTO)
        {

            HotelBranches hotelBranches = new HotelBranches
            {

                hotelId = hotelBranchesDTO.hotelId,
                name = hotelBranchesDTO.name,
                city = hotelBranchesDTO.city,
                state = hotelBranchesDTO.state,
                address = hotelBranchesDTO.address,
                phoneNum = hotelBranchesDTO.phoneNum
            };


            _context.Entry(hotelBranches).State = EntityState.Added;

            await _context.SaveChangesAsync();
            return hotelBranchesDTO;
        }

        public async Task Delete(int id)
        {
            HotelBranches hotel = await  _context.HotelBranches.FindAsync(id);
            if (hotel != null)
            {
                _context.Entry(hotel).State = EntityState.Deleted;

                await _context.SaveChangesAsync();
            }


        }

        public async Task<HotelBranchesDTO> GetHotel(int id)
        {
            //HotelBranches hotel = await _context.HotelBranches.FindAsync(id);

            //return hotel;
            //return await _context.HotelBranches.Include(x => x.rooms).FirstOrDefaultAsync(z => z.hotelId == id);

            return await _context.HotelBranches.Select(
                hotel => new HotelBranchesDTO
                {

                    hotelId = hotel.hotelId,
                    name = hotel.name,
                    city = hotel.city,
                    state = hotel.state,
                    address = hotel.address,
                    phoneNum = hotel.phoneNum,

                    Rooms = hotel.rooms.Select(

                          Rooms => new RoomsDto
                          {

                              hotelId = Rooms.hotelId,
                              roomId = Rooms.roomId,
                              nickName = Rooms.nickName,
                              space = Rooms.space,

                              Amenities = Rooms.roomsAmenities
                             .Select(x => new AmenitiesDto
                             {
                                 amenitiesId = x.Amenities.amenitiesId,
                                 name = x.Amenities.name



                             }).ToList()

                          }
                        ).ToList()



                }


                ).FirstOrDefaultAsync(z => z.hotelId == id);
        }

        public async Task<List<HotelBranchesDTO>> GetHotels()
        {
            //var hotels = await _context.HotelBranches.ToListAsync();

            //return hotels;
            //return await _context.HotelBranches.Include(x => x.rooms).ToListAsync();
            return await _context.HotelBranches.Select(
               hotel => new HotelBranchesDTO
               {

                   hotelId = hotel.hotelId,
                   name = hotel.name,
                   city = hotel.city,
                   state = hotel.state,
                   address = hotel.address,
                   phoneNum = hotel.phoneNum,

                   Rooms = hotel.rooms.Select(

                         Rooms => new RoomsDto
                         {

                             hotelId = Rooms.hotelId,
                             roomId = Rooms.roomId,
                             nickName = Rooms.nickName,
                             space = Rooms.space,

                             Amenities = Rooms.roomsAmenities
                            .Select(x => new AmenitiesDto
                            {
                                amenitiesId = x.Amenities.amenitiesId,
                                name = x.Amenities.name



                            }).ToList()

                         }
                       ).ToList()



               }


               ).ToListAsync();
        }

        public async Task<HotelBranchesDTO> UpdateHotel(int id, HotelBranchesDTO hotelBranchesDTO)
        {
            //HotelBranches hotel = await GetHotel(id);
            //if (hotel == null)
            //{
            //    return BadRequest();
            //}

            //GetHotel(id). .Update(hotelBranches.phoneNum);
            //await _context.SaveChangesAsync();
            //_context.Entry(student).State = EntityState.Modified;



            HotelBranches hotelBranches = new HotelBranches {


                hotelId = hotelBranchesDTO.hotelId,
                name = hotelBranchesDTO.name,
                city = hotelBranchesDTO.city,
                state = hotelBranchesDTO.state,
                address = hotelBranchesDTO.address,
                phoneNum = hotelBranchesDTO.phoneNum
                        };



            _context.Entry(hotelBranches).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return hotelBranchesDTO;
        }
      

      
    }
}
