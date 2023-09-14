using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Application.Interfaces.Services;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Services
{
    public class AttributeItemService : IAttributeItemService
    {
        public Task<IResult<AttributeItemDto>> Add(AttributeItemDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IEnumerable<AttributeItemDto>>> Find(Expression<Func<AttributeItemDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IEnumerable<AttributeItemDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<AttributeItemDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<AttributeItemDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<AttributeItemDto>> Update(AttributeItemDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }

}
