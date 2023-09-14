using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Application.Interfaces.Services;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Services
{
    public class ProductVariationService : IProductVariationService
    {
        public Task<IResult<ProductVariationDto>> Add(ProductVariationDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IEnumerable<ProductVariationDto>>> Find(Expression<Func<ProductVariationDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IEnumerable<ProductVariationDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<ProductVariationDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<ProductVariationDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<ProductVariationDto>> Update(ProductVariationDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }

}
