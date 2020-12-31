using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Infra.Data.Mappings
{
    public class DishMap : MapBase<Dish>
    {
        public override void Configure(EntityTypeBuilder<Dish> builder)
        {
            base.Configure(builder);
            builder.ToTable("Dish");
            builder.Property(c => c.Name).IsRequired().HasColumnName("Name").HasMaxLength(100);
            builder.Property(c => c.Price).IsRequired().HasColumnName("Price");
        }
    }
}
