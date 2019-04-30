using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Carpooling.Models
{
    public class Usuario : IdentityUser
    {
        public Usuario() : base() {
            this.UsuariosViajes = new HashSet<UsuarioViaje>();
            this.Vehiculos = new HashSet<Vehiculo>();
            this.UsuariosTribus = new HashSet<UsuarioTribu>();
        }

        [Required]
        public String Nombre { get; set; }
        [Required]
        public String Nick { get; set; }
        [Required]
        public String Apellido { get; set; }
        [Required]
        public String Direccion { get; set; }
        [Required]
        public String Ciudad { get; set; }
        [Required]
        public String Area { get; set; }
        [Required]
        public String Pais { get; set; }
        public double PromedioCalificacionPasajero { get; set; }
        public double PromedioCalificacionConductor { get; set; }
        
        public virtual ICollection<UsuarioViaje> UsuariosViajes { get; set; }
        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
        public virtual ICollection<UsuarioTribu> UsuariosTribus { get; set; }
    }
}
