using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.API.Models
{
    public class Note 
    {
        public Guid NoteId { get; set; }
        public virtual Event Event{ get; set; }
        
    }
}
