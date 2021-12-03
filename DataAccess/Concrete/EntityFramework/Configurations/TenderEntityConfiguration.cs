using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class TenderEntityConfiguration : IEntityTypeConfiguration<Tender>
    {
        public void Configure(EntityTypeBuilder<Tender> builder)
        {
            builder.HasKey(t => t.TenderId);

            builder.Property(t => t.TenderId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.HasIndex(t => new { t.AdminId, t.ClientId, t.CategoryId});

            builder.Property(t => t.AdminId).IsRequired();

            builder.Property(t => t.ClientId).IsRequired();

            builder.Property(t => t.CategoryId).IsRequired();

            builder.Property(t => t.Price).IsRequired();

            builder.Property(t => t.StartingDate).IsRequired();

            builder.Property(t => t.EndDate).IsRequired();

            builder.Property(t => t.Active).IsRequired();

            builder.Property(t => t.Job)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(t => t.Corparation)
                .HasMaxLength(255)
                .IsRequired();



        }
    }
}
