using Application.Interfaces.Repositories;
using EcommereceWeb.Domain.Entity;
using infrstraction.Repositories;

using Target.Infrastraction.Data;

namespace Infrstraction.Repositories
{
    public class AddProductToFavoriteRepository : GenirecRopoistories<AddProductToFavorite>, IAddProductToFavoriteRepository
    {
        public AddProductToFavoriteRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
