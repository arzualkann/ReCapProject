using AutoMapper;
using Business.Abstract;
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

        public Task<IDataResult<CreateCarImageResponse>> AddAsync(CreateCarImageRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(DeleteCarImageRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<GetAllCarImageResponse>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<GetByIdCarImageResponse>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<UpdateCarImageResponse>> UpdateAsync(UpdateCarImageRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
