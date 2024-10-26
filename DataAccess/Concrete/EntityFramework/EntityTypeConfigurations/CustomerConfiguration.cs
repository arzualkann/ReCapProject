using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.EntityTypeConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(a => a.CompanyName).HasColumnName("CompanyName");

            builder.HasMany(x => x.Rentals).WithOne(r=>r.Customer);
        }
    }

}

