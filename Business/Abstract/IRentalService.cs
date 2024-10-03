using Business.Requests.Rentals;
using Business.Responses.Rentals;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        Task<IDataResult<CreateRentalResponse>> AddAsync(CreateRentalRequest request);
        Task<IDataResult<UpdateRentalResponse>> UpdateAsync(UpdateRentalRequest request);
        Task<IResult> DeleteAsync(DeleteRentalRequest request);
        Task<IDataResult<List<GetAllRentalResponse>>> GetAllAsync();
        Task<IDataResult<GetByIdRentalResponse>> GetByIdAsync(int id);

    }
}
