using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sajin_Web.API.Models;

namespace Schedule.API.Models
{
    public class Event: BaseEntity
    {
        public Guid EventID { get; set; }
        public string EventName { get; set; }
        public virtual DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
