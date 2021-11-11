using SYSProject.Core.Entities.Concrete;
using SYSProject.Core.Utilities.Results;
using SYSProject.Core.Utilities.Security.Jwt;
using SYSProject.Entities.Concrete;
using SYSProject.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSProject.Business.Abstract
{
    public interface IAuthService
    {
        //IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);

        IDataResult<User> Login(UserForLoginDto userForLoginDto);

        IDataResult<AccessToken> CreateAccessToken(User user);

    }
}
