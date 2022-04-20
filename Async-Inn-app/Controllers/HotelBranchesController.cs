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
    public class HotelBranchesController : ControllerBase
    {
        private readonly IHotelBranches _hotel;

        public HotelBranchesController(IHotelBranches hotel)
        {
            _hotel = hotel;
        }

        // GET: api/HotelBranches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelBranches>>> GetHotelBranches()
        {
            var hotels = await _hotel.GetHotels();
            return Ok(hotels);
        }

        // GET: api/HotelBranches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HotelBranches>> GetHotelBranches(int id)
        {
            HotelBranches hotel = await _hotel.GetHotel(id);
            return Ok(hotel);
        }

        // PUT: api/HotelBranches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotelBranches(int id, HotelBranches hotelBranches)
        {
            if (id != hotelBranches.hotelId)
            {
                return BadRequest();
            }

            HotelBranches hotel = await _hotel.UpdateHotel(id,hotelBranches);
            return Ok(hotel);
        }

        // POST: api/HotelBranches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HotelBranches>> PostHotelBranches(HotelBranches hotelBranches)
        {
            HotelBranches hotel = await _hotel.Create(hotelBranches);
            return Ok(hotel);
        }

        // DELETE: api/HotelBranches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotelBranches(int id)
        {
            var hotelBranches = await _hotel.GetHotel(id);
            if (hotelBranches == null)
            {
                return NotFound();
            }


            await _hotel.Delete(id);
           return NoContent();

        }

        
    }
}
