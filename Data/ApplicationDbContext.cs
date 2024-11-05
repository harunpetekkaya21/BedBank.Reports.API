using BedBankReports.API.Extensions;
using BedBankReports.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BedBankReports.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public ApplicationDbContext()
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            modelBuilder.Entity<Rate>().Property(x=>x.DiffEuro).HasComputedColumnSql("[OtherToPrice]-[OurBestPrice]", true);
            modelBuilder.Entity<Rate>().Property(x=>x.DiffPercent).HasComputedColumnSql("([OtherToPrice]/[OurBestPrice])-1", true);


            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<FileData> FileDatas { get; set; }

    }
}
