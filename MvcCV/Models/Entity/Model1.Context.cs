﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCV.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCVEntities : DbContext
    {
        public DbCVEntities()
            : base("name=DbCVEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Admin> Tbl_Admin { get; set; }
        public virtual DbSet<Tbl_Deneyimlerim> Tbl_Deneyimlerim { get; set; }
        public virtual DbSet<Tbl_Egitimlerim> Tbl_Egitimlerim { get; set; }
        public virtual DbSet<Tbl_Hakkımda> Tbl_Hakkımda { get; set; }
        public virtual DbSet<Tbl_Hobilerim> Tbl_Hobilerim { get; set; }
        public virtual DbSet<Tbl_Iletisim> Tbl_Iletisim { get; set; }
        public virtual DbSet<Tbl_Sertifikalarim> Tbl_Sertifikalarim { get; set; }
        public virtual DbSet<Tbl_Yeteneklerim> Tbl_Yeteneklerim { get; set; }
        public virtual DbSet<TblSosyalMedya> TblSosyalMedya { get; set; }
    }
}
