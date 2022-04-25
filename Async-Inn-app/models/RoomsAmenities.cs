using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models
{
    public class RoomsAmenities
    {

        //[ForeignKey("roomId")]
        //public int RoomsroomId { get; set; }
        //[ForeignKey("hotelId")]
        //public int RoomshotelId { get; set; }

        [ForeignKey("roomId")]
        [Key]
        public int roomId { get; set; }
        [ForeignKey("hotelId")]
        [Key]
        public int hotelId { get; set; }
        [ForeignKey("amenitiesId")]
        [Key]
        public int amenitiesId { get; set; }

        public bool canRemove { get; set; }

        public virtual Rooms Rooms { get; set; }
        public virtual Amenities Amenities { get; set; }
     
    }
}
