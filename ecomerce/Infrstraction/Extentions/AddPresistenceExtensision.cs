

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Target.Infrastraction.Data;
using Target.Infrastraction.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

using Target.Application.Interfaces.Common;
using Target.Infrastraction.Repositories;

using Target.Application.Interfaces.Repositories;
using Target.Infrastraction.Services;
using Sitex.Application.Interfaces.Repositories;
using Sitex.Infrastructure.Repositories;

namespace Target.infrstraction.Extensions
{
    public static class AddPresistenceExtensision
    {

        public static IServiceCollection AddPresistence(this IServiceCollection service,IConfiguration configuration)
        {
            service.AddDbContext<ApplicationDbContext>(op =>

                op.UseSqlServer(configuration.GetConnectionString("SqlServerDB")));

            service.AddIdentity<ApplicationUser, IdentityRole>(bulder =>
            {
                bulder.User.RequireUniqueEmail = true;
                bulder.Password.RequireLowercase = true;
                bulder.Password.RequireDigit = false;
                bulder.Password.RequiredUniqueChars = 0;
                bulder.Password.RequireUppercase = true;
                bulder.Password.RequireNonAlphanumeric = false;
                bulder.Password.RequiredLength = 6;
            }).AddDefaultTokenProviders().AddEntityFrameworkStores<ApplicationDbContext>();

            /*service.AddIdentityCore<ApplicationUser>(bulder =>
            {
                bulder.User.RequireUniqueEmail = true;
                bulder.Password.RequireLowercase = true;
                bulder.Password.RequireDigit = false;
                bulder.Password.RequiredUniqueChars = 0;
                bulder.Password.RequireUppercase = true;
                bulder.Password.RequireNonAlphanumeric = false;
                bulder.Password.RequiredLength = 6;
            }).AddSignInManager().AddRoles<IdentityRole>().AddDefaultTokenProviders().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
*/

            service.AddScoped<ISponsorTypeRepository, SponsorTypeRepository>();
            service.AddScoped<IRepositoryManager, RepositoryManager>();
            service.AddTransient<IUnitOfWork, UnitOfWork>();
            service.AddTransient<IAboutSectionRepository, AboutsectionRepository>();
            service.AddTransient<IAboutSectionItemRepository, AboutsectionItemRepository>();
            service.AddTransient<IAdsRepository, AdsRepository>();
            service.AddTransient<IAvailableAreaRepository, AvailableAreaRepository>();
            service.AddTransient<IContactRepository, ContactRepository>();
            service.AddTransient<IExhibitionRepository, ExhibitionRepository>();
            service.AddTransient<IExhSectionRepository, ExhSectionRepository>();
            service.AddTransient<IExhSectionItemRepository, ExhSectionItemRepository>();

            service.AddTransient<IExhSocialMediaRepository, ExhSocialMediaRepository>();
            service.AddTransient<IExhConfigRepository, ExhConfigRepository>();
            service.AddTransient<INewsRepository, NewsRepository>();
            service.AddTransient<IReservedAreaRepository, ReservedAreaRepository>();
            service.AddTransient<ISlideRepository, SlideRepository>();
            service.AddScoped<ISocialMediaRepository, SocialMediaRepository>();
            service.AddTransient<ISponsorRepository, SponsorRepository>();
            service.AddTransient<ISponsorProductsRepository, SponsorProductsRepository>();

            service.AddTransient<IVisitRepository, VisitRepository>();
            service.AddTransient<IUplaodFileService, UplaodFileService>();
            service.AddTransient<IContactUsRepository, ContactUsRepository>();
            service.AddTransient<IExhSlideRepository, ExhSlideRepository>();

            // =============== for sitex conference ===============
            service.AddTransient<IAxlesRepository, AxlesRepository>();
            service.AddTransient<IConferenceRepository, ConferenceRepository>();
            service.AddTransient<IExhDataRepository, ExhDataRepository>();
            service.AddTransient<IRequestRepository, RequestRepository>();
            service.AddTransient<ISponsorTypeFeaturesRepository, SponsorTypeFeaturesRepository>();
            service.AddTransient<IWorksheetsRepository, WorksheetsRepository>();
            service.AddTransient<IGalleryRepository, GalleryRepository>();
            service.AddTransient<IOnlineLinkRepository, OnlineLinkRepository>();


            // inject services
            service.AddTransient(provider => new Lazy<IUnitOfWork>(provider.GetService<IUnitOfWork>()));   


            service.AddTransient(provider => new Lazy<IAboutSectionRepository>(provider.GetService<IAboutSectionRepository>()));   
            
            service.AddTransient(provider => new Lazy<IAboutSectionItemRepository>(provider.GetService<IAboutSectionItemRepository>()));   
            service.AddTransient(provider => new Lazy<IAdsRepository>(provider.GetService<IAdsRepository>()));   
            service.AddTransient(provider => new Lazy<IAvailableAreaRepository>(provider.GetService<IAvailableAreaRepository>()));   
            service.AddTransient(provider => new Lazy<IContactRepository>(provider.GetService<IContactRepository>()));   
            service.AddTransient(provider => new Lazy<IExhibitionRepository>(provider.GetService<IExhibitionRepository>()));   
            service.AddTransient(provider => new Lazy<IExhSectionRepository>(provider.GetService<IExhSectionRepository>()));   
            service.AddTransient(provider => new Lazy<IExhSectionItemRepository>(provider.GetService<IExhSectionItemRepository>()));

            service.AddTransient(provider => new Lazy<IExhSocialMediaRepository>(provider.GetService<IExhSocialMediaRepository>()));
            service.AddTransient(provider => new Lazy<IExhConfigRepository>(provider.GetService<IExhConfigRepository>()));
            service.AddTransient(provider => new Lazy<INewsRepository>(provider.GetService<INewsRepository>()));
            service.AddTransient(provider => new Lazy<IReservedAreaRepository>(provider.GetService<IReservedAreaRepository>()));
            service.AddTransient(provider => new Lazy<ISlideRepository>(provider.GetService<ISlideRepository>()));
            service.AddScoped(provider => new Lazy<ISocialMediaRepository>(provider.GetService<ISocialMediaRepository>()));
            service.AddTransient(provider => new Lazy<ISponsorRepository>(provider.GetService<ISponsorRepository>()));
            service.AddTransient(provider => new Lazy<ISponsorProductsRepository>(provider.GetService<ISponsorProductsRepository>()));

            service.AddTransient(provider => new Lazy<IVisitRepository>(provider.GetService<IVisitRepository>()));                
            service.AddTransient(provider => new Lazy<IContactUsRepository>(provider.GetService<IContactUsRepository>()));                
            service.AddTransient(provider => new Lazy<ISponsorTypeRepository>(provider.GetService<ISponsorTypeRepository>()));                
            service.AddTransient(provider => new Lazy<IExhSlideRepository>(provider.GetService<IExhSlideRepository>()));

            // ============ for sitex conference ==================
            service.AddTransient(provider => new Lazy<IAxlesRepository>(provider.GetService<IAxlesRepository>()));
            service.AddTransient(provider => new Lazy<IConferenceRepository>(provider.GetService<IConferenceRepository>()));
            service.AddTransient(provider => new Lazy<IExhDataRepository>(provider.GetService<IExhDataRepository>()));
            service.AddTransient(provider => new Lazy<IRequestRepository>(provider.GetService<IRequestRepository>()));
            service.AddTransient(provider => new Lazy<ISponsorTypeFeaturesRepository>(provider.GetService<ISponsorTypeFeaturesRepository>()));
            service.AddTransient(provider => new Lazy<IWorksheetsRepository>(provider.GetService<IWorksheetsRepository>()));
            service.AddTransient(provider => new Lazy<IGalleryRepository>(provider.GetService<IGalleryRepository>()));
            service.AddTransient(provider => new Lazy<IOnlineLinkRepository>(provider.GetService<IOnlineLinkRepository>()));


            return service;
            


        }
     
    }
}
