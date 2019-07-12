using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Sajin_Web.API.Models.Infrastructures;

namespace Sajin_Web.API.Models
{
    public abstract class BaseEntity
    {
        public bool Deleted { get; set; }
    }

    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual T Id { get; set; }
    }
}
