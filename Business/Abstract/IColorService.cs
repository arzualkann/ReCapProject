using Business.Requests.Colors;
using Business.Responses.Colors;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        Task<IDataResult<CreateColorResponse>> AddAsync(CreateColorRequest request);
        Task<IDataResult<UpdateColorResponse>> UpdateAsync(UpdateColorRequest request);
        Task<IResult> DeleteAsync(DeleteColorRequest request);
        Task<IDataResult<List<GetAllColorResponse>>> GetAllAsync();
        Task<IDataResult<GetByIdColorResponse>> GetByIdAsync(int id);

    }
}
