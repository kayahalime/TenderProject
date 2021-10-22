using System;
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class UserOperationClaimEntityConfiguration : IEntityTypeConfiguration<UserOperationClaim>
    {
        public void Configure(EntityTypeBuilder<UserOperationClaim> builder)
        {
            builder.HasKey(u => u.UserId);

            builder.Property(u => u.UserId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.HasIndex(u => new { u.OperationClaimId, u.UserOperationClaimId });

            builder.Property(u => u.OperationClaimId).IsRequired();

            builder.Property(u => u.UserOperationClaimId).IsRequired();
        }
    }
}
