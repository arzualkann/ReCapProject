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
    public class CarConfiguration:IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars").HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.BrandId).HasColumnName("BrandId");
            builder.Property(x => x.ColorId).HasColumnName("ColorId");
            builder.Property(x => x.ModelYear).HasColumnName("ModelYear");
            builder.Property(x => x.DailyPrice).HasColumnName("DailyPrice");
            builder.Property(x => x.Description).HasColumnName("Description");
            builder.Property(x => x.DailyPrice).HasColumnName("DailyPrice");

            builder.HasMany(x=>x.CarImages);
            builder.HasMany(x => x.Rentals);
        }
    }
}
