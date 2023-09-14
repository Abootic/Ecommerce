using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Application.Interfaces.Services;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Services
{
    public class AttributeService : IAttributeService
    {
        public Task<IResult<AttributeDto>> Add(AttributeDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IEnumerable<AttributeDto>>> Find(Expression<Func<AttributeDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<IEnumerable<AttributeDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<AttributeDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<AttributeDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<AttributeDto>> Update(AttributeDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }

}
