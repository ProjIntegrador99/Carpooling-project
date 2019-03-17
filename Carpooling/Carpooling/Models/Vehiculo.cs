using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpooling.Models
{
	public class Vehiculo
	{
		public String Placa { get; set; }
		public String Marca { get; set; }
		public String Color { get; set; }

		public Vehiculo(string placa, string marca, string color)
		{
			Placa = placa;
			Marca = marca;
			Color = color;
		}
	}

}
