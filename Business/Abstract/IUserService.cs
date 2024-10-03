using Business.Requests.Rentals;
using Business.Requests.Users;
using Business.Responses.Rentals;
using Business.Responses.Users;
using Core.Utilities.Results;
using Core.Utilities.Security.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        Task<IDataResult<CreateUserResponse>> AddAsync(CreateUserRequest request);
        Task<IDataResult<UpdateUserResponse>> UpdateAsync(UpdateUserRequest request);
        Task<IResult> DeleteAsync(DeleteUserRequest request);
        Task<IDataResult<List<GetAllUserResponse>>> GetAllAsync();
        Task<IDataResult<GetByIdUserResponse>> GetByIdAsync(int id);
        Task<DataResult<User>> GetById(int id);
        Task<DataResult<User>> GetByMail(string email);

    }
}
