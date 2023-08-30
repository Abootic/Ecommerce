
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Target.Application.DTOs;

namespace Target.Application.Interfaces.Common
{
    public interface ISigninManager
    {
        public Task<IResult<UserDto>> PasswordSiginAsync(string username, string password, bool isPerisistent, bool LockOutoNFauilar);
        public  Task<IResult<UserDto>> PasswordSiginByEmailAsync(string username, string password, bool isPerisistent, bool LockOutoNFauilar);
    }
}
