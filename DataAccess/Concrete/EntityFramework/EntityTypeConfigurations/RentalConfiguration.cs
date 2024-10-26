using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Features.Metadata;

namespace DataAccess.Concrete.EntityFramework.EntityTypeConfigurations
{
    public class RentalConfiguration : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.ToTable("Rentals").HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.CarId).HasColumnName("CarId").IsRequired();
            builder.Property(x => x.CustomerId).HasColumnName("CustomerId");
            builder.Property(x => x.RentalDate).HasColumnName("RentalDate");
            builder.Property(x => x.ReturnDate).HasColumnName("ReturnDate");
            builder.Property(x => x.CreatedDate).HasColumnName("CreatedDate");
            builder.Property(x => x.UpdatedDate).HasColumnName("UpdatedDate");
            builder.Property(x => x.DeletedDate).HasColumnName("DeletedDate");

            builder.HasOne(x => x.Car).WithMany(c => c.Rentals);
            builder.HasOne(x => x.Customer).WithMany(c => c.Rentals);
        }

    }
}
