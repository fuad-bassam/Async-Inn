using Async_Inn_app.data;
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
        public async Task<HotelBranches> Create(HotelBranches hotelBranches)
        {
            _context.Entry(hotelBranches).State = EntityState.Added;

            await _context.SaveChangesAsync();
            return hotelBranches;
        }

        public async Task Delete(int id)
        {
            HotelBranches hotel = await GetHotel(id);
            if (hotel != null)
            {
                _context.Entry(hotel).State = EntityState.Deleted;

                await _context.SaveChangesAsync();
            }


        }

        public async Task<HotelBranches> GetHotel(int id)
        {
            HotelBranches hotel = await _context.HotelBranches.FindAsync(id);

            return hotel;
        }

        public async Task<List<HotelBranches>> GetHotels()
        {
            var hotels = await _context.HotelBranches.ToListAsync();

            return hotels;
        }

        public async Task<HotelBranches> UpdateHotel(int id, HotelBranches hotelBranches)
        {
            //HotelBranches hotel = await GetHotel(id);
            //if (hotel == null)
            //{
            //    return BadRequest();
            //}

            //GetHotel(id). .Update(hotelBranches.phoneNum);
            //await _context.SaveChangesAsync();
            //_context.Entry(student).State = EntityState.Modified;

            _context.Entry(hotelBranches).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return hotelBranches;
        }
      

      
    }
}
