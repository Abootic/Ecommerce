using EcommereceWeb.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrstraction.EntityConfigration
{
    public class AddProductToFavoriteConfigration : IEntityTypeConfiguration<AddProductToFavorite>
    {
        public void Configure(EntityTypeBuilder<AddProductToFavorite> builder)
        {

            builder.ToTable("Exhibitions", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_Exhibitions").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
        }
    }
}
