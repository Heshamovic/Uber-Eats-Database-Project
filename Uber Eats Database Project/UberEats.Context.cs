﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Uber_Eats_Database_Project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CUSTOMER> CUSTOMERs { get; set; }
        public virtual DbSet<DELIVERY_PARTNER> DELIVERY_PARTNER { get; set; }
        public virtual DbSet<FOOD> FOODs { get; set; }
        public virtual DbSet<ORDER_FOOD> ORDER_FOOD { get; set; }
        public virtual DbSet<ORDER> ORDERS { get; set; }
        public virtual DbSet<REST_NUMBERS> REST_NUMBERS { get; set; }
        public virtual DbSet<RESTAURANT> RESTAURANTs { get; set; }
        public virtual DbSet<TRIP> TRIPs { get; set; }
        public virtual DbSet<WORKING_TIME> WORKING_TIME { get; set; }
    }
}
