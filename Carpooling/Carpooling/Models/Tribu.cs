using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpooling.Models
{
	public class Tribu
	{	
		public String Nombre { get; set; }
		public String Descripcion { get; set; }
		public String[] Gustos { get; set; }

		public List<Usuario> Usuarios { get; set; }

		public Tribu(string nombre, string descripcion)
		{
			Nombre = nombre;
			Descripcion = descripcion;
			Usuarios = new List<Usuario>();
		}
	}
}
