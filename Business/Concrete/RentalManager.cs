using AutoMapper;
using Business.Abstract;
using Business.Contants;
using Business.Requests.Rentals;
using Business.Responses.Rentals;
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

        public Task<IDataResult<CreateRentalResponse>> AddAsync(CreateRentalRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(DeleteRentalRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<GetAllRentalResponse>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<GetByIdRentalResponse>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<UpdateRentalResponse>> UpdateAsync(UpdateRentalRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
