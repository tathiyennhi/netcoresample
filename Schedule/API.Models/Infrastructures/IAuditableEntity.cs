using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.API.Models.Infrastructures
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
