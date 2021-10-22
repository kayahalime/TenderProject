using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class BidEntityConfiguration : IEntityTypeConfiguration<Bid>
    {
        public void Configure(EntityTypeBuilder<Bid> builder)
        {
            builder.HasKey(b => b.BidId);

            builder.Property(b => b.BidId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.HasIndex(b => new { b.ClientId, b.TenderId });

            builder.Property(b => b.ClientId).IsRequired();

            builder.Property(b => b.TenderId).IsRequired();

            builder.Property(b => b.Price).IsRequired();

        }
    }
}