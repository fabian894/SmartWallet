using Microsoft.EntityFrameworkCore;
using SmartWallet2.Web.Data.Entities;

namespace SmartWallet2.Web.Data.Configurations
{
    public static class CustomerConfiguration
    {
        public static ModelBuilder Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Property(c => c.FirstName).IsRequired(true).HasMaxLength(100).HasColumnName("first_name");
            modelBuilder.Entity<Customer>().Property(c => c.LastName).IsRequired(true).HasMaxLength(100);
            modelBuilder.Entity<Customer>().Property(c => c.PhoneNumber).HasMaxLength(50);
            modelBuilder.Entity<Customer>().Property(c => c.Email).HasMaxLength(256);

            modelBuilder.Entity<Customer>().HasIndex(c => c.PhoneNumber).IsUnique();
            modelBuilder.Entity<Customer>().HasIndex(c => c.Email).IsUnique();

            return modelBuilder;
        }
    }
}
