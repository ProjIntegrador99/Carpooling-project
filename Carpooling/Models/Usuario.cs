using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public String Direccion { get; set; }
        public String Ciudad { get; set; }
        [NotMapped]
        public Tribu TribuAgregar { get; set; }


        //public Byte[] imagenPre { get; set; }
        [Required]
        public String Area { get; set; }
        public String Pais { get; set; }
        public double PromedioCalificacionPasajero { get; set; }
        public double PromedioCalificacionConductor { get; set; }
        
        public virtual ICollection<UsuarioViaje> UsuariosViajes { get; set; }
        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
        public virtual ICollection<UsuarioTribu> UsuariosTribus { get; set; }

        public string ImagenFinal { get; set; }


        public void CambiarImagen(String imagen)
        {
            ImagenFinal = imagen;

        }

        public void CambiarArea(String area)
        {
            Area = area;

        }

        public void CambiarNick(String nick)
        {
            Nick = nick;

        }


    }





}
