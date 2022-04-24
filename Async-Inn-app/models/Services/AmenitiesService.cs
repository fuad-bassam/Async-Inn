using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Async_Inn_app.data;
using Async_Inn_app.models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Async_Inn_app.models.Services
{
    public class AmenitiesService : IAmenities
    {
        private readonly AsyncInnDbContext _context;

        public AmenitiesService(AsyncInnDbContext context)
        {
            _context = context;
        }

     

        public async Task<Amenities> GetAmenitie(int id)
        {
            //Amenities amenities = await _context.Amenities.FindAsync(id);

            //return amenities;
            return await _context.Amenities.Include(x => x.roomsAmenities).ThenInclude(y => y.Rooms).FirstOrDefaultAsync(z => z.amenitiesId == id);
        }

        public async Task<List<Amenities>> GetAmenities()
        {
            //var amenities = await _context.Amenities.ToListAsync();

            //return amenities;
            return await _context.Amenities.Include(x => x.roomsAmenities).ThenInclude(y => y.Rooms).ToListAsync();
        }
        public async Task<Amenities> Create(Amenities amenities)
        {
            _context.Entry(amenities).State = EntityState.Added;

            await _context.SaveChangesAsync();
            return amenities;
        }

        public async Task Delete(int id)
        {
            Amenities amenities = await GetAmenitie(id);
            if (amenities != null)
            {
                _context.Entry(amenities).State = EntityState.Deleted;

                await _context.SaveChangesAsync();
            }


        }
        public async Task<Amenities> UpdateAmenities(int id, Amenities amenities)
        {
            

            _context.Entry(amenities).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return amenities;
        }

       
    }
}
