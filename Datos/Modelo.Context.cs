﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NovaCordEntities : DbContext
    {
        public NovaCordEntities()
            : base("name=NovaCordEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Modulos> Modulos { get; set; }
        public virtual DbSet<Pantallas> Pantallas { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<SubOpciones> SubOpciones { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<AHORROS_BIT_TRAS> AHORROS_BIT_TRAS { get; set; }
    }
}
