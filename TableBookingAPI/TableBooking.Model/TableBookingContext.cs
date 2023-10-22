﻿using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TableBooking.Model.Models;

namespace TableBooking.Model
{
    public class TableBookingContext : DbContext//IdentityDbContext<AppUser>
    {
        public TableBookingContext() { }
        public TableBookingContext(DbContextOptions<TableBookingContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=TableBookingDB;Username=TableBookingUser;Password=postgres");
            }
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}