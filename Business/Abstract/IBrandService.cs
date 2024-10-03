using Business.Requests.Brands;
using Business.Responses.Brands;
using Core.Utilities;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        Task<IDataResult<CreateBrandResponse>> AddAsync(CreateBrandRequest request);
        Task<IDataResult<UpdateBrandResponse>> UpdateAsync(UpdateBrandRequest request);
        Task<IResult> DeleteAsync(DeleteBrandRequest request);
        Task<IDataResult<List<GetAllBrandResponse>>> GetAllAsync();
        Task<IDataResult<GetByIdBrandResponse>> GetByIdAsync(int id);

    }
}
