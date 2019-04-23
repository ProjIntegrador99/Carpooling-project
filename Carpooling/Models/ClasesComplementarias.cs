﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Carpooling.Models
{
    public partial class Tribu
    {
        public Tribu()
        {
            this.UsuariosTribus = new HashSet<UsuarioTribu>();
        }
        [Key]
        [Required]
        public int Id { get; set; }
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public string GeneroMusical { get; set; }

        public virtual ICollection<UsuarioTribu> UsuariosTribus { get; set; }
    }

    public partial class UsuarioTribu
    {
        [Required]
        public int TribuId { get; set; }
        [Required]
        public String UsuarioId { get; set; }

        public virtual Tribu Tribus { get; set; }
        public virtual Usuario Usuarios { get; set; }
    }

    public partial class UsuarioViaje
    {
        [Required]
        public int ViajeId { get; set; }
        [Required]
        public String UsuarioId { get; set; }

        public virtual Viaje Viajes { get; set; }
        public virtual Usuario Usuarios { get; set; }
    }

    public partial class Vehiculo
    {
        [Required]
        public string Placa { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public String UsuarioId { get; set; }
    }

    public partial class Viaje
    {
        public Viaje()
        {
            this.UsuariosViajes = new HashSet<UsuarioViaje>();
            
        }
        [Key]
        [Required]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        [Required, DataType(DataType.DateTime)]
        public DateTime Hora { get; set; }
        public string TipoViaje { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public int Cupos { get; set; }

        [Required]
        public string NombreConductor { get; set; }


        public virtual ICollection<UsuarioViaje> UsuariosViajes { get; set; }
    }



}