using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.EntityTypeConfigurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars").HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.BrandId).HasColumnName("BrandId");
            builder.Property(x => x.ColorId).HasColumnName("ColorId");
            builder.Property(x => x.ModelYear).HasColumnName("ModelYear");
            builder.Property(x => x.DailyPrice).HasColumnName("DailyPrice").HasColumnType("decimal(18,6)");
            builder.Property(x => x.Description).HasColumnName("Description");
            builder.Property(x => x.DailyPrice).HasColumnName("DailyPrice");

            builder.HasMany(x => x.CarImages).WithOne(ci => ci.Car).HasForeignKey(ci => ci.CarId);
            builder.HasMany(x => x.Rentals).WithOne(r => r.Car).HasForeignKey(r => r.CarId);
            builder.HasOne(x => x.Seller).WithMany(s => s.Cars).HasForeignKey(x => x.SellerId); 
            builder.HasOne(x => x.Color).WithMany(c => c.Cars).HasForeignKey(x => x.ColorId);

        }
    }
}
