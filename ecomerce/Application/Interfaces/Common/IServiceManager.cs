
using Sitex.Application.Interfaces.Services;
using EcommereceWeb.Application.Interfaces.Services;

namespace EcommereceWeb.Application.Interfaces.Common
{
    public interface IServiceManager
    {
        IVisitServices visitServices { get; }
        IAdsServices AdsServices { get; }
        IExhibitionServices ExhibitionServices { get; }
        IAvailableAreaServices AvailableAreaServices { get; }
        IContactServices ContactServices { get; }
        IExhConfigServices ExhConfigServices { get; }
        IExhSectionItemServices ExhSectionItemServices { get; }
        IExhSectionServices ExhSectionServices { get; }
        IExhSocialMediaServices ExhSocialMediaServices { get; }
        INewsServices NewsServices { get; }
        IReservedAreaServices ReservedAreaServices { get; }
        ISlideServices SlideServices { get; }
        ISocialMediaServices SocialMediaServices { get; }
        ISponsorProductsServices SponsorProductsServices { get; }
        ISponsorServices SponsorServices { get; }
        IUserServices UserServices { get; }
        IUplaodFileService uplaodFileService { get; }
        IAboutSectionItemServices AboutSectionItemServices { get; }
        IAboutSectionServices AboutSectionServices { get; }
        ISponsorTypeServices SponsorTypeServices { get; }
        IExhSlideServices ExhSlideServices { get; }

        //=============== for sitex =================
        ISponsorTypeFeaturesServices SponsorTypeFeaturesServices { get; }
        IAxlesServices AxlesServices { get; }
        IWorksheetsServices WorksheetsServices { get; }
        IRequestServices RequestServices { get; }
        IExhDataServices ExhDataServices { get; }
        IConferenceServices ConferenceServices { get; }
        IGalleryServices GalleryServices { get; }
        IOnlineLinkServices OnlineLinkServices { get; }
    }
}