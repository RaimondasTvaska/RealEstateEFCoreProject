using Microsoft.EntityFrameworkCore;
using RealEstateEFCoreProject.Models;

namespace RealEstateEFCoreProject.Data
{
    public class DataContext : DbContext
    {
        public DbSet<BrokerModel> Brokers { get; set; }
        public DbSet<CompanyModel> Companies { get; set; }
        public DbSet<ApartmentModel> Apartments { get; set; }
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            

        //    modelBuilder.Entity<BrokerModel>()
        //        .HasMany(s => s.Companies)
        //        .WithOne(si => si.BrokerId)
        //        .HasForeignKey(si => si.CompanyId);

            

        //}

    }
}
