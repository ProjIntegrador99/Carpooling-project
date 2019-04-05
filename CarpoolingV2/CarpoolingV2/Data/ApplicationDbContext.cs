using System;
using System.Collections.Generic;
using System.Text;
using CarpoolingV2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarpoolingV2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Tribu>().HasKey(d => d.Id);
            builder.Entity<Viaje>().HasKey(d => d.Id);
            builder.Entity<Usuario>().HasKey(d => d.Id);
            builder.Entity<Vehiculo>().HasKey(d => d.Placa);
            builder.Entity<UsuarioTribu>().HasKey(d => new { d.UsuarioId, d.TribuId });
            builder.Entity<UsuarioViaje>().HasKey(d => new { d.UsuarioId, d.ViajeId });

        }

        public DbSet<CarpoolingV2.Models.Tribu> Tribu { get; set; }

        public DbSet<CarpoolingV2.Models.Usuario> Usuario { get; set; }

        public DbSet<CarpoolingV2.Models.Vehiculo> Vehiculo { get; set; }

        public DbSet<CarpoolingV2.Models.Viaje> Viaje { get; set; }


    }
}
