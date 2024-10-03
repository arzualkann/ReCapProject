using AutoMapper;
using Business.Requests.Customers;
using Business.Requests.Rentals;
using Business.Responses.Customers;
using Business.Responses.Rentals;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Customers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Customer, CreateCustomerRequest>().ReverseMap();
            CreateMap<Customer, CreateCustomerResponse>().ReverseMap();

            CreateMap<Customer, UpdateCustomerRequest>().ReverseMap();
            CreateMap<Customer, UpdateCustomerResponse>().ReverseMap();

            CreateMap<Customer, GetByIdCustomerResponse>().ReverseMap();
            CreateMap<Customer, GetAllCustomerResponse>().ReverseMap();
        }
    }

}
