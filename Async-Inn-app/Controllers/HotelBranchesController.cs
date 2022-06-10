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
using Microsoft.AspNetCore.Authorization;

namespace Async_Inn_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "DistrictManager ")]

    public class HotelBranchesController : ControllerBase
    {
        private readonly IHotelBranches _hotel;

        public HotelBranchesController(IHotelBranches hotel)
        {
            _hotel = hotel;
        }

        // POST: api/HotelBranches
        [HttpPost]
        public async Task<ActionResult<HotelBranchesDTO>> PostHotelBranches(HotelBranchesDTO hotelBranchesDTO)
        {
            HotelBranchesDTO hotel = await _hotel.Create(hotelBranchesDTO);
            return Ok(hotel);
        }

        // GET: api/HotelBranches

        [HttpGet]
        [AllowAnonymous]
        //[Authorize(Roles = "PropertyManager, DistrictManager , Agent")]
        public async Task<ActionResult<IEnumerable<HotelBranches>>> GetHotelBranches()
        {
            var hotels = await _hotel.GetHotels();
            return Ok(hotels);
        }

        // GET: api/HotelBranches/1
        [HttpGet("{id}")]
        // [Authorize(Roles = "PropertyManager, DistrictManager , Agent")]
        [AllowAnonymous]
        public async Task<ActionResult<HotelBranchesDTO>> GetHotelBranches(int id)
        {
            HotelBranchesDTO hotelDTO = await _hotel.GetHotel(id);
            return Ok(hotelDTO);
        }

        // PUT: api/HotelBranches/2
        // "Agent"
        [HttpPut("{id}")]
        [Authorize(Roles = "PropertyManager, DistrictManager ")]

        public async Task<IActionResult> PutHotelBranches(int id, HotelBranchesDTO hotelBranchesDTO)
        {
            if (id != hotelBranchesDTO.hotelId)
            {
                return BadRequest();
            }

            HotelBranchesDTO hotel = await _hotel.UpdateHotel(id, hotelBranchesDTO);
            return Ok(hotel);
        }

     

        // DELETE: api/HotelBranches/2
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
