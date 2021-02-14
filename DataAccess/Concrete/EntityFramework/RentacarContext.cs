using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentacarContext : DbContext
    {
        //bu metod projenin hangi veri tabanı ile ilişkili olduğunu belirtmek için kullanılır
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=Rentacar; Trusted_Connection=true");
        }

        //hangi class hangi tabloya denk gelir onun belirlenmesi
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Rental>().Property(p => p.RentId).HasColumnName("RentId");
            modelBuilder.Entity<User>().Property(p => p.Id).HasColumnName("Id");
            //modelBuilder.Entity<Customer>().Property(p => p.UserId).HasColumnName("CustomerId");
            //modelBuilder.Entity<Car>().Property(p => p.CarId).HasColumnName("CarId");
            //modelBuilder.Entity<Color>().Property(p => p.ColorId).HasColumnName("ColorId");
            //modelBuilder.Entity<Brand>().Property(p => p.BrandId).HasColumnName("BrandId");
            modelBuilder.Entity<Rental>().HasKey(r => r.RentId);
        }
    }
}
