using Async_Inn_app.data;
using Async_Inn_app.models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models.Services
{
    public class HotelRoomRepository : IHotelRooms
    {


        private readonly AsyncInnDbContext _context;

        public HotelRoomRepository(AsyncInnDbContext context)
        {
            _context = context;
        }
      
    }
}
