﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentalDBApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MovieDatabase : DbContext
    {
        public MovieDatabase()
            : base("name=MovieDatabase")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CONTACT_METHOD> CONTACT_METHODs { get; set; }
        public virtual DbSet<GENRE> GENREs { get; set; }
        public virtual DbSet<MEMBER> MEMBERs { get; set; }
        public virtual DbSet<MOVIE> MOVIEs { get; set; }
        public virtual DbSet<RENTAL> RENTALs { get; set; }
        public virtual DbSet<SUBSCRIPTION> SUBSCRIPTIONs { get; set; }
        public virtual DbSet<VENDOR> VENDORs { get; set; }
        
    }
}