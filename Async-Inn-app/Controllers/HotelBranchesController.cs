using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Async_Inn_app.data;
using Async_Inn_app.models;

namespace Async_Inn_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelBranchesController : ControllerBase
    {
        private readonly AsyncInnDbContext _context;

        public HotelBranchesController(AsyncInnDbContext context)
        {
            _context = context;
        }

        // GET: api/HotelBranches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelBranches>>> GetHotelBranches()
        {
            return await _context.HotelBranches.ToListAsync();
        }

        // GET: api/HotelBranches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HotelBranches>> GetHotelBranches(int id)
        {
            var hotelBranches = await _context.HotelBranches.FindAsync(id);

            if (hotelBranches == null)
            {
                return NotFound();
            }

            return hotelBranches;
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

            _context.Entry(hotelBranches).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelBranchesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/HotelBranches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HotelBranches>> PostHotelBranches(HotelBranches hotelBranches)
        {
            _context.HotelBranches.Add(hotelBranches);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHotelBranches", new { id = hotelBranches.hotelId }, hotelBranches);
        }

        // DELETE: api/HotelBranches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotelBranches(int id)
        {
            var hotelBranches = await _context.HotelBranches.FindAsync(id);
            if (hotelBranches == null)
            {
                return NotFound();
            }

            _context.HotelBranches.Remove(hotelBranches);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HotelBranchesExists(int id)
        {
            return _context.HotelBranches.Any(e => e.hotelId == id);
        }
    }
}
