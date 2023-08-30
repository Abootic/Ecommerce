using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Target.Application.DTOs;

namespace Target.Application.Interfaces.Common
{
    public interface ICustomMapper
    {

        
        //======= Adding for sitex conference ======================= 13/11/2022 =====================================


        //====== AxlesDto ====================
        public AxlesViewDto DtoToView(AxlesDto dto, string lang = "ar-YE");
        public IEnumerable<AxlesViewDto> DtoToView(IEnumerable<AxlesDto> dtoList, string lang = "ar-YE");


        //====== ExhDataDto ====================
        public ExhDataViewDto DtoToView(ExhDataDto dto, string lang = "ar-YE");
        public IEnumerable<ExhDataViewDto> DtoToView(IEnumerable<ExhDataDto> dtoList, string lang = "ar-YE");


        //====== ConferenceDto ====================
        public ConferenceViewDto DtoToView(ConferenceDto dto, string lang = "ar-YE");
        public IEnumerable<ConferenceViewDto> DtoToView(IEnumerable<ConferenceDto> dtoList, string lang = "ar-YE");

        //====== RequestDto ====================
        public RequestViewDto DtoToView(RequestDto dto, string lang = "ar-YE");
        public IEnumerable<RequestViewDto> DtoToView(IEnumerable<RequestDto> dtoList, string lang = "ar-YE");

        //====== WorksheetsDto ====================
        public WorksheetsViewDto DtoToView(WorksheetsDto dto, string lang = "ar-YE");
        public IEnumerable<WorksheetsViewDto> DtoToView(IEnumerable<WorksheetsDto> dtoList, string lang = "ar-YE");


        //====== SponsorTypeFeaturesDto ====================
        public SponsorTypeFeaturesViewDto DtoToView(SponsorTypeFeaturesDto dto, string lang = "ar-YE");
        public IEnumerable<SponsorTypeFeaturesViewDto> DtoToView(IEnumerable<SponsorTypeFeaturesDto> dtoList, string lang = "ar-YE");

        //----------------------------------------------------------------------------------------------------------------
        //====== AdsDto ====================
        public AdsViewDto DtoToView(AdsDto dto, string lang = "ar-YE");
        public IEnumerable<AdsViewDto> DtoToView(IEnumerable<AdsDto> dtoList, string lang = "ar-YE");

        //====== AboutSectionDto ====================
        public AboutSectionViewDto DtoToView(AboutSectionDto dto, string lang = "ar-YE");
        public IEnumerable<AboutSectionViewDto> DtoToView(IEnumerable<AboutSectionDto> dtoList, string lang = "ar-YE");

        //====== AboutSectionItemDto ====================
        public AboutSectionItemViewDto DtoToView(AboutSectionItemDto dto, string lang = "ar-YE");
        public IEnumerable<AboutSectionItemViewDto> DtoToView(IEnumerable<AboutSectionItemDto> dtoList, string lang = "ar-YE");

        //====== AvailableAreaDto ====================
        public AvailableAreaViewDto DtoToView(AvailableAreaDto dto, string lang = "ar-YE");
        public IEnumerable<AvailableAreaViewDto> DtoToView(IEnumerable<AvailableAreaDto> dtoList, string lang = "ar-YE");

        //====== ExhConfigDto ====================
        public ExhConfigViewDto DtoToView(ExhConfigDto dto, string lang = "ar-YE");
        public IEnumerable<ExhConfigViewDto> DtoToView(IEnumerable<ExhConfigDto> dtoList, string lang = "ar-YE");

        //====== ExhibitionDto ====================
        public ExhibitionViewDto DtoToView(ExhibitionDto dto, string lang = "ar-YE");
        public IEnumerable<ExhibitionViewDto> DtoToView(IEnumerable<ExhibitionDto> dtoList, string lang = "ar-YE");

        //====== ExhibitionDto ====================
        public ExhSectionViewDto DtoToView(ExhSectionDto dto, string lang = "ar-YE");
        public IEnumerable<ExhSectionViewDto> DtoToView(IEnumerable<ExhSectionDto> dtoList, string lang = "ar-YE");

        //====== ExhSectionItemDto ====================
        public ExhSectionItemViewDto DtoToView(ExhSectionItemDto dto, string lang = "ar-YE");
        public IEnumerable<ExhSectionItemViewDto> DtoToView(IEnumerable<ExhSectionItemDto> dtoList, string lang = "ar-YE");

        //====== ExhSocialMediaDto ====================
        public ExhSocialMediaViewDto DtoToView(ExhSocialMediaDto dto, string lang = "ar-YE");
        public IEnumerable<ExhSocialMediaViewDto> DtoToView(IEnumerable<ExhSocialMediaDto> dtoList, string lang = "ar-YE");

        //====== NewsDto ====================
        public NewsViewDto DtoToView(NewsDto dto, string lang = "ar-YE");
        public IEnumerable<NewsViewDto> DtoToView(IEnumerable<NewsDto> dtoList, string lang = "ar-YE");

        //====== ReservedAreaDto ====================
        public ReservedAreaViewDto DtoToView(ReservedAreaDto dto, string lang = "ar-YE");
        public IEnumerable<ReservedAreaViewDto> DtoToView(IEnumerable<ReservedAreaDto> dtoList, string lang = "ar-YE");

        //====== SlideDto ====================
        public SlideViewDto DtoToView(SlideDto dto, string lang = "ar-YE");
        public IEnumerable<SlideViewDto> DtoToView(IEnumerable<SlideDto> dtoList, string lang = "ar-YE");

        //====== SocialMediaDto ====================
        public SocialMediaViewDto DtoToView(SocialMediaDto dto, string lang = "ar-YE");
        public IEnumerable<SocialMediaViewDto> DtoToView(IEnumerable<SocialMediaDto> dtoList, string lang = "ar-YE");

        //====== SponsorTypeDto ====================
        public SponsorTypeViewDto DtoToView(SponsorTypeDto dto, string lang = "ar-YE");
        public IEnumerable<SponsorTypeViewDto> DtoToView(IEnumerable<SponsorTypeDto> dtoList, string lang = "ar-YE");

        //====== SponsorDto ====================
        public SponsorViewDto DtoToView(SponsorDto dto, string lang = "ar-YE");
        public IEnumerable<SponsorViewDto> DtoToView(IEnumerable<SponsorDto> dtoList, string lang = "ar-YE");

        //====== SponsorProductDto ====================
        public SponsorProductViewDto DtoToView(SponsorProductDto dto, string lang = "ar-YE");
        public IEnumerable<SponsorProductViewDto> DtoToView(IEnumerable<SponsorProductDto> dtoList, string lang = "ar-YE");

        //====== VisitDto ====================
        public VisitViewDto DtoToView(VisitDto dto, string lang = "ar-YE");
        public IEnumerable<VisitViewDto> DtoToView(IEnumerable<VisitDto> dtoList, string lang = "ar-YE");       
    }
}
