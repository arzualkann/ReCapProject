using AutoMapper;
using Business.Requests.CarImages;
using Business.Requests.Colors;
using Business.Responses.CarImages;
using Business.Responses.Colors;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.CarImages;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CarImage, CreateCarImageRequest>().ReverseMap();
        CreateMap<CarImage, CreateCarImageResponse>().ReverseMap();

        CreateMap<CarImage, UpdateCarImageRequest>().ReverseMap();
        CreateMap<CarImage, UpdateCarImageResponse>().ReverseMap();

        CreateMap<CarImage, GetByIdCarImageResponse>().ReverseMap();
        CreateMap<CarImage, GetAllCarImageResponse>().ReverseMap();
    }
}

