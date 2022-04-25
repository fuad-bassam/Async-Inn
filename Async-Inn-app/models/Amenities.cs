using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models
{
    public class Amenities
    {


        [Key]
        public int amenitiesId { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public decimal price { get; set; }


        public virtual List<RoomsAmenities> roomsAmenities { get; set; }

    }
}
