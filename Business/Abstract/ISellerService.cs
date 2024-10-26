using Business.Requests.Rentals;
using Business.Requests.Sellers;
using Business.Responses.Rentals;
using Business.Responses.Sellers;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISellerService
    {
        Task<IDataResult<CreateSellerResponse>> AddAsync(CreateSellerRequest request);
        Task<IDataResult<UpdateSellerResponse>> UpdateAsync(UpdateSellerRequest request);
        Task<IResult> DeleteAsync(DeleteSellerRequest request);
        Task<IDataResult<List<GetAllSellerResponse>>> GetAllAsync();
        Task<IDataResult<GetByIdSellerResponse>> GetByIdAsync(int id);

    }
}
