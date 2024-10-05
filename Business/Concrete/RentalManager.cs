using AutoMapper;
using Business.Abstract;
using Business.Contants;
using Business.Requests.Rentals;
using Business.Responses.CarImages;
using Business.Responses.Rentals;
using Business.Rules;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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
    public class RentalManager : IRentalService
    {
        private readonly IRentalRepository _rentalRepository;
        private readonly IMapper _mapper;
        private readonly RentalBusinessRules _rentalBusinessRules;

        public RentalManager(IRentalRepository rentalRepository, IMapper mapper, RentalBusinessRules rentalBusinessRules)
        {
            _rentalRepository = rentalRepository;
            _mapper = mapper;
            _rentalBusinessRules = rentalBusinessRules;
        }

        public async Task<IDataResult<CreateRentalResponse>> AddAsync(CreateRentalRequest request)
        {
            Rental rental = _mapper.Map<Rental>(request);
            await _rentalRepository.AddAsync(rental);
            CreateRentalResponse response = _mapper.Map<CreateRentalResponse>(rental);
            return new SuccessDataResult<CreateRentalResponse>(response, RentalMessages.RentalAdded);
        }

        public async Task<IResult> DeleteAsync(DeleteRentalRequest request)
        {
            var item = await _rentalRepository.GetByIdAsync(c => c.Id == request.Id);
            await _rentalRepository.DeleteAsync(item);
            return new SuccessResult(RentalMessages.RentalDeleted);
        }

        public async Task<IDataResult<List<GetAllRentalResponse>>> GetAllAsync()
        {
            var list = await _rentalRepository.GetAllAsync();
            List<GetAllRentalResponse> response = _mapper.Map<List<GetAllRentalResponse>>(list);
            return new SuccessDataResult<List<GetAllRentalResponse>>(response);
        }

        public async Task<IDataResult<GetByIdRentalResponse>> GetByIdAsync(int id)
        {
            var item = await _rentalRepository.GetByIdAsync(x => x.Id == id);
            GetByIdRentalResponse response = _mapper.Map<GetByIdRentalResponse>(item);
            return new SuccessDataResult<GetByIdRentalResponse>(response);
        }

        public async Task<IDataResult<UpdateRentalResponse>> UpdateAsync(UpdateRentalRequest request)
        {
            var item = await _rentalRepository.GetByIdAsync(c => c.Id == request.Id);
            _mapper.Map(request, item);
            await _rentalRepository.UpdateAsync(item);
            UpdateRentalResponse response = _mapper.Map<UpdateRentalResponse>(item);
            return new SuccessDataResult<UpdateRentalResponse>(response, RentalMessages.RentalUpdated);
        }
    }
}
