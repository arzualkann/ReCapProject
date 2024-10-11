using Business.Abstract;
using Business.Requests.Cars;
using Business.Requests.Customers;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public async Task<IActionResult> AddAsync(CreateCustomerRequest request)
        {
            return Ok(await _customerService.AddAsync(request));
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _customerService.GetAllAsync());
        }

        [HttpPost("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _customerService.GetAllAsync());
        }
        [HttpDelete("DeleteAsync")]
        public async Task<IActionResult> DeleteAsync(DeleteCustomerRequest request)
        {
            return Ok(await _customerService.DeleteAsync(request));
        }

        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync(UpdateCustomerRequest request)
        {
            return Ok(await _customerService.UpdateAsync(request));
        }

    }
}
