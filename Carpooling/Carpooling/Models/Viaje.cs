using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpooling.Models
{
    public class Viaje
    {
        const String VENIDA = "VENIDA";
        const String IDA = "IDA";
        const String FINALIZADO = "FINALIZADO";
        const String DISPONIBLE = "DISPONIBLE";

        public int Id { get; set; }

        public String Descripcion { get; set; }
        public DateTime Hora { get; set; }
        public String TipoViaje { get; set; }
        public DateTime Fecha { get; set; }
        public String Estado { get; set; }
        public int CantidadCupos { get; set; }
        public List<Usuario> Cupos { get; set; }

        public Viaje(string descripcion, DateTime hora, string tipoViaje, DateTime fecha, string estado, int cantidadCupos)
        {
            Descripcion = descripcion;
            Hora = hora;
            TipoViaje = tipoViaje;
            Fecha = fecha;
            Estado = estado;
            CantidadCupos = cantidadCupos;
            Cupos = new List<Usuario>();
        }
    }
}