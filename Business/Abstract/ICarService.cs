using Business.Requests.Cars;
using Business.Responses.Cars;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        Task<IDataResult<CreateCarResponse>> AddAsync(CreateCarRequest request);
        Task<IDataResult<UpdateCarResponse>> UpdateAsync(UpdateCarRequest request);
        Task<IResult> DeleteAsync(DeleteCarRequest request);
        Task<IDataResult<List<GetAllCarResponse>>> GetAllAsync();
        Task<IDataResult<GetByIdCarResponse>> GetByIdAsync(int id);

    }
}
