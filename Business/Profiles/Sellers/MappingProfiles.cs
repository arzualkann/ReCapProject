using AutoMapper;
using Business.Requests.Rentals;
using Business.Requests.Sellers;
using Business.Responses.Rentals;
using Business.Responses.Sellers;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Sellers
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles() 
        {
            CreateMap<Seller, CreateSellerRequest>().ReverseMap();
            CreateMap<Seller, CreateSellerResponse>().ReverseMap();

            CreateMap<Seller, UpdateSellerRequest>().ReverseMap();
            CreateMap<Seller, UpdateSellerResponse>().ReverseMap();

            CreateMap<Rental, GetByIdSellerResponse>().ReverseMap();
            CreateMap<Seller, GetAllSellerResponse>().ReverseMap();
        }
    }
}
