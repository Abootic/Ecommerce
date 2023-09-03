
using Application.Interfaces.Common;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Domain.BaseEntity;
using EcommereceWeb.Domain.Entity;
using EcommereceWeb.infrstraction.Extensions;
using EcommereceWeb.Infrstraction.EntityConfigration;
using Infrstraction.EntityConfigration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace EcommereceWeb.Infrastraction.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<User>, IApplicationDbContext
    {
        private readonly ICurrentUserServices _currentUserServices;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, ICurrentUserServices currentUserServices):base(options)
        {
            _currentUserServices= currentUserServices;

        }

        public DbSet<AddProductToFavorite> AddProductToFavorite { get; private set; } = null!;

        public DbSet<BasicClassification> BasicClassification { get; private set; } = null!;

        public DbSet<Brand> Brand { get; private set; } = null!;

        public DbSet<Configuration> Configuration { get; private set; } = null!;

        public DbSet<Coupon> Coupon { get; private set; } = null!;

        public DbSet<CouponItem> CouponItem { get; private set; } = null!;

        public DbSet<Currency> Currency { get; private set; } = null!;

        public DbSet<DetailsData> DetailsData { get; private set; } = null!;

        public DbSet<MainClassification> MainClassification { get; private set; } = null!;

        public DbSet<MasterData> MasterData { get; private set; } = null!;

        public DbSet<Product> Product { get; private set; } = null!;

        public DbSet<ProductAdditionalDetails> ProductAdditionalDetails { get; private set; } = null!;

        public DbSet<ProductColors> ProductColors { get; private set; } = null!;

        public DbSet<ProductEvaluaton> ProductEvaluaton { get; private set; } = null!;

        public DbSet<ProductImage> ProductImage { get; private set; } = null!;

        public DbSet<ProductSize> ProductSize { get; private set; } = null!;

        public DbSet<ProductUnitSize> ProductUnitSize { get; private set; } = null!;

        public DbSet<Slider> Slider { get; private set; } = null!;

        public DbSet<SubClassificationBase> SubClassificationBase { get; private set; } = null!;

        public DbSet<SubSubclassification> SubSubclassification { get; private set; } = null!;

        public DbSet<TaxConfiguration> TaxConfiguration { get; private set; } = null!;
        public DbSet<User> Users { get; private set; } = null!;

        //public virtual Task<int> SaveChange(CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        public  async Task<int>  SaveChangeAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:

                        entry.Entity.CreatedBy = _currentUserServices.UserId ?? "1";
                        entry.Entity.CreatedAt = DateTime.UtcNow;
                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModfiedBy = _currentUserServices.UserId;
                        entry.Entity.LastModfiedAt = DateTime.UtcNow;

                        break;
                    case EntityState.Deleted:
                        entry.Entity.DeletedBy = _currentUserServices.UserId;
                        entry.Entity.DeletedAt = DateTime.UtcNow;
                        entry.Entity.IsDeleted = true;
                        break;
                }

            }
            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplayGlobalFilter<ISoftDelete>(e => e.IsDeleted == false);

            modelBuilder.ApplyConfiguration(new AddProductToFavoriteConfigration());
            modelBuilder.ApplyConfiguration(new BasicClassificationConfigration());
            modelBuilder.ApplyConfiguration(new BrandConfigration());
            modelBuilder.ApplyConfiguration(new ConfigurationConfigration());
            modelBuilder.ApplyConfiguration(new CouponConfigration());

            modelBuilder.ApplyConfiguration(new CouponItemConfigration());
            modelBuilder.ApplyConfiguration(new CurrencyConfigration());
            modelBuilder.ApplyConfiguration(new DetailsDataConfigration());
            modelBuilder.ApplyConfiguration(new MainClassificationConfigration());
            modelBuilder.ApplyConfiguration(new MasterDataConfigration());
            modelBuilder.ApplyConfiguration(new ProductAdditionalDetailsConfigration());
            modelBuilder.ApplyConfiguration(new ProductColorsConfigration());
            modelBuilder.ApplyConfiguration(new ProductConfigration());
            modelBuilder.ApplyConfiguration(new ProductImageConfigration());
            modelBuilder.ApplyConfiguration(new ProductSizeConfigration());
            modelBuilder.ApplyConfiguration(new ProductUnitSizeConfigration());
            // modelBuilder.ApplyConfiguration(new UserConfigration());
            modelBuilder.ApplyConfiguration(new SliderConfigration());
            modelBuilder.ApplyConfiguration(new SubClassificationBaseConfigration());
            modelBuilder.ApplyConfiguration(new SubSubclassificationConfigration());
            modelBuilder.ApplyConfiguration(new TaxConfigurationConfigration());
            modelBuilder.ApplyConfiguration(new ProductEvaluatonConfigration());

          
            OnModelCreatingPartial(modelBuilder);



        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
      
    }
