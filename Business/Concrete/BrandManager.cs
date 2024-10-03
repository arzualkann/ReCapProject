using AutoMapper;
using Business.Abstract;
using Business.Contants;
using Business.Requests.Brands;
using Business.Responses.Brands;
using Business.Rules;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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
    public class BrandManager : IBrandService
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;
        private readonly BrandBusinessRules _brandBusinessRules;

        public BrandManager(IBrandRepository brandRepository, IMapper mapper, BrandBusinessRules brandBusinessRules)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
            _brandBusinessRules = brandBusinessRules;
        }

        public async Task<IDataResult<CreateBrandResponse>> AddAsync(CreateBrandRequest request)
        {
            Brand brand=_mapper.Map<Brand>(request);
            await _brandRepository.AddAsync(brand);
            CreateBrandResponse response=_mapper.Map<CreateBrandResponse>(brand);
            return new SuccessDataResult<CreateBrandResponse>(response,BrandMessages.BrandAdded);
        }

        public async Task<IResult> DeleteAsync(DeleteBrandRequest request)
        {
            var result = await _brandRepository.GetByIdAsync(x=>x.Id==request.Id);
            await _brandRepository.DeleteAsync(result);
            return new SuccessResult(BrandMessages.BrandDeleted);
        }

        public async Task<IDataResult<List<GetAllBrandResponse>>> GetAllAsync()
        {
            var list=await _brandRepository.GetAllAsync();
            List<GetAllBrandResponse> response=_mapper.Map<List<GetAllBrandResponse>>(list);
            return new SuccessDataResult<List<GetAllBrandResponse>>(response,BrandMessages.BrandListed);
        }

        public async Task<IDataResult<GetByIdBrandResponse>> GetByIdAsync(int id)
        {
            var item = await _brandRepository.GetByIdAsync(x=>x.Id==id);
            GetByIdBrandResponse response=_mapper.Map<GetByIdBrandResponse>(item);
            return new SuccessDataResult<GetByIdBrandResponse>(response);
        }

        public async Task<IDataResult<UpdateBrandResponse>> UpdateAsync(UpdateBrandRequest request)
        {
            var item = await _brandRepository.GetByIdAsync(x=>x.Id==request.Id);
            _mapper.Map(request, item);
            await _brandRepository.UpdateAsync(item);
            UpdateBrandResponse response=_mapper.Map<UpdateBrandResponse>(item);
            return new SuccessDataResult<UpdateBrandResponse>(response,BrandMessages.BrandUpdated);
        }
    }
}
