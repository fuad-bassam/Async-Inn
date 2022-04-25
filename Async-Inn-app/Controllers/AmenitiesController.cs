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
        public async Task<ActionResult<Amenities>> PostAmenities(Amenities amenities)
        {
            Amenities amenitie = await _amenities.Create(amenities);
            return Ok(amenitie);
        }
        // GET: api/Amenities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Amenities>>> GetAmenities()
        {
            var amenities = await _amenities.GetAmenities();
            return Ok(amenities);
        }

        // GET: api/Amenities/21
        [HttpGet("{id}")]
        public async Task<ActionResult<Amenities>> GetAmenities(int id)
        {
            Amenities amenities = await _amenities.GetAmenitie(id);
            return Ok(amenities);
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
