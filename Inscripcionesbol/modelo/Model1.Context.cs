﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class InscripcionesBoliviaEntities : DbContext
    {
        public InscripcionesBoliviaEntities()
            : base("name=InscripcionesBoliviaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<TCurso> TCurso { get; set; }
        public DbSet<TDocente> TDocente { get; set; }
        public DbSet<TEstudiante> TEstudiante { get; set; }
        public DbSet<TInscripciones> TInscripciones { get; set; }
        public DbSet<TUsuario> TUsuario { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
