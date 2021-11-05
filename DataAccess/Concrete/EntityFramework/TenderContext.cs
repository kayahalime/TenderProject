using System;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework.Configurations;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class TenderContext: DbContext
    {

       
        public DbSet<Admin> admins { get; set; }
        public DbSet<Bid> bids { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Image> images { get; set; }
        public DbSet<Tender> tenders { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=1234;Server=localhost;Port=5432;Database=TenderProjectDb;Integrated Security=true;Pooling=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AdminEntityConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BidEntityConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryEntityConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ClientEntityConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ImageEntityConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TenderEntityConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserEntityConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OperationClaimEntityConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserOperationClaimEntityConfiguration).Assembly);
        }

    }
}
