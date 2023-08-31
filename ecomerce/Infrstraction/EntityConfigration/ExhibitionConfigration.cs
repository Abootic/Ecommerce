using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Target.Domain.Entity;

namespace Target.Infrastraction.EntityConfigration
{
    public class ExhibitionConfigration : IEntityTypeConfiguration<Exhibition>
    {
        public void Configure(EntityTypeBuilder<Exhibition> builder)    
        {
          
            builder.ToTable("Exhibitions", "dbo");
            builder.HasKey(x => x.Id).HasName("Pk_Exhibitions").IsClustered();
           
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x=>x.ArName).HasColumnName(@"ArName").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x=>x.EnName).HasColumnName(@"EnName").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x=>x.Location).HasColumnName(@"Location").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x=>x.Link).HasColumnName(@"Link").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(1024);
            builder.Property(x=>x.Logo).HasColumnName(@"Logo").HasColumnType("nvarchar(255)").IsRequired().HasMaxLength(255);
            builder.Property(x=>x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime2").IsRequired();
            builder.Property(x=>x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime2").IsRequired();
            builder.Property(x => x.ArIntroduction).HasColumnName(@"ArIntroduction").HasColumnType("nvarchar(MAX)").IsRequired();
            builder.Property(x => x.EnIntroduction).HasColumnName(@"EnIntroduction").HasColumnType("nvarchar(MAX)").IsRequired();
            builder.Property(x=>x.Version).HasColumnName(@"Version").HasColumnType("int").IsRequired(false);
            builder.Property(x=>x.PreviousId).HasColumnName(@"PreviousId").HasColumnType("int").IsRequired(false);

            builder.Property(x => x.State).HasColumnName(@"State").HasColumnType("int").IsRequired().HasDefaultValue(1);
            builder.HasIndex(e => e.PreviousId, "IX_Exhibitions_PreviousId")
                 .IsUnique()
                 .HasFilter("([PreviousId] IS NOT NULL)");
            /*builder.HasOne(d => d.Previous)
                  .WithOne(p => p.InversePrevious)
                  .HasForeignKey<Exhibition>(d => d.PreviousId)
                  .HasConstraintName("FK_Exhibition_Exhibition1");*/
          




        }
    }
}
