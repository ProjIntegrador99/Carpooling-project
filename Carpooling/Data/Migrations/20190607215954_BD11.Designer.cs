﻿// <auto-generated />
using System;
using Carpooling.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Carpooling.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190607215954_BD11")]
    partial class BD11
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Carpooling.Models.RolUsuario", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("Creacion");

                    b.Property<string>("Descripcion");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Carpooling.Models.Solicitud", b =>
                {
                    b.Property<string>("SolicitudId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cupos");

                    b.Property<string>("Descripcion");

                    b.Property<string>("Estado")
                        .IsRequired();

                    b.Property<DateTime>("Hora");

                    b.Property<string>("NombreConductor")
                        .IsRequired();

                    b.Property<string>("TipoViaje")
                        .IsRequired();

                    b.Property<string>("UsuarioId")
                        .IsRequired();

                    b.HasKey("SolicitudId");

                    b.ToTable("Solicitudes");
                });

            modelBuilder.Entity("Carpooling.Models.Tribu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Creator")
                        .IsRequired();

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<string>("GeneroMusical")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Tribu");
                });

            modelBuilder.Entity("Carpooling.Models.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<string>("Area")
                        .IsRequired();

                    b.Property<string>("Ciudad");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Direccion");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("ImagenFinal");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Nick")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("Pais");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<double>("PromedioCalificacionConductor");

                    b.Property<double>("PromedioCalificacionPasajero");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Carpooling.Models.UsuarioSolicitud", b =>
                {
                    b.Property<string>("UsuarioId");

                    b.Property<string>("SolicitudId");

                    b.HasKey("UsuarioId", "SolicitudId");

                    b.HasIndex("SolicitudId");

                    b.ToTable("UsuariosSolicitudes");
                });

            modelBuilder.Entity("Carpooling.Models.UsuarioTribu", b =>
                {
                    b.Property<string>("UsuarioId");

                    b.Property<int>("TribuId");

                    b.HasKey("UsuarioId", "TribuId");

                    b.HasIndex("TribuId");

                    b.ToTable("UsuariosTribus");
                });

            modelBuilder.Entity("Carpooling.Models.UsuarioViaje", b =>
                {
                    b.Property<string>("UsuarioId");

                    b.Property<int>("ViajeId");

                    b.HasKey("UsuarioId", "ViajeId");

                    b.HasIndex("ViajeId");

                    b.ToTable("UsuariosViajes");
                });

            modelBuilder.Entity("Carpooling.Models.Vehiculo", b =>
                {
                    b.Property<string>("Placa")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color")
                        .IsRequired();

                    b.Property<string>("Marca")
                        .IsRequired();

                    b.Property<string>("Modelo")
                        .IsRequired();

                    b.Property<string>("UsuarioId")
                        .IsRequired();

                    b.HasKey("Placa");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Vehiculo");
                });

            modelBuilder.Entity("Carpooling.Models.Viaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cupos");

                    b.Property<string>("Descripcion");

                    b.Property<bool>("EsMio");

                    b.Property<string>("Estado")
                        .IsRequired();

                    b.Property<DateTime>("Hora");

                    b.Property<string>("NombreConductor")
                        .IsRequired();

                    b.Property<string>("TipoViaje");

                    b.Property<string>("emailotro");

                    b.HasKey("Id");

                    b.ToTable("Viaje");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Carpooling.Models.UsuarioSolicitud", b =>
                {
                    b.HasOne("Carpooling.Models.Solicitud", "Solicitud")
                        .WithMany()
                        .HasForeignKey("SolicitudId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Carpooling.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Carpooling.Models.UsuarioTribu", b =>
                {
                    b.HasOne("Carpooling.Models.Tribu", "Tribus")
                        .WithMany("UsuariosTribus")
                        .HasForeignKey("TribuId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Carpooling.Models.Usuario", "Usuarios")
                        .WithMany("UsuariosTribus")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Carpooling.Models.UsuarioViaje", b =>
                {
                    b.HasOne("Carpooling.Models.Usuario", "Usuarios")
                        .WithMany("UsuariosViajes")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Carpooling.Models.Viaje", "Viajes")
                        .WithMany("UsuariosViajes")
                        .HasForeignKey("ViajeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Carpooling.Models.Vehiculo", b =>
                {
                    b.HasOne("Carpooling.Models.Usuario")
                        .WithMany("Vehiculos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Carpooling.Models.RolUsuario")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Carpooling.Models.Usuario")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Carpooling.Models.Usuario")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Carpooling.Models.RolUsuario")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Carpooling.Models.Usuario")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Carpooling.Models.Usuario")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
