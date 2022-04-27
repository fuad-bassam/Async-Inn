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
    public class AmenitiesService : IAmenities
    {
        private readonly AsyncInnDbContext _context;

        public AmenitiesService(AsyncInnDbContext context)
        {
            _context = context;
        }

     

        public async Task<AmenitiesDto> GetAmenitie(int id)
        {
            //Amenities amenities = await _context.Amenities.FindAsync(id);

            //return amenities;
            // return await _context.Amenities.Include(x => x.roomsAmenities).ThenInclude(y => y.Rooms).FirstOrDefaultAsync(z => z.amenitiesId == id);

            return await _context.Amenities.Select(

                amenitie => new AmenitiesDto
                {
                    amenitiesId = amenitie.amenitiesId,
                    name = amenitie.name

                }
                ).FirstOrDefaultAsync(x=>x.amenitiesId == id);
        }

        public async Task<List<AmenitiesDto>> GetAmenities()
        {
            //var amenities = await _context.Amenities.ToListAsync();

            //return amenities;
            //  return await _context.Amenities.Include(x => x.roomsAmenities).ThenInclude(y => y.Rooms).ToListAsync();

            return await _context.Amenities.Select(

                amenitie => new AmenitiesDto
                {
                    amenitiesId = amenitie.amenitiesId,
                    name = amenitie.name

                }
                ).ToListAsync();
        }
        public async Task<AmenitiesDto> Create(Amenities amenities)
        {
            _context.Entry(amenities).State = EntityState.Added;

            await _context.SaveChangesAsync();
            AmenitiesDto amenitiesDto = new AmenitiesDto
            {

                amenitiesId = amenities.amenitiesId,
                name = amenities.name
            };




            return amenitiesDto;
        }

        public async Task Delete(int id)
        {
            Amenities amenities = await _context.Amenities.FindAsync(id);
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
