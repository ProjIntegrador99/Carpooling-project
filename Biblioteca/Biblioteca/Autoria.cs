//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biblioteca
{
    using System;
    using System.Collections.Generic;
    
    public partial class Autoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Autoria()
        {
            this.Rol = "Principal";
        }
    
        public string Rol { get; set; }
        public int DocumentoIndex { get; set; }
        public int AutorId { get; set; }
    
        public virtual Documento Documento { get; set; }
        public virtual Autor Autor { get; set; }
    }
}
