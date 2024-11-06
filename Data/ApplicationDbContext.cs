using BedBankReports.API.Extensions;
using BedBankReports.API.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace BedBankReports.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            modelBuilder.Entity<Rate>()
                        .Property(p => p.DiffEuro)
                        .HasComputedColumnSql("[OtherToPrice] - [OurBestPrice]");
            modelBuilder.Entity<Rate>()
                        .Property(p => p.DiffPercent)
                        .HasComputedColumnSql("([OtherToPrice]/[OurBestPrice])-1");

            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public virtual DbSet<FileData> FileDatas { get; set; }

    }
}
