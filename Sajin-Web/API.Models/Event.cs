using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.API.Models
{
    public class Event
    {
        public Guid EventID { get; set; }
        public string EventName { get; set; }
        public virtual DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
