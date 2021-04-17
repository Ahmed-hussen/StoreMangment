using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace UI
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<WareHouse> WareHouses { get; set; }
        public virtual DbSet<WareHouseItem> WareHouseItems { get; set; }
        public virtual DbSet<WareHouseSupplier> WareHouseSuppliers { get; set; }
        public virtual DbSet<WithDraw> WithDraws { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.HomeNumebr)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Website)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.WithDraws)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.IdCustomer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.WareHouseItems)
                .WithRequired(e => e.Item)
                .HasForeignKey(e => e.IdItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.WareHouseSuppliers)
                .WithRequired(e => e.Item)
                .HasForeignKey(e => e.IdItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.WithDraws)
                .WithRequired(e => e.Item)
                .HasForeignKey(e => e.IdItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.HomeNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Website)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.WareHouseSuppliers)
                .WithRequired(e => e.Supplier)
                .HasForeignKey(e => e.IdSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.WithDraws)
                .WithRequired(e => e.Supplier)
                .HasForeignKey(e => e.IdSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WareHouse>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<WareHouse>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<WareHouse>()
                .Property(e => e.Supervisor)
                .IsUnicode(false);

            modelBuilder.Entity<WareHouse>()
                .HasMany(e => e.WareHouseItems)
                .WithRequired(e => e.WareHouse)
                .HasForeignKey(e => e.IdWareHouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WareHouse>()
                .HasMany(e => e.WareHouseSuppliers)
                .WithRequired(e => e.WareHouse)
                .HasForeignKey(e => e.IdWareHouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WareHouse>()
                .HasMany(e => e.WithDraws)
                .WithRequired(e => e.WareHouse)
                .HasForeignKey(e => e.IdWareHouse)
                .WillCascadeOnDelete(false);
        }
    }
}
