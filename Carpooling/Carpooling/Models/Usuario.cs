using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpooling.Models
{
	public class Usuario
	{
		
		const String PASAJERO = "PASAJERO";
		const String CONDUCTOR = "CONDUCTOR";
		public String Nombre { get; set; }
		public String Area { get; set; }
		public String Correo { get; set; }
		public String Telefono { get; set; }
		public String Clasificacion { get; set; }
		public String Contraseña { get; set; }
		public List<Viaje> Viajes { get; set; }

		public List<Vehiculo> Vehiculos { get; set; }

		public List<Tribu> Tribus { get; set; }

		public Usuario(string nombre, string area, string correo, string telefono, string clasificacion, string contraseña)
		{
			Nombre = nombre;
			Area = area;
			Correo = correo;
			Telefono = telefono;
			Clasificacion = clasificacion;
			Contraseña = contraseña;
			Viajes = new List<Viaje>();
			Vehiculos = new List<Vehiculo>();
			Tribus = new List<Tribu>();
		}

		
	}
}
