using Microsoft.EntityFrameworkCore;
using MyBank.Data.Mappings;
using MyBank.Models;

namespace MyBank.Data
{
    public class MyBankDataContext : DbContext
    {
        
        public DbSet<Client> Clients { get; set; }
        public DbSet<Deposits> Deposits { get; set; }
        public DbSet<Withdraws> Withdraws { get; set; }
        public DbSet<Transfers> Transfers { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=mybank; User ID=sa;Password=tZfyn18t;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientMap());
            modelBuilder.ApplyConfiguration(new DepositsMap());
            modelBuilder.ApplyConfiguration(new WithdrawsMap());
            modelBuilder.ApplyConfiguration(new TransfersMap());
        }

    }
}
