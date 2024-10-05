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

        public async Task<IDataResult<CreateCarResponse>> AddAsync(CreateCarRequest request)
        {
            Car car=_mapper.Map<Car>(request);
            await _carRepository.AddAsync(car);
            CreateCarResponse response=_mapper.Map<CreateCarResponse>(car);
            return new SuccessDataResult<CreateCarResponse>(response,CarMessages.CarAdded);
        }

        public async Task<IResult> DeleteAsync(DeleteCarRequest request)
        {
            var item = await _carRepository.GetByIdAsync(c=>c.Id==request.Id);
            await _carRepository.DeleteAsync(item);
            return new SuccessResult(CarMessages.CarDeleted);
        }

        public async Task<IDataResult<List<GetAllCarResponse>>> GetAllAsync()
        {
            var list=await _carRepository.GetAllAsync();
            List<GetAllCarResponse> response=_mapper.Map<List<GetAllCarResponse>>(list);
            return new SuccessDataResult<List<GetAllCarResponse>>(response,CarMessages.CarListed);
        }

        public async Task<IDataResult<GetByIdCarResponse>> GetByIdAsync(int id)
        {
            var item = await _carRepository.GetByIdAsync(c=>c.Id==id);
            GetByIdCarResponse response=_mapper.Map<GetByIdCarResponse>(item);
            return new SuccessDataResult<GetByIdCarResponse>(response);
        }

        public async Task<IDataResult<UpdateCarResponse>> UpdateAsync(UpdateCarRequest request)
        {
            var item = await _carRepository.GetByIdAsync(c => c.Id == request.Id);
            _mapper.Map(request,item);
            await _carRepository.UpdateAsync(item);
            UpdateCarResponse response=_mapper.Map<UpdateCarResponse>(item);
            return new SuccessDataResult<UpdateCarResponse>(response,CarMessages.CarUpdated);
        }
    }
}
