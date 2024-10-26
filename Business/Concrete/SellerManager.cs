using AutoMapper;
using Business.Abstract;
using Business.Contants;
using Business.Requests.Sellers;
using Business.Responses.Brands;
using Business.Responses.Sellers;
using Business.Rules;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.Repositories;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SellerManager : ISellerService
    {
        private readonly ISellerRepository _sellerRepository;
        private readonly IMapper _mapper;
        private readonly SellerBusinessRules _sellerBusinessRules;

        public SellerManager(ISellerRepository sellerRepository, IMapper mapper, SellerBusinessRules sellerBusinessRules)
        {
            _sellerRepository = sellerRepository;
            _mapper = mapper;
            _sellerBusinessRules = sellerBusinessRules;
        }

        public async Task<IDataResult<CreateSellerResponse>> AddAsync(CreateSellerRequest request)
        {
            Seller seller = _mapper.Map<Seller>(request);
            await _sellerRepository.AddAsync(seller);
            CreateSellerResponse response = _mapper.Map<CreateSellerResponse>(seller);
            return new SuccessDataResult<CreateSellerResponse>(response, SellerMessages.SellerAdded);
        }

        public async Task<IResult> DeleteAsync(DeleteSellerRequest request)
        {
            var result = await _sellerRepository.GetByIdAsync(x => x.Id == request.Id);
            await _sellerRepository.DeleteAsync(result);
            return new SuccessResult(SellerMessages.SellerDeleted);
        }

        public async Task<IDataResult<List<GetAllSellerResponse>>> GetAllAsync()
        {
            var list = await _sellerRepository.GetAllAsync();
            List<GetAllSellerResponse> response = _mapper.Map<List<GetAllSellerResponse>>(list);
            return new SuccessDataResult<List<GetAllSellerResponse>>(response, SellerMessages.SellerListed);
        }

        public async Task<IDataResult<GetByIdSellerResponse>> GetByIdAsync(int id)
        {
            var item = await _sellerRepository.GetByIdAsync(x => x.Id == id);
            GetByIdSellerResponse response = _mapper.Map<GetByIdSellerResponse>(item);
            return new SuccessDataResult<GetByIdSellerResponse>(response);
        }

        public async Task<IDataResult<UpdateSellerResponse>> UpdateAsync(UpdateSellerRequest request)
        {
            var item = await _sellerRepository.GetByIdAsync(x => x.Id == request.Id);
            _mapper.Map(request, item);
            await _sellerRepository.UpdateAsync(item);
            UpdateSellerResponse response = _mapper.Map<UpdateSellerResponse>(item);
            return new SuccessDataResult<UpdateSellerResponse>(response, SellerMessages.SellerUpdated);
        }
    }
}
