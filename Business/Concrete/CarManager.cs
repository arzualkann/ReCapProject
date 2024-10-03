using AutoMapper;
using Business.Abstract;
using Business.Contants;
using Business.Requests.Cars;
using Business.Responses.Cars;
using Business.Rules;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        private readonly CarBusinessRules _carBusinessRules;

        public CarManager(ICarRepository carRepository, IMapper mapper, CarBusinessRules carBusinessRules)
        {
            _carRepository = carRepository;
            _mapper = mapper;
            _carBusinessRules = carBusinessRules;
        }

        public Task<IDataResult<CreateCarResponse>> AddAsync(CreateCarRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(DeleteCarRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<GetAllCarResponse>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<GetByIdCarResponse>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<UpdateCarResponse>> UpdateAsync(UpdateCarRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
