﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models
{
    public class RoomsAmenities
    {
        //[ForeignKey("roomId")]
        //public int roomId { get; set; }

        //public int roomId { get; set; }

        //public int featureId { get; set; }


        public Rooms rooms { get; set; }

        public Amenities amenities { get; set; }

        public bool canRemove { get; set; }
    }
}
