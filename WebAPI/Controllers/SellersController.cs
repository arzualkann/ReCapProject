using Business.Abstract;
using Business.Requests.Brands;
using Business.Requests.Sellers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellersController : ControllerBase
    {
        private readonly ISellerService _sellerService;

        public SellersController(ISellerService sellerService)
        {
            _sellerService = sellerService;
        }

        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync(CreateSellerRequest request)
        {
            return Ok(await _sellerService.AddAsync(request));
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _sellerService.GetAllAsync());
        }

        [HttpPost("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _sellerService.GetAllAsync());
        }
        [HttpDelete("DeleteAsync")]
        public async Task<IActionResult> DeleteAsync(DeleteSellerRequest request)
        {
            return Ok(await _sellerService.DeleteAsync(request));
        }

        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync(UpdateSellerRequest request)
        {
            return Ok(await _sellerService.UpdateAsync(request));
        }
    }
}
