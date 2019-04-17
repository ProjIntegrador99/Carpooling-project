using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Libreria
{
    public partial class Usuario
    {

        const String PASAJERO = "PASAJERO";
        const String CONDUCTOR = "CONDUCTOR";

        public Usuario()
        {
            this.Vehiculos = new HashSet<Vehiculo>();
            this.Tribus = new HashSet<Tribu>();
            this.Historiales = new HashSet<Viaje>();
        }

        public int Id { get; set; }
        [Required]
        public String Nombre { get; set; }
        public String Area { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public String Correo { get; set; }
        [Required, DataType(DataType.PhoneNumber)]
        public String Telefono { get; set; }
        public String Clasificacion { get; set; }
        public String Contraseña { get; set; }
        public virtual ICollection<Viaje> Historiales { get; set; }
        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
        public virtual Viaje ViajeActual { get; set; }
        public virtual ICollection<Tribu> Tribus { get; set; }
    }

    public partial class Vehiculo
    {
        public int Id { get; set; }
        [Required]
        public String Placa { get; set; }
        [Required]
        public String Marca { get; set; }
        [Required]
        public String Color { get; set; }

    }

    public partial class Tribu
    {

        public int Id { get; set; }
        [Required]
        public String Nombre { get; set; }
        [Required]
        public String Descripcion { get; set; }
        [Required]
      
        [NotMapped]
        public virtual ICollection<Usuario> Usuarios { get; set; }

        public Tribu()
        {
            Usuarios = new HashSet<Usuario>();
        }
    }

    public partial class Viaje
    { 
        const String VENIDA = "VENIDA";
        const String IDA = "IDA";
        const String FINALIZADO = "FINALIZADO";
        const String DISPONIBLE = "DISPONIBLE";

        public int Id { get; set; }
        public String Descripcion { get; set; }
        [Required]
        public DateTime Hora { get; set; }
        [Required]
        public String TipoViaje { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public String Estado { get; set; }
        [Required]
        public int CantidadCupos { get; set; }
        public virtual ICollection<Usuario> Cupos { get; set; }
        public virtual Usuario Conductor { get; set; }

        public Viaje()
        {
            Cupos = new HashSet<Usuario>();   
        }
    }









}
