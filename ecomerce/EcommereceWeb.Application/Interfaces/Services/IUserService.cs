using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using System.Security.Claims;

namespace EcommereceWeb.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<IResult<UserDto>> AddAsync(UserDto entity, CancellationToken cancellationToken = default);
        Task<IResult<UserDto>> FindByIdAsync(string id, CancellationToken cancellationToken = default);
        Task<IResult<UserDto>> GetByClaims(ClaimsPrincipal claims);
        Task<IResult<IEnumerable<UserDto>>> GetAll();
    }
}
