﻿using Microsoft.EntityFrameworkCore;
using RealEstateEFCoreProject.Models;

namespace RealEstateEFCoreProject.Data
{
    public class DataContext : DbContext
    {
        public DbSet<BrokerModel> Brokers { get; set; }
        public DbSet<CompanyModel> Companies { get; set; }
        public DbSet<ApartmentModel> Apartments { get; set; }
        public DbSet<CompanyBrokers> CompanyBrokers { get; set; }
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyModel>()
                .HasMany(c => c.Apartments)
                .WithOne(e => e.Company);

            modelBuilder.Entity<CompanyBrokers>()
                .HasKey(bc => new { bc.CompanyId, bc.BrokerId });
            modelBuilder.Entity<CompanyBrokers>()
                .HasOne(bc => bc.Company)
                .WithMany(b => b.CompanyBrokers)
                .HasForeignKey(bc => bc.CompanyId);
            modelBuilder.Entity<CompanyBrokers>()
                .HasOne(bc => bc.Broker)
                .WithMany(c => c.CompanyBrokers)
                .HasForeignKey(bc => bc.BrokerId);
        }
    }
}
