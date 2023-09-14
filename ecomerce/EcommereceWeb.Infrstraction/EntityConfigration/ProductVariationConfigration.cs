using EcommereceWeb.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommereceWeb.Infrstraction.EntityConfigration
{
    public class ProductVariationConfigration : IEntityTypeConfiguration<ProductVariation>
    {
        public void Configure(EntityTypeBuilder<ProductVariation> builder)
        {
            builder.ToTable("ProductVariation", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_ProductVariation").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.ColorName).HasColumnName(@"ColorName").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.SizeName).HasColumnName(@"SizeName").HasColumnType("nvarchar(255)").IsRequired(false).HasMaxLength(255);
            builder.Property(x => x.ColorId).HasColumnName(@"ColorId").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.SizeId).HasColumnName(@"SizeId").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Quntatiy).HasColumnName(@"Quntatiy").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Price).HasColumnName(@"Price").HasColumnType("decimal(10, 2)").IsRequired(false);
            builder.Property(x => x.ProductAttributeId).HasColumnName(@"ProductAttributeId").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.ProductId).HasColumnName(@"ProductId").HasColumnType("int").IsRequired(false);
            builder.HasOne(a => a.ProductAttribute).WithMany(b => b.ProductVariations).HasForeignKey(b => b.ProductAttributeId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProductAttributeId_ProductVariation");
            builder.HasOne(a => a.Product).WithMany(b => b.ProductVariations).HasForeignKey(b => b.ProductId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProductId_ProductVariation");


        }
    }

}
