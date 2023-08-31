using Application.Interfaces.Repositories;
using EcommereceWeb.Domain.Entity;
using infrstraction.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Target.Infrastraction.Data;

namespace Infrstraction.Repositories
{
    public class SliderRepository : GenirecRopoistories<Slider>, ISliderRepository
    {
        public SliderRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
