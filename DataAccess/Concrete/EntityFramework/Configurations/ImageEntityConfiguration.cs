using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class ImageEntityConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasKey(i => i.ImageId);

            builder.Property(i => i.ImageId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.HasIndex(i => new { i.TenderId});

            builder.Property(i => i.TenderId).IsRequired();

            builder.Property(i => i.ImagePath)
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}
