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
    public class RoomsController : ControllerBase
    {

        private readonly IRooms _rooms;
        public RoomsController(IRooms rooms)
        {
            _rooms = rooms;
        }

        // GET: api/Rooms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rooms>>> GetRooms()
        {
            var rooms = await _rooms.GetRooms();
            return Ok(rooms);
        }

        // GET: api/Rooms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rooms>> GetRooms(int id)
        {
            Rooms room = await _rooms.GetRoom(id);
            return Ok(room);
        }

        // PUT: api/Rooms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRooms(int id, Rooms rooms)
        {
            

            Rooms room = await _rooms.UpdateRoom(id, rooms);
            return Ok(room);
        }

        // POST: api/Rooms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Rooms>> PostRooms(Rooms rooms)
        {
            Rooms room = await _rooms.Create(rooms);
            return Ok(room);
        }

        // DELETE: api/Rooms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRooms(int id)
        {
            var rooms = await _rooms.GetRoom(id);
            if (rooms == null)
            {
                return NotFound();
            }


            await _rooms.Delete(id);
            return NoContent();

        }



        // GET: api/Rooms/5/Amenity/3
        [HttpPost("{roomId}/Amenity/{amenityId}")]
        public async Task<ActionResult> addRoomsAmenities(int hotelIdRoomId, int amenityId)
        {
            await _rooms.AddAmenityToRoom(hotelIdRoomId,amenityId);
            return NoContent();
            
        }

        // GET: api/Rooms/5/Amenity/3
        [HttpDelete("{roomId}/Amenity/{amenityId}")]
        public async Task<ActionResult> deleteRoomsAmenities(int hotelIdRoomId, int amenityId)
        {

            await _rooms.RemoveAmentityFromRoom(hotelIdRoomId , amenityId);
            return NoContent();

        }
    }
}
