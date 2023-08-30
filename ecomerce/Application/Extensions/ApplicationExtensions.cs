
using Microsoft.Extensions.DependencyInjection;
using Target.Application.Interfaces.Common;
using Target.Application.Interfaces.Services;
using Target.Application.Services;
using AutoMapper.Extensions.ExpressionMapping;
using Sitex.Application.Interfaces.Services;
using Sitex.Application.Services;

namespace Target.Application.Extensions
{
    public static class ApplicationExtensions
    {
      public  static IServiceCollection ApplicationServices(this IServiceCollection services)
        {
           /* Console.WriteLine("---------- in get assemplies ----------");
            foreach(var asemply in AppDomain.CurrentDomain.GetAssemblies().ToList())
            {
                Console.WriteLine($"Asemply Name: {asemply.FullName}");
            }*/
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddAutoMapper(ex => { ex.AddExpressionMapping(); }, AppDomain.CurrentDomain.Load("Sitex.Application"));
            services.AddTransient<ICustomMapper, CustomeMapper>();

            services.AddScoped<IVisitServices, VisitServices>();
            services.AddScoped<ISponsorTypeServices, SponsorTypeServices>();
            services.AddScoped<IAdsServices, AdsServices>();
            services.AddScoped<IContactServices, ContactServices>();
            services.AddScoped<IExhibitionServices, ExhibitionServices>();
            services.AddScoped<IAvailableAreaServices, AvailableAreaServices>();
            services.AddScoped<IExhConfigServices, ExhConfigServices>();
            services.AddScoped<IExhSectionItemServices, ExhSectionItemServices>();
            services.AddScoped<IExhSectionServices, ExhSectionServices>();
            services.AddScoped<IExhSocialMediaServices, ExhSocialMediaServices>();
            services.AddScoped<INewsServices, NewsServices>();
            services.AddScoped<IReservedAreaServices, ReservedAreaServices>();
            services.AddScoped<ISlideServices, SlideServices>();
            services.AddScoped<ISocialMediaServices, SocialMediaServices>();
            services.AddScoped<ISponsorProductsServices, SponsorProductsServices>();
            services.AddScoped<ISponsorServices, SponsorServices>();
            services.AddScoped<IAboutSectionItemServices, AboutSectionItemServices>();
            services.AddScoped<IAboutSectionServices, AboutSectionServices>();
            services.AddScoped<IExhSlideServices, ExhSlideServices>();

            // ================ for sitex conference ================
            services.AddScoped<IWorksheetsServices, WorksheetsServices>();
            services.AddScoped<IAxlesServices, AxlesServices>();
            services.AddScoped<IConferenceServices, ConferenceServices>();
            services.AddScoped<IRequestServices, RequestServices>();
            services.AddScoped<IExhDataServices, ExhDataServices>();
            services.AddScoped<ISponsorTypeFeaturesServices, SponsorTypeFeaturesServices>();
            services.AddScoped<IGalleryServices, GalleryServices>();
            services.AddScoped<IOnlineLinkServices, OnlineLinkServices>();



            services.AddScoped(provider => new Lazy<IVisitServices>(provider.GetService<IVisitServices>()));
            services.AddScoped(provider => new Lazy<IAdsServices>(provider.GetService<IAdsServices>()));
            services.AddScoped(provider => new Lazy<IContactServices>(provider.GetService<IContactServices>()));
            services.AddScoped(provider => new Lazy<IExhibitionServices>(provider.GetService<IExhibitionServices>()));
            services.AddScoped(provider => new Lazy<IAvailableAreaServices>(provider.GetService<IAvailableAreaServices>()));
            services.AddScoped(provider => new Lazy<IExhConfigServices>(provider.GetService<IExhConfigServices>()));
            services.AddScoped(provider => new Lazy<IExhSectionItemServices>(provider.GetService<IExhSectionItemServices>()));
            services.AddScoped(provider => new Lazy<IExhSectionServices>(provider.GetService<IExhSectionServices>()));
  
            services.AddScoped(provider => new Lazy<INewsServices>(provider.GetService<INewsServices>()));
            services.AddScoped(provider => new Lazy<IReservedAreaServices>(provider.GetService<IReservedAreaServices>()));
            services.AddScoped(provider => new Lazy<ISlideServices>(provider.GetService<ISlideServices>()));
            services.AddScoped(provider => new Lazy<ISocialMediaServices>(provider.GetService<ISocialMediaServices>()));
            services.AddScoped(provider => new Lazy<ISponsorProductsServices>(provider.GetService<ISponsorProductsServices>()));
            services.AddScoped(provider => new Lazy<ISponsorServices>(provider.GetService<ISponsorServices>()));
            services.AddScoped(provider => new Lazy<IUserServices>(provider.GetService<IUserServices>()));
            services.AddScoped(provider => new Lazy<IUplaodFileService>(provider.GetService<IUplaodFileService>()));
            services.AddScoped(provider => new Lazy<IAboutSectionItemServices>(provider.GetService<IAboutSectionItemServices>()));
            services.AddScoped(provider => new Lazy<IAboutSectionServices>(provider.GetService<IAboutSectionServices>()));
            services.AddScoped(provider => new Lazy<IExhSocialMediaServices>(provider.GetService<IExhSocialMediaServices>()));
            services.AddScoped(provider => new Lazy<ISponsorTypeServices>(provider.GetService<ISponsorTypeServices>()));
            services.AddScoped(provider => new Lazy<IExhSlideServices>(provider.GetService<IExhSlideServices>()));


            //============= for sitex ===================
            services.AddScoped(provider => new Lazy<IConferenceServices>(provider.GetService<IConferenceServices>()));
            services.AddScoped(provider => new Lazy<IAxlesServices>(provider.GetService<IAxlesServices>()));
            services.AddScoped(provider => new Lazy<IWorksheetsServices>(provider.GetService<IWorksheetsServices>()));
            services.AddScoped(provider => new Lazy<IRequestServices>(provider.GetService<IRequestServices>()));
            services.AddScoped(provider => new Lazy<IExhDataServices>(provider.GetService<IExhDataServices>()));
            services.AddScoped(provider => new Lazy<ISponsorTypeFeaturesServices>(provider.GetService<ISponsorTypeFeaturesServices>()));
            services.AddScoped(provider => new Lazy<IGalleryServices>(provider.GetService<IGalleryServices>()));
            services.AddScoped(provider => new Lazy<IOnlineLinkServices>(provider.GetService<IOnlineLinkServices>()));
            return services;
        }
    }
}
