using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models
{
    public class Visitors
    {
        [Key]
        public int visitorId { get; set; }

        public int days { get; set; }

        public int daysTotal { get; set; }


    }
}
