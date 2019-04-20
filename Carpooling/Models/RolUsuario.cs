using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpooling.Models
{
    public class RolUsuario : IdentityRole
    {

        public RolUsuario() : base() { }

        public RolUsuario(String nombreRol) : base(nombreRol) { }

        public RolUsuario(String nombreRol, String descripcionRol, DateTime creacion): base(nombreRol)
        {
            Descripcion = descripcionRol;
            Creacion = creacion;
        }

        public String Descripcion { get; set; }
        public DateTime Creacion { get; set; }


    }
}
