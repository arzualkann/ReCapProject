using AutoMapper;
using Business.Abstract;
using Business.Contants;
using Business.Requests.Customers;
using Business.Responses.CarImages;
using Business.Responses.Customers;
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

        public async Task<IDataResult<CreateCustomerResponse>> AddAsync(CreateCustomerRequest request)
        {
            Customer customer = _mapper.Map<Customer>(request);
            await _customerRepository.AddAsync(customer);
            CreateCustomerResponse response = _mapper.Map<CreateCustomerResponse>(customer);
            return new SuccessDataResult<CreateCustomerResponse>(response, CustomerMessages.CustomerAdded);
        }

        public async Task<IResult> DeleteAsync(DeleteCustomerRequest request)
        {
            var item = await _customerRepository.GetByIdAsync(c => c.Id == request.Id);
            await _customerRepository.DeleteAsync(item);
            return new SuccessResult(CustomerMessages.CustomerDeleted);
        }

        public async Task<IDataResult<List<GetAllCustomerResponse>>> GetAllAsync()
        {
            var list = await _customerRepository.GetAllAsync();
            List<GetAllCustomerResponse> response = _mapper.Map<List<GetAllCustomerResponse>>(list);
            return new SuccessDataResult<List<GetAllCustomerResponse>>(response);
        }

        public async Task<IDataResult<GetByIdCustomerResponse>> GetByIdAsync(int id)
        {
            var item = await _customerRepository.GetByIdAsync(x => x.Id == id);
            GetByIdCustomerResponse response = _mapper.Map<GetByIdCustomerResponse>(item);
            return new SuccessDataResult<GetByIdCustomerResponse>(response);
        }

        public async Task<IDataResult<UpdateCustomerResponse>> UpdateAsync(UpdateCustomerRequest request)
        {
            var item = await _customerRepository.GetByIdAsync(c => c.Id == request.Id);
            _mapper.Map(request, item);
            await _customerRepository.UpdateAsync(item);
            UpdateCustomerResponse response = _mapper.Map<UpdateCustomerResponse>(item);
            return new SuccessDataResult<UpdateCustomerResponse>(response, CustomerMessages.CustomerUpdated);
        }
    }
}
