using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sajin_Web.API.Models.Infrastructures
{
    interface IEntity<T>
    {
       T Id { get; set; }
    }
}
