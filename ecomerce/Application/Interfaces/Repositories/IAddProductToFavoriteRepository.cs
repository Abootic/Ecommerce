using Application.Common;
using EcommereceWeb.Domain.Entity;

using Target.Application.Interfaces.Common;

namespace Application.Interfaces.Repositories
{
    public interface IAddProductToFavoriteRepository : IGenericRepository<AddProductToFavorite>
    {
        Task<IEnumerable<DataListItem>> GetDDL();
    }
}
