using Business.Requests.Customers;
using Business.Responses.Customers;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        Task<IDataResult<CreateCustomerResponse>> AddAsync(CreateCustomerRequest request);
        Task<IDataResult<UpdateCustomerResponse>> UpdateAsync(UpdateCustomerRequest request);
        Task<IResult> DeleteAsync(DeleteCustomerRequest request);
        Task<IDataResult<List<GetAllCustomerResponse>>> GetAllAsync();
        Task<IDataResult<GetByIdCustomerResponse>> GetByIdAsync(int id);


    }
}
