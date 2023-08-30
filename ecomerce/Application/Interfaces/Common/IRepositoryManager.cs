using Sitex.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Target.Application.Interfaces.Common;
using Target.Application.Interfaces.Repositories;

namespace Target.Application.Interfaces.Common
{
    public interface IRepositoryManager
    {
        IAboutSectionRepository AboutSectionRepository { get; }
        IAboutSectionItemRepository AboutSectionItemRepository { get; }
        IAdsRepository AdsRepository { get; }
        IAvailableAreaRepository AvailableAreaRepository { get; }
        IAxlesRepository AxlesRepository { get; }
        IConferenceRepository ConferenceRepository { get; }
        IContactRepository ContactRepository { get; }
        IExhDataRepository ExhDataRepository { get; }
        IExhibitionRepository ExhibitionRepository { get; }
        IExhSectionRepository ExhSectionRepository { get; }
        IExhSectionItemRepository ExhSectionItemRepository { get; } 
        IExhSocialMediaRepository ExhSocialMediaRepository { get; }
        IExhConfigRepository ExhConfigRepository { get; }
        INewsRepository NewsRepository { get; }
        IRequestRepository RequestRepository { get; }
        IReservedAreaRepository ReservedAreaRepository { get; }
        ISlideRepository SlideRepository { get; }
        ISocialMediaRepository SocialMediaRepository { get; }   
        ISponsorRepository SponsorRepository { get; }
        ISponsorProductsRepository SponsorProductsRepository { get; }
        IVisitRepository VisitRepository { get; }
        IUnitOfWork UnitOfWork { get; }
        IContactUsRepository ContactUsRepository { get; }
        ISponsorTypeRepository SponsorTypeRepository { get; }
        ISponsorTypeFeaturesRepository SponsorTypeFeaturesRepository { get; }
        IExhSlideRepository ExhSlideRepository { get; }
        IWorksheetsRepository WorksheetsRepository { get; }
        IGalleryRepository GalleryRepository { get; }
        IOnlineLinkRepository OnlineLinkRepository { get; }

    }
}
