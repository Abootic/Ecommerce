
using Application.Interfaces.Common;
using EcommereceWeb.Domain.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Target.Application.Interfaces.Common;

using Target.Infrastraction.EntityConfigration;
using Target.Infrastraction.Identity;
using Target.infrstraction.Extensions;

namespace Target.Infrastraction.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
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

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.ApplayGlobalFilter<ISoftDelete>(e => e.IsDeleted == false);

        //    modelBuilder.ApplyConfiguration(new AboutSectionConfiguration());
        //    modelBuilder.ApplyConfiguration(new AboutSectionItemConfiguration());
        //    modelBuilder.ApplyConfiguration(new AdsConfigration());
        //    modelBuilder.ApplyConfiguration(new AvailableAreaConfiguration());
        //    modelBuilder.ApplyConfiguration(new ContactConfigration());
        
        //    modelBuilder.ApplyConfiguration(new ExhConfigConfigration());
        //    modelBuilder.ApplyConfiguration(new ExhibitionConfigration());
        //    modelBuilder.ApplyConfiguration(new ExhSectionConfiguration());
        //    modelBuilder.ApplyConfiguration(new ExhSectionItemConfigration());
        //    modelBuilder.ApplyConfiguration(new EXhSocialMediaConfigration());
        //    modelBuilder.ApplyConfiguration(new NewsConfigration());
        //    modelBuilder.ApplyConfiguration(new ReservedAreaConfigration());
        //    modelBuilder.ApplyConfiguration(new SlideConfigration());
        //    modelBuilder.ApplyConfiguration(new SocialMediaConfigration());
        //    modelBuilder.ApplyConfiguration(new SponsorConfigration());
        //    modelBuilder.ApplyConfiguration(new SponsorProductsConfigration());
        //   // modelBuilder.ApplyConfiguration(new UserConfigration());
        //    modelBuilder.ApplyConfiguration(new VisitConfigration());
        //    modelBuilder.ApplyConfiguration(new SponsorTypeConfigration());
        //    modelBuilder.ApplyConfiguration(new ExhUserConfigration());
        //    modelBuilder.ApplyConfiguration(new ExhSlideConfigration());

        //    //============= for sitex conferenc =================
        //    modelBuilder.ApplyConfiguration(new AxlesConfigration());
        //    modelBuilder.ApplyConfiguration(new ConferenceConfigration());
        //    modelBuilder.ApplyConfiguration(new ExhDataConfigration());
        //    modelBuilder.ApplyConfiguration(new RequestConfigration());
        //    modelBuilder.ApplyConfiguration(new WorksheetConfigration());
        //   // modelBuilder.ApplyConfiguration(new SponsorTypeFeaturesConfigration());
        //    OnModelCreatingPartial(modelBuilder);
           


        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
      
    }
