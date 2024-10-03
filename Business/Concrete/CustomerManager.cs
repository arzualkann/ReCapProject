using AutoMapper;
using Business.Abstract;
using Business.Contants;
using Business.Requests.Customers;
using Business.Responses.Customers;
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
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        private readonly CustomerBusinessRules _customerBusinessRules;

        public CustomerManager(ICustomerRepository customerRepository, IMapper mapper, CustomerBusinessRules customerBusinessRules)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
            _customerBusinessRules = customerBusinessRules;
        }

        public Task<IDataResult<CreateCustomerResponse>> AddAsync(CreateCustomerRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(DeleteCustomerRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<GetAllCustomerResponse>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<GetByIdCustomerResponse>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<UpdateCustomerResponse>> UpdateAsync(UpdateCustomerRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
