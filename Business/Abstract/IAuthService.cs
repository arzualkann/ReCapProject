using Core.Utilities.Results;
using Core.Utilities.Security.Dtos;
using Core.Utilities.Security.Entities;
using Core.Utilities.Security.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {
        Task<DataResult<AccessToken>> Login(UserForLoginDto userForLoginDto);
        Task<DataResult<AccessToken>> SellerRegister(SellerForRegisterDto sellerForRegisterDto);
        Task<DataResult<AccessToken>> CustomerRegister(CustomerForRegisterDto customerForRegisterDto);
        Task<DataResult<AccessToken>> CreateAccessToken(User user);
    }
}
