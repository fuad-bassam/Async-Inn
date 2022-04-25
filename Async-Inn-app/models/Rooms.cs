using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models
{
    public class Rooms
    {


        [ForeignKey("hotelId")]
        public int hotelId { get; set; }


        [Required]
        public int roomId { get; set; }


        public string nickName { get; set; }

        public int space { get; set; }

        public decimal price { get; set; }


        public virtual HotelBranches HotelBranches { get; set; }
        public int visitorId { get; set; }
        public virtual List<RoomsAmenities> roomsAmenities { get; set; }


        // public int visitorId { get; set; }

    }
}
