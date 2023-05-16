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
    public class CountryConfiguration : IEntityTypeConfiguration<Country>  //yalniz sertleri yazmaq ucun ayri yerde 
    {
        public void Configure(EntityTypeBuilder<Country> builder)  //yalniz sertleri yazmaq ucun ayri yerde 
        {
            builder.Property(m => m.Name).HasMaxLength(100).IsRequired(false);
            builder.Property(m => m.SoftDelete).IsRequired().HasDefaultValue(false);
            builder.Property(m => m.CreatedAt).IsRequired().HasDefaultValue(DateTime.UtcNow);
        }
    }
}
