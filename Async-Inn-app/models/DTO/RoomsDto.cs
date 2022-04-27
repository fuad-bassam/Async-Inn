using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models.DTO
{
    public class RoomsDto
    {        
        public int hotelId { get; set; }

        public int roomId { get; set; }


        public string nickName { get; set; }

        public int space { get; set; }

        public bool PetFriendly { get; set; }
        public  List<AmenitiesDto> Amenities { get; set; }

    }
}
