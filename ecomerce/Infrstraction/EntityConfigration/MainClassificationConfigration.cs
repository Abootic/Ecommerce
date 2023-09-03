using EcommereceWeb.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Infrstraction.EntityConfigration
{
    public class MainClassificationConfigration : IEntityTypeConfiguration<MainClassification>
    {
        public void Configure(EntityTypeBuilder<MainClassification> builder)
        {
            builder.ToTable("MainClassification", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_MainClassification").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
                    builder.Property(x => x.MainClassificationName).HasColumnName(@"MainClassificationName").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
                    builder.Property(x => x.ImageUrl).HasColumnName(@"ImageUrl").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);


        }
    }
}
