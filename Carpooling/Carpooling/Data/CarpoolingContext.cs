using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Carpooling.Models
{
    public class CarpoolingContext : DbContext
    {
        public CarpoolingContext (DbContextOptions<CarpoolingContext> options)
            : base(options)
        {
        }

        public DbSet<Carpooling.Models.Viaje> Viaje { get; set; }
    }
}
