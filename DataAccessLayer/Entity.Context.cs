﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IMSDevelopmentEntities : DbContext
    {
        public IMSDevelopmentEntities()
            : base("name=IMSDevelopmentEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ACTIVITY_MASTER> ACTIVITY_MASTER { get; set; }
        public DbSet<AM_Item_Master> AM_Item_Master { get; set; }
        public DbSet<AM_ItemCategory_Master> AM_ItemCategory_Master { get; set; }
        public DbSet<BankMaster> BankMasters { get; set; }
        public DbSet<Blood_Group_Master> Blood_Group_Master { get; set; }
        public DbSet<Category_Mst> Category_Mst { get; set; }
    }
}