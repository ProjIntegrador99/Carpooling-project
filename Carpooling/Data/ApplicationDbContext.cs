using System;
using System.Collections.Generic;
using System.Text;
using Carpooling.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Carpooling.Data
{
    public class ApplicationDbContext : IdentityDbContext<Usuario, RolUsuario, String>
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
            builder.Entity<Vehiculo>().HasKey(d => d.Placa);
            builder.Entity<UsuarioTribu>().HasKey(d => new { d.UsuarioId, d.TribuId });
            builder.Entity<UsuarioViaje>().HasKey(d => new { d.UsuarioId, d.ViajeId });
            builder.Entity<UsuarioSolicitud>().HasKey(d => new { d.UsuarioId, d.SolicitudId });
            builder.Entity<Solicitud>().HasKey(d => d.SolicitudId);

        }

        public DbSet<Viaje> Viaje { get; set; }

        public DbSet<Vehiculo> Vehiculo { get; set; }

        public DbSet<Tribu> Tribu { get; set; }

        public DbSet<UsuarioTribu> UsuariosTribus { get; set; }

        public DbSet<UsuarioViaje> UsuariosViajes { get; set; }

        public DbSet<UsuarioSolicitud> UsuariosSolicitudes { get; set; }
            
        public DbSet<Solicitud> Solicitudes { get; set; }


    }
}
