using AutoMapper;
using Business.Abstract;
using Business.Contants;
using Business.Requests.CarImages;
using Business.Responses.CarImages;
using Business.Rules;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private readonly ICarImageRepository _carImageRepository;
        private readonly IMapper _mapper;
        private readonly CarImageBusinessRules _carImageBusinessRules;

        public CarImageManager(ICarImageRepository carImageRepository, IMapper mapper, CarImageBusinessRules carImageBusinessRules)
        {
            _carImageRepository = carImageRepository;
            _mapper = mapper;
            _carImageBusinessRules = carImageBusinessRules;
        }

        public async Task<IDataResult<CreateCarImageResponse>> AddAsync(CreateCarImageRequest request)
        {
            CarImage carImage = _mapper.Map<CarImage>(request);
            await _carImageRepository.AddAsync(carImage);
            CreateCarImageResponse response = _mapper.Map<CreateCarImageResponse>(carImage);
            return new SuccessDataResult<CreateCarImageResponse>(response, CarImageMessages.CarImageAdded);
        }

        public async Task<IResult> DeleteAsync(DeleteCarImageRequest request)
        {
            var item = await _carImageRepository.GetByIdAsync(c => c.Id == request.Id);
            await _carImageRepository.DeleteAsync(item);
            return new SuccessResult(CarImageMessages.CarImageDeleted);
        }

        public async Task<IDataResult<List<GetAllCarImageResponse>>> GetAllAsync()
        {
            var list = await _carImageRepository.GetAllAsync();
            List<GetAllCarImageResponse> response = _mapper.Map<List<GetAllCarImageResponse>>(list);
            return new SuccessDataResult<List<GetAllCarImageResponse>>(response);
        }

        public async Task<IDataResult<GetByIdCarImageResponse>> GetByIdAsync(int id)
        {
            var item = await _carImageRepository.GetByIdAsync(x => x.Id == id);
            GetByIdCarImageResponse response = _mapper.Map<GetByIdCarImageResponse>(item);
            return new SuccessDataResult<GetByIdCarImageResponse>(response);
        }

        public async Task<IDataResult<UpdateCarImageResponse>> UpdateAsync(UpdateCarImageRequest request)
        {
            var item = await _carImageRepository.GetByIdAsync(c => c.Id == request.Id);
            _mapper.Map(request,item);
            await _carImageRepository.UpdateAsync(item);
            UpdateCarImageResponse response=_mapper.Map<UpdateCarImageResponse>(item);
            return new SuccessDataResult<UpdateCarImageResponse>(response,CarImageMessages.CarImageUpdated);
        }
    }
}
