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
    [Authorize(Roles = "DistrictManager")]

    public class RoomsController : ControllerBase
    {

        private readonly IRooms _rooms;
        public RoomsController(IRooms rooms)
        {
            _rooms = rooms;
        }


        // POST: api/Rooms
        [HttpPost]

        public async Task<ActionResult<RoomsDto>> PostRooms(RoomsDto rooms)
        {
            RoomsDto roomsDto = await _rooms.Create(rooms);
            return Ok(roomsDto);
        }
        // GET: api/Rooms
        [HttpGet]
        [AllowAnonymous]
        // [Authorize(Roles = "PropertyManager, DistrictManager")]
        public async Task<ActionResult<IEnumerable<RoomsDto>>> GetRooms()
        {
            var rooms = await _rooms.GetRooms();
            return Ok(rooms);
        }

        // GET: api/Rooms/1/101
        [HttpGet("{hotelId}/{roomId}")]
        // [Authorize(Roles = "PropertyManager, DistrictManager")]
        [AllowAnonymous]
        public async Task<ActionResult<RoomsDto>> GetRooms(int hotelId, int roomId)
        {

            RoomsDto room = await _rooms.GetRoom(hotelId,roomId);

            return Ok(room);
        }

        // PUT: api/Rooms/1/101
        [HttpPut("{hotelId}/{roomId}")]
        [Authorize(Roles = "PropertyManager, DistrictManager")]

        public async Task<IActionResult> PutRooms(int hotelId, int roomId, Rooms rooms)
        {

            RoomsDto room = await _rooms.UpdateRoom( hotelId, roomId, rooms);

            return Ok(room);
        }


        // DELETE: api/Rooms/1/101
        [HttpDelete("{hotelId}/{roomId}")]

        public async Task<IActionResult> DeleteRooms(int hotelId, int roomId)
        {

            var rooms = await _rooms.GetRoom(hotelId, roomId);

            if (rooms == null)
            {
                return NotFound();
            }



            await _rooms.Delete(hotelId,roomId);
            return NoContent();

        }



        // GET: api/Rooms/1/101/Amenity/31
        [HttpPost]
        [Route("{hotelId}/{roomId}/Amenity/{amenityId}")]
        [Authorize(Roles = "PropertyManager, DistrictManager , Agent")]


        public async Task<ActionResult<RoomsAmenities>> addRoomsAmenities(RoomsAmenities roomsAmenities)
        {
            RoomsAmenities roomsAmenities11 = await _rooms.AddAmenityToRoom(roomsAmenities);
            return Ok(roomsAmenities11);

        }

        // DELETE: api/Rooms/2/101/Amenity/11
        [HttpDelete("{hotelId}/{roomId}/Amenity/{amenityId}")]
        [Authorize(Roles = "PropertyManager, DistrictManager , Agent")]

        public async Task<ActionResult> deleteRoomsAmenities(int hotelId, int roomId, int amenityId)
        {

            await _rooms.RemoveAmentityFromRoom(hotelId, roomId, amenityId);
            return NoContent();

        }
    }
}
