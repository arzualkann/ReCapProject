using AutoMapper;
using Business.Requests.Cars;
using Business.Requests.Colors;
using Business.Responses.Cars;
using Business.Responses.Colors;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Cars;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Car, CreateCarRequest>().ReverseMap();
        CreateMap<Car, CreateCarResponse>().ReverseMap();

        CreateMap<Car, UpdateCarRequest>().ReverseMap();
        CreateMap<Car, UpdateCarResponse>().ReverseMap();

        CreateMap<Car, GetByIdCarResponse>().ReverseMap();
        CreateMap<Car, GetAllCarResponse>().ReverseMap();
    }
}

