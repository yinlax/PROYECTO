//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inscripcionesbol.modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class TCurso
    {
        public TCurso()
        {
            this.TInscripciones = new HashSet<TInscripciones>();
        }
    
        public int Id_Curso { get; set; }
        public string Capacidad { get; set; }
        public string Año { get; set; }
        public string Paralelo { get; set; }
        public string Turno { get; set; }
        public Nullable<int> Id_Docente { get; set; }
    
        public virtual TDocente TDocente { get; set; }
        public virtual ICollection<TInscripciones> TInscripciones { get; set; }
    }
}
