using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models
{
    public class Employees
    {
        
        [Key]
        public int empId { get; set; }

        public string workTitle { get; set; }

        public decimal salary { get; set; }


        [ForeignKey("hotelId")]
        public int hotelId { get; set; }


        public virtual HotelBranches HotelBranches { get; set; }

        //public int hotelId { get; set; }
    }
}
