﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eikones
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class schuldbEntities : DbContext
    {
        public schuldbEntities()
            : base("name=schuldbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tfaecher> tfaechers { get; set; }
        public DbSet<tklassen> tklassens { get; set; }
        public DbSet<tlehrer> tlehrers { get; set; }
        public DbSet<tpruefungen> tpruefungens { get; set; }
        public DbSet<traeume> traeumes { get; set; }
        public DbSet<tschueler> tschuelers { get; set; }
        public DbSet<tstunden> tstundens { get; set; }
        public DbSet<tunterricht> tunterrichts { get; set; }
    }
}