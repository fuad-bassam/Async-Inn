using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app.models
{
    public class WorkTime
    {

        [Key]
        public int scheduleId { get; set; }

        public int workDays { get; set; }

        public int shift { get; set; }

        public int date { get; set; }
    }
}
