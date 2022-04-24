using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models
{
    public class RoomsAmenities
    {
        [ForeignKey("roomId")]
        public int roomId { get; set; }
        [ForeignKey("hotelId")]
        public int hotelId { get; set; }
        public virtual Rooms Rooms { get; set; }

        public int amenitiesId { get; set; }
        public Amenities Amenities { get; set; }
        public bool canRemove { get; set; }
    }
}
