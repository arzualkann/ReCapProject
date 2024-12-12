using Business.Abstract;
using Business.Requests.Cars;
using Business.Requests.Colors;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : BaseController
    {
        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }
        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync(CreateColorRequest request)
        {
            return Ok(await _colorService.AddAsync(request));
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _colorService.GetAllAsync());
        }

        [HttpPost("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _colorService.GetAllAsync());
        }
        [HttpDelete("DeleteAsync")]
        public async Task<IActionResult> DeleteAsync(DeleteColorRequest request)
        {
            return Ok(await _colorService.DeleteAsync(request));
        }

        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync(UpdateColorRequest request)
        {
            return Ok(await _colorService.UpdateAsync(request));
        }
    }
}
