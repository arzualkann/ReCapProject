﻿using Core.Utilities.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concretes.EntityFramework.EntityTypeConfigurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users").HasKey(t => t.Id);
        builder.Property(x => x.Id).HasColumnName("Id");
        builder.Property(x => x.Username).HasColumnName("Username");
        builder.Property(x => x.FirstName).HasColumnName("FirstName");
        builder.Property(x => x.LastName).HasColumnName("LastName");
        builder.Property(x => x.DateOfBirth).HasColumnName("DateOfBirth");
        builder.Property(x => x.NationalIdentity).HasColumnName("NationalIdentity");
        builder.Property(x => x.Email).HasColumnName("Email");
        builder.Property(x => x.PasswordHash).HasColumnName("PasswordHash");
        builder.Property(x => x.PasswordSalt).HasColumnName("PasswordSalt");
        builder.Property(x => x.CreatedDate).HasColumnName("CreatedDate").IsRequired(false);
        builder.Property(x => x.UpdatedDate).HasColumnName("UpdatedDate").IsRequired(false);
        builder.Property(x => x.DeletedDate).HasColumnName("DeletedDate").IsRequired(false);

        builder.HasMany(t => t.UserOperationClaims);

    }
}

