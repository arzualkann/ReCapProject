using AutoMapper;
using Business.Requests.Colors;
using Business.Requests.Customers;
using Business.Responses.Colors;
using Business.Responses.Customers;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Colors;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Color, CreateColorRequest>().ReverseMap();
        CreateMap<Color, CreateColorResponse>().ReverseMap();

        CreateMap<Color, UpdateColorRequest>().ReverseMap();
        CreateMap<Color, UpdateColorResponse>().ReverseMap();

        CreateMap<Color, GetByIdColorResponse>().ReverseMap();
        CreateMap<Color, GetAllColorResponse>().ReverseMap();
    }
}

