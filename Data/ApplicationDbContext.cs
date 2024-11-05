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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Sale> Sales { get; set; }

    }
}
