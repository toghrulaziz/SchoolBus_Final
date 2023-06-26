using Microsoft.EntityFrameworkCore;
using SchoolBusFinalTask.Models.Abstracts;
using SchoolBusFinalTask.Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusFinalTask.Data
{
    internal class SchoolBusDbContext : DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer("Data Source=DESKTOP-BKIPR7J;Initial Catalog=SchoolBusFinalNew;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Class)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.ClassId);


            modelBuilder.Entity<Parent>()
                .HasMany(p => p.Students)
                .WithOne(s => s.Parent)
                .HasForeignKey(s => s.ParentId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Student>()
                .HasOne(s => s.Ride)
                .WithMany(r => r.Students)
                .HasForeignKey(s => s.RideId);


            modelBuilder.Entity<Car>()
                .HasOne(c => c.Driver)
                .WithOne(d => d.Car)
                .HasForeignKey<Driver>(d => d.CarId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Driver>()
                .HasMany(d => d.Rides)
                .WithOne(r => r.Driver)
                .HasForeignKey(r => r.DriverId);
        }


        public override int SaveChanges()
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedTime = data.Entity.ModifiedTime = DateTime.Now,
                    EntityState.Modified => data.Entity.ModifiedTime = DateTime.Now,
                    _ => DateTime.Now
                };
            }

            return base.SaveChanges();
        }


    }
}
