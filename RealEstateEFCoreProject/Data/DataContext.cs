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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyModel>()
                .HasMany(c => c.Apartments)
                .WithOne(e => e.Company);

        //    modelBuilder.Entity<BookCategory>()
        //.HasKey(bc => new { bc.BookId, bc.CategoryId });
        //    modelBuilder.Entity<BookCategory>()
        //        .HasOne(bc => bc.Book)
        //        .WithMany(b => b.BookCategories)
        //        .HasForeignKey(bc => bc.BookId);
        //    modelBuilder.Entity<BookCategory>()
        //        .HasOne(bc => bc.Category)
        //        .WithMany(c => c.BookCategories)
        //        .HasForeignKey(bc => bc.CategoryId);
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
