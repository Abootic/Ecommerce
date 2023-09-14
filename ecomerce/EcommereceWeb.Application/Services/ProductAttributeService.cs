using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Application.Interfaces.Services;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Services
{
    public class ProductAttributeService : IProductAttributeService
    {
        public Task<IResult<ProductAttributeDto>> Add(ProductAttributeDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IEnumerable<ProductAttributeDto>>> Find(Expression<Func<ProductAttributeDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IEnumerable<ProductAttributeDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<ProductAttributeDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<ProductAttributeDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<ProductAttributeDto>> Update(ProductAttributeDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }

}
