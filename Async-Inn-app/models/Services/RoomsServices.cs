using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Async_Inn_app.data;
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

        public async Task<Rooms> Create(Rooms rooms)
        {
            _context.Entry(rooms).State = EntityState.Added;

            await _context.SaveChangesAsync();
            return rooms;
        }

        public async Task Delete(int hotelId, int roomId)
        {
            Rooms rooms = await GetRoom(hotelId,roomId);
            if (rooms != null)
            {
                _context.Entry(rooms).State = EntityState.Deleted;

                await _context.SaveChangesAsync();
            }


        }

        public async Task<Rooms> GetRoom(int hotelId, int roomId)
        {
            Rooms rooms = await _context.Rooms.FindAsync(hotelId,roomId);

            return rooms;
        }

        public async Task<List<Rooms>> GetRooms()
        {
            var rooms = await _context.Rooms.ToListAsync();

            return rooms;
        }

        public async Task<Rooms> UpdateRoom(int hotelId, int roomId, Rooms rooms)
        {


            _context.Entry(rooms).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return rooms;
        }

    }
}
