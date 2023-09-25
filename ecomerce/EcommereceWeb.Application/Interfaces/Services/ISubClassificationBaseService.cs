using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface ISubClassificationBaseService
    {
        Task<IResult<SubClassificationBaseDto>> Add(SubClassificationBaseDto entity, CancellationToken cancellationToken = default);
        Task<IResult<SubClassificationBaseDto>> Remove(int Id, CancellationToken cancellationToken = default);
        Task<IResult<SubClassificationBaseDto>> Update(SubClassificationBaseDto entity, CancellationToken cancellationToken = default);

        Task<IResult<IEnumerable<SubClassificationBaseDto>>> Find(Expression<Func<SubClassificationBaseDto, bool>> expression, CancellationToken cancellationToken = default);
        Task<IResult<IEnumerable<SubClassificationBaseDto>>> GetAll(CancellationToken cancellationToken = default);
        Task<IResult<SubClassificationBaseDto>> GetById(int Id, CancellationToken cancellationToken = default);
    }


}
