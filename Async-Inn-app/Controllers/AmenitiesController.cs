using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Async_Inn_app.data;
using Async_Inn_app.models;
using Async_Inn_app.models.Interfaces;
using Async_Inn_app.models.DTO;

namespace Async_Inn_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmenitiesController : ControllerBase
    {


        private readonly IAmenities _amenities;


        public AmenitiesController(IAmenities amenities)
        {
            _amenities = amenities;
        }



        // POST: api/Amenities
        [HttpPost]
        public async Task<ActionResult<AmenitiesDto>> PostAmenities(AmenitiesDto amenities)
        {
            AmenitiesDto amenitiesDto = await _amenities.Create(amenities);
            return Ok(amenitiesDto);
        }
        // GET: api/Amenities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AmenitiesDto>>> GetAmenities()
        {
            var amenities = await _amenities.GetAmenities();
            return Ok(amenities);
        }

        // GET: api/Amenities/21
        [HttpGet("{id}")]
        public async Task<ActionResult<AmenitiesDto>> GetAmenities(int id)
        {
            AmenitiesDto amenitiesDto = await _amenities.GetAmenitie(id);
            return Ok(amenitiesDto);
        }

        // PUT: api/Amenities/21
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAmenities(int id, Amenities amenities)
        {
            if (id != amenities.amenitiesId)
            {
                return BadRequest();
            }

            Amenities amenitie = await _amenities.UpdateAmenities(id, amenities);
            return Ok(amenitie);
        }


        // DELETE: api/Amenities/21
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAmenities(int id)
        {


            var amenities = await _amenities.GetAmenitie(id);
            if (amenities == null)
            {
                return NotFound();
            }


            await _amenities.Delete(id);
            return NoContent();
        }

    }
}
