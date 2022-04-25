using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models
{
    public class HotelBranches
    {

        [Key]
        public int hotelId { get; set; }

        [Required]
        public string name { get; set; }
        [Required]
        public string city { get; set; }

        public string state { get; set; }
        [Required]
        public string address { get; set; }

        public String phoneNum { get; set; }

        public int roomsNum { get; set; }
        public virtual List<Rooms> rooms { get; set; }

      
        //public int empId { get; set; }

        //public virtual List<Employees> Employees { get; set; }

    }
}
