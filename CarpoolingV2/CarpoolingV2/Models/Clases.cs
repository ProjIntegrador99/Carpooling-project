using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarpoolingV2.Models
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

    public partial class Usuario
    {
        public Usuario()
        {
            this.UsuariosViajes = new HashSet<UsuarioViaje>();
            this.Vehiculos = new HashSet<Vehiculo>();
            this.UsuariosTribus = new HashSet<UsuarioTribu>();
        }
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nickname { get; set; }
        public string Nombre { get; set; }
        [Required]
        public string Area { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Telefono { get; set; }
        [Required,DataType(DataType.Password)]
        public string Contraseña { get; set; }
        public double CalificacionPromedioPasajero { get; set; }
        public double CalificacionPromedioConductor { get; set; }

        public virtual ICollection<UsuarioViaje> UsuariosViajes { get; set; }
        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
        public virtual ICollection<UsuarioTribu> UsuariosTribus { get; set; }
    }


    public partial class UsuarioTribu
    {
        [Required]
        public int TribuId { get; set; }
        [Required]
        public int UsuarioId { get; set; }

        public virtual Tribu Tribus { get; set; }
        public virtual Usuario Usuarios { get; set; }
    }

    public partial class UsuarioViaje
    {
        [Required]
        public int ViajeId { get; set; }
        [Required]
        public int UsuarioId { get; set; }

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
        //mig
     //   public int UsuarioId { get; set; }

      //  public virtual Usuario Usuario { get; set; }
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

        public string NombreConductor { get; set; }

        public virtual ICollection<UsuarioViaje> UsuariosViajes { get; set; }
    }
}
