using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Target.Application.DTOs;
using Target.Domain.Entity;

namespace Target.Application.Constant
{
    public static class SeedData
    {
        public static ExhDataDto ExhInitData = new ExhDataDto
        {
            ArIntroduction = "",
            EnIntroduction = "",
            ArName = "",
            EnName = "",
            ArSubTitle = "",
            EnSubTitle = "",
            ArLocation = "",
            EnLocation = "",
            StartDate = DateTime.Now,
            EndDate = DateTime.Now,
            HeaderImage = "",
            Logo = "",
            OtherImage = ""
        };

        public static ConferenceDto ConferenceInitData = new ConferenceDto
        {
            ArIntroduction = "",
            EnIntroduction = "",
            ArName = "",
            EnName = "",
            ArSubTitle = "",
            EnSubTitle = "",
            ArLocation = "",
            EnLocation = "",
            StartDate = DateTime.Now,
            EndDate = DateTime.Now,            
            Logo = "",
        };

        public static List<AboutSectionDto> ConferenceInitSections = new List<AboutSectionDto>
       {
           new AboutSectionDto{Name="goals", ArTitle="", EnTitle="", ArSubTitle="", EnSubTitle="",IsInHome=true, ArIntroduction="", EnIntroduction="", Order=1, Image="", State=0 },                    
           new AboutSectionDto{Name="intro", ArTitle="", EnTitle="", ArSubTitle="", EnSubTitle="",IsInHome=true, ArIntroduction="", EnIntroduction="", Order=1, Image="", State=0 },                    
       };
        public static List<ExhSectionDto> ExhSections = new List<ExhSectionDto>
       {
           new ExhSectionDto{Name="goals", ArTitle="", EnTitle="", ArSubTitle="", EnSubTitle="",IsInHome=true,  ArIntroduction="", EnIntroduction="", Order=1, Image="", State=0 },
           new ExhSectionDto{Name="features", ArTitle="", EnTitle="", ArSubTitle="", EnSubTitle="",IsInHome=true,  ArIntroduction="", EnIntroduction="", Order=1, Image="", State=0 },
           new ExhSectionDto{Name="parts", ArTitle="", EnTitle="", ArSubTitle="", EnSubTitle="",IsInHome=true,  ArIntroduction="", EnIntroduction="", Order=1, Image="", State=0 },
           new ExhSectionDto{Name="about", ArTitle="", EnTitle="", ArSubTitle="", EnSubTitle="",IsInHome=true,  ArIntroduction="", EnIntroduction="", Order=1, Image="", State=0 },
           new ExhSectionDto{Name="intro", ArTitle="", EnTitle="", ArSubTitle="", EnSubTitle="",IsInHome=true,  ArIntroduction="", EnIntroduction="", Order=1, Image="", State=0 },
       };

        public enum AboutSectionsNames { Introduction, Goals, Mission, Vision,  }
        public enum ExhConfigNames { PrimaryColor=1, SecondaryColor=2, BgColor=3, TextColor=4 }
        public enum ExhSectionsNames { Introduction, Goals, Priorities, Importance,  }
        public enum SponsorTypeNames {Official, Main, Diamond, Golden, Silver, Participant  }
    }
}
