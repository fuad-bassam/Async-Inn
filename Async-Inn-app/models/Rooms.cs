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
        [Key]
        public int hotelIdRoomId { get; set; }

        [Required]
        public int roomId { get; set; }


        public string nickName { get; set; }

        public int space { get; set; }

        public decimal price { get; set; }

        
        //[Display(Name = "HotelBranches")]

        [ForeignKey("hotelId")]
        public int hotelId { get; set; }

        public virtual HotelBranches HotelBranches { get; set; }


        //  public int hotelId { get; set; }

        public int visitorId { get; set; }

    }
}
