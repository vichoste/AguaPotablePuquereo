﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AguaPotablePuquereo.Models.SQL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PuquerosBDD : DbContext
    {
        public PuquerosBDD()
            : base("name=PuquerosBDD")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_CARRO_COMPRA> TBL_CARRO_COMPRA { get; set; }
        public virtual DbSet<TBL_CLIENTE> TBL_CLIENTE { get; set; }
        public virtual DbSet<TBL_ESTADO_CARRO> TBL_ESTADO_CARRO { get; set; }
        public virtual DbSet<TBL_LOG> TBL_LOG { get; set; }
        public virtual DbSet<TBL_MES> TBL_MES { get; set; }
        public virtual DbSet<TBL_PAGOS> TBL_PAGOS { get; set; }
        public virtual DbSet<TBL_USUARIO> TBL_USUARIO { get; set; }
        public virtual DbSet<TBL_PAGINAS_ADMINISTRABLES> TBL_PAGINAS_ADMINISTRABLES { get; set; }
        public virtual DbSet<TBL_DEUDA> TBL_DEUDA { get; set; }
    }
}
