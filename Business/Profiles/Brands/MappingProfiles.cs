using AutoMapper;
using Business.Requests.Brands;
using Business.Requests.CarImages;
using Business.Responses.Brands;
using Business.Responses.CarImages;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Brands;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Brand, CreateBrandRequest>().ReverseMap();
        CreateMap<Brand, CreateBrandResponse>().ReverseMap();

        CreateMap<Brand, UpdateBrandRequest>().ReverseMap();
        CreateMap<Brand, UpdateBrandResponse>().ReverseMap();

        CreateMap<Brand, GetByIdBrandResponse>().ReverseMap();
        CreateMap<Brand, GetAllBrandResponse>().ReverseMap();
    }
}

