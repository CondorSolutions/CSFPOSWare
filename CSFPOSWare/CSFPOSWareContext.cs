using CSFPOSWare.Models;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFPOSWare
{
    public class CSFPOSWareContext : DbContext
    {
        //1. add DBSets
        //1.a. existing tables
        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDiscount> SaleDiscounts { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }
        public DbSet<SaleItemDiscount> SaleItemDiscounts { get; set; }
        public DbSet<SaleTax> SaleTaxes { get; set; }
        public DbSet<SaleTender> SaleTender { get; set; }
        public DbSet<Tax> Taxes { get; set; }

        //1.b. new tables
        public DbSet<CSConfiguration> CSConfigurations { get; set; }
        public DbSet<CSEod> CSEods { get; set; }
        public DbSet<CSSale> CSSales { get; set; }
        public DbSet<CSSaleItem> CSSaleItems { get; set; }
        public DbSet<CSSaleItemDiscount> CSSaleItemDiscounts { get; set; }
        public DbSet<CSSaleItemTax> CSSaleItemTaxes { get; set; }
        public DbSet<CSSaleTender> CSSaleTenders { get; set; }

        //2. Add-Migration AddExistingTable_OtherTables
        //3. Update-Database

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //CSSale
            modelBuilder.Entity<CSSale>()
              .Property(p => p.GrossSales)
              .HasColumnType("decimal(18,4)");
            modelBuilder.Entity<CSSale>()
               .Property(p => p.NetSales)
               .HasColumnType("decimal(18,4)");
            modelBuilder.Entity<CSSale>()
             .Property(p => p.Tip)
             .HasColumnType("decimal(18,4)");
            modelBuilder.Entity<CSSale>()
              .Property(p => p.ExcessGC)
              .HasColumnType("decimal(18,4)");
            modelBuilder.Entity<CSSale>()
              .Property(p => p.otherCharges)
              .HasColumnType("decimal(18,4)");
            modelBuilder.Entity<CSSale>()
             .Property(p => p.serviceCharge)
             .HasColumnType("decimal(18,4)");

            //CSSaleItem
            modelBuilder.Entity<CSSaleItem>()
              .Property(p => p.AmountDue)
              .HasColumnType("decimal(18,4)");
            modelBuilder.Entity<CSSaleItem>()
              .Property(p => p.BasePrice)
              .HasColumnType("decimal(18,4)");

            //CSSaleItemDiscount
            modelBuilder.Entity<CSSaleItemDiscount>()
             .Property(p => p.Amount)
             .HasColumnType("decimal(18,4)");

            //CSSaleItemTax
            modelBuilder.Entity<CSSaleItemTax>()
             .Property(p => p.Amount)
             .HasColumnType("decimal(18,4)");
            modelBuilder.Entity<CSSaleItemTax>()
             .Property(p => p.Tax)
             .HasColumnType("decimal(18,4)");

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(@"Server=LENOVO-PC\CESSQL;Database=FPOSWARE;Trusted_Connection=True;");

            //string server = "JOHN-PC\\CESSQL";
            //string database = "fposware_v3_prego";

            string server = "JOHN-PC\\CESSQL";
            string database = "fposware_v3_prego";
            optionsBuilder.UseSqlServer(@"Data Source=" + server + ";;Persist Security Info=True;User ID=sa;Password=ces_sql2008;Initial Catalog=" + database + "");
        }

    }
}