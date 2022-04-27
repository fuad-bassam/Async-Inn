using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models.DTO
{
    public class HotelBranchesDTO
    {
    
        public int hotelId { get; set; }

        public string name { get; set; }
       
        public string city { get; set; }

        public string state { get; set; }
       
        public string address { get; set; }

        public String phoneNum { get; set; }

        public List<RoomsDto> Rooms { get; set; }
    }
}
