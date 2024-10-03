using Business.Requests.CarImages;
using Business.Responses.CarImages;
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
    public interface ICarImageService
    {
        Task<IDataResult<CreateCarImageResponse>> AddAsync(CreateCarImageRequest request);
        Task<IDataResult<UpdateCarImageResponse>> UpdateAsync(UpdateCarImageRequest request);
        Task<IResult> DeleteAsync(DeleteCarImageRequest request);
        Task<IDataResult<List<GetAllCarImageResponse>>> GetAllAsync();
        Task<IDataResult<GetByIdCarImageResponse>> GetByIdAsync(int id);


    }
}
