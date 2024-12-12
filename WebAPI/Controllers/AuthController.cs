using Business.Abstract;
using Core.Utilities.Security.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : BaseController
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Customer Register")]
        public async Task<IActionResult> CustomerRegister(CustomerForRegisterDto customerForRegisterDto)
        {
            var result = await _authService.CustomerRegister(customerForRegisterDto);
            return HandleDataResult(result);
        }

        [HttpPost("Seller Register")]
        public async Task<IActionResult> SellerRegister(SellerForRegisterDto sellerForRegisterDto)
        {
            var result = await _authService.SellerRegister(sellerForRegisterDto);
            return HandleDataResult(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
        {
            var result = await _authService.Login(userForLoginDto);
            return HandleDataResult(result);
        }
    }
}
