using EfEx.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using Npgsql;

namespace EfEx
{
    public class NorthwindContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseNpgsql("host=localhost;db=Northwind;uid=postgres;pwd=Trade01c3c4.");
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            

            modelBuilder.Entity<Category>().ToTable("categories");
            modelBuilder.Entity<Category>().Property(x => x.Id).HasColumnName("categoryid");
            modelBuilder.Entity<Category>().Property(x => x.Name).HasColumnName("categoryname");
            modelBuilder.Entity<Category>().Property(x => x.Description).HasColumnName("description");



            modelBuilder.Entity<Products>().ToTable("products");
            modelBuilder.Entity<Products>().Property(x => x.Id).HasColumnName("productid");
            modelBuilder.Entity<Products>().Property(x => x.Name).HasColumnName("productname");
            modelBuilder.Entity<Products>().Property(x => x.SupplierId).HasColumnName("supplierid");
            modelBuilder.Entity<Products>().Property(x => x.CategoryId).HasColumnName("categoryid");
            modelBuilder.Entity<Products>().Property(x => x.QuantityPerUnit).HasColumnName("quantityperunit");
            modelBuilder.Entity<Products>().Property(x => x.UnitPrice).HasColumnName("unitprice");
            modelBuilder.Entity<Products>().Property(x => x.UnitIsInStock).HasColumnName("unitisinstock");



            modelBuilder.Entity<Order>().ToTable("orders");
            modelBuilder.Entity<Order>().Property(x => x.Id).HasColumnName("orderid");
            modelBuilder.Entity<Order>().Property(x => x.OrderDate).HasColumnName("orderdate");
            modelBuilder.Entity<Order>().Property(x => x.RequiredDate).HasColumnName("requireddate");
            modelBuilder.Entity<Order>().Property(x => x.ShippedDate).HasColumnName("shippeddate");
            modelBuilder.Entity<Order>().Property(x => x.Freight).HasColumnName("freight");
            modelBuilder.Entity<Order>().Property(x => x.ShipName).HasColumnName("shipname");
            modelBuilder.Entity<Order>().Property(x => x.ShipCity).HasColumnName("shipcity");



            modelBuilder.Entity<OrderDetails>().ToTable("orderdetails");
            modelBuilder.Entity<OrderDetails>().Property(x => x.UnitPrice).HasColumnName("unitprice");
            modelBuilder.Entity<OrderDetails>().Property(x => x.Quantity).HasColumnName("quantity");
            modelBuilder.Entity<OrderDetails>().Property(x => x.Discount).HasColumnName("Discount");

        }
    }
}
