﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LaConquista_WF.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SistemaLaConquistaEntities : DbContext
    {
        public SistemaLaConquistaEntities()
            : base("name=SistemaLaConquistaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbCatalogoProductos> tbCatalogoProductos { get; set; }
        public virtual DbSet<tbCliente> tbCliente { get; set; }
        public virtual DbSet<tbDetallleFactura> tbDetallleFactura { get; set; }
        public virtual DbSet<tbEncabezadoFactura> tbEncabezadoFactura { get; set; }
        public virtual DbSet<tbProducto> tbProducto { get; set; }
        public virtual DbSet<tbProveedor> tbProveedor { get; set; }
        public virtual DbSet<tbUsuario> tbUsuario { get; set; }
    }
}
