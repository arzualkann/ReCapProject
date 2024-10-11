using Business.Abstract;
using Business.Requests.Cars;
using Business.Requests.Rentals;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }
        public async Task<IActionResult> AddAsync(CreateRentalRequest request)
        {
            return Ok(await _rentalService.AddAsync(request));
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _rentalService.GetAllAsync());
        }

        [HttpPost("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _rentalService.GetAllAsync());
        }
        [HttpDelete("DeleteAsync")]
        public async Task<IActionResult> DeleteAsync(DeleteRentalRequest request)
        {
            return Ok(await _rentalService.DeleteAsync(request));
        }

        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync(UpdateRentalRequest request)
        {
            return Ok(await _rentalService.UpdateAsync(request));
        }

    }
}
