using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configurations
{
    public class EmloyeeConfiguration : IEntityTypeConfiguration<Employee>  //IEntityTypeConfiguration<>--modele qoyduqumuz Required ve basqa sertleri burada yaziriq (ayri yerde)
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(m => m.FullName).HasMaxLength(100).IsRequired(false);
            builder.Property(m => m.SoftDelete).IsRequired().HasDefaultValue(false);
            builder.Property(m => m.CreatedAt).IsRequired().HasDefaultValue(DateTime.UtcNow);
            builder.Property(m => m.Address).IsRequired().HasMaxLength(250);
            builder.Property(m => m.Address).IsRequired();

        }
    }
}
