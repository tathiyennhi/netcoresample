using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sajin_Web.API.Models;

namespace Schedule.API.Models.Infrastructures
{
    public class ScheduleDBContext : DbContext
    {
        public IHttpContextAccessor _httpContextAccessor;
        public DbSet<Note> Notes { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=Nhi1;User ID=sa;password=abc123;");
        }
    }

}
