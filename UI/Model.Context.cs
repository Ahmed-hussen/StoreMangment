//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CompanyEntities : DbContext
    {
        public CompanyEntities()
            : base("name=CompanyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<WareHouse> WareHouses { get; set; }
        public virtual DbSet<WareHouseItem> WareHouseItems { get; set; }
        public virtual DbSet<WareHouseSupplier> WareHouseSuppliers { get; set; }
        public virtual DbSet<WithDraw> WithDraws { get; set; }
    }
}
