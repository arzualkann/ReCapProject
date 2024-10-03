using AutoMapper;
using Business.Abstract;
using Business.Contants;
using Business.Requests.Users;
using Business.Responses.Users;
using Business.Rules;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Utilities.Results;
using Core.Utilities.Security.Entities;
using DataAccess.Abstract;
using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly UserBusinessRules _rules;
        public UserManager(IUserRepository userRepository, IMapper mapper, UserBusinessRules rules)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _rules = rules;
        }
        [LogAspect(typeof(MongoDbLogger))]
        public async Task<IDataResult<CreateUserResponse>> AddAsync(CreateUserRequest request)
        {
            User user = _mapper.Map<User>(request);
            await _userRepository.AddAsync(user);
            CreateUserResponse response = _mapper.Map<CreateUserResponse>(user);
            return new SuccessDataResult<CreateUserResponse>(response, UserMessages.UserAdded);
        }
        [LogAspect(typeof(MongoDbLogger))]
        public async Task<IResult> DeleteAsync(DeleteUserRequest request)
        {           
            var item = await _userRepository.GetByIdAsync(x => x.Id == request.Id);
            await _userRepository.DeleteAsync(item);

            return new SuccessResult(UserMessages.UserDeleted);
        }

        public async Task<IDataResult<List<GetAllUserResponse>>> GetAllAsync()
        {
            var list = await _userRepository.GetAllAsync();
            List<GetAllUserResponse> response = _mapper.Map<List<GetAllUserResponse>>(list);
            return new SuccessDataResult<List<GetAllUserResponse>>(response, UserMessages.UserListed);
        }

        public async Task<DataResult<User>> GetById(int id)
        {
            return new SuccessDataResult<User>(await _userRepository.GetByIdAsync(x => x.Id == id));
        }

        public async Task<IDataResult<GetByIdUserResponse>> GetByIdAsync(int id)
        {

            var item = await _userRepository.GetByIdAsync(x => x.Id == id);

            GetByIdUserResponse response = _mapper.Map<GetByIdUserResponse>(item);


            return new SuccessDataResult<GetByIdUserResponse>(response, UserMessages.UserFound);

        }

        public async Task<DataResult<User>> GetByMail(string email)
        {
            return new SuccessDataResult<User>(await _userRepository.GetByIdAsync(x => x.Email == email));
        }

        [LogAspect(typeof(MongoDbLogger))]
        public async Task<IDataResult<UpdateUserResponse>> UpdateAsync(UpdateUserRequest request)
        {

            var item = await _userRepository.GetByIdAsync(p => p.Id == request.Id);

            _mapper.Map(request, item);
            await _userRepository.UpdateAsync(item);

            UpdateUserResponse response = _mapper.Map<UpdateUserResponse>(item);
            return new SuccessDataResult<UpdateUserResponse>(response, UserMessages.UserUpdated);
        }
    }
}
