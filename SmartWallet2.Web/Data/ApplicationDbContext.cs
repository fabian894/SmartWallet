


using Microsoft.EntityFrameworkCore;
using SmartWallet2.Web.Data.Configurations;
using SmartWallet2.Web.Data.Entities;

namespace SmartWallet1.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CustomerConfiguration.Build(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
