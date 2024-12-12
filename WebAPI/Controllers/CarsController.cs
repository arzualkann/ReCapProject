using Business.Abstract;
using Business.Requests.Brands;
using Business.Requests.Cars;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : BaseController
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync(CreateCarRequest request)
        {
            return Ok(await _carService.AddAsync(request));
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _carService.GetAllAsync());
        }

        [HttpPost("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _carService.GetAllAsync());
        }
        [HttpDelete("DeleteAsync")]
        public async Task<IActionResult> DeleteAsync(DeleteCarRequest request)
        {
            return Ok(await _carService.DeleteAsync(request));
        }

        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync(UpdateCarRequest request)
        {
            return Ok(await _carService.UpdateAsync(request));
        }
    }
}
