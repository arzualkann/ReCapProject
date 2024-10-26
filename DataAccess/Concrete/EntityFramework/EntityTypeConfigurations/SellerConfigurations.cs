using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.EntityTypeConfigurations
{
    public class SellerConfigurations : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.ToTable("Sellers").HasKey(b => b.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(s => s.CompanyName).HasColumnName("CompanyName").IsRequired().HasMaxLength(100);
            builder.Property(s => s.PhoneNumber).HasColumnName("PhoneNumber").HasMaxLength(15);
            builder.Property(s => s.Address).HasColumnName("Address").HasMaxLength(250);
            builder.Property(s => s.RegistrationDate).HasColumnName("RegistrationDate").IsRequired();
            builder.HasMany(s => s.Cars).WithOne(c => c.Seller);

        }
    }
}
