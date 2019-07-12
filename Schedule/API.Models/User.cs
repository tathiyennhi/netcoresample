using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sajin_Web.API.Models.Infrastructures;
using Schedule.API.Models;

namespace Sajin_Web.API.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string PassWord { get; set; }
        public string AvaPic { get; set; }
        public virtual Event Event { get; set; }
    }
}
