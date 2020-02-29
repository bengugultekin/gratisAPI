using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using gratisAPI.Model;

namespace gratisAPI.Data
{
    public class gratisAPIContext : DbContext
    {
        public gratisAPIContext (DbContextOptions<gratisAPIContext> options)
            : base(options)
        {
        }

        public DbSet<gratisAPI.Model.Category> Category { get; set; }

        public DbSet<gratisAPI.Model.Product> Product { get; set; }

        public DbSet<gratisAPI.Model.Brand> Brand { get; set; }

        public DbSet<gratisAPI.Model.Store> Store { get; set; }
    }
}
