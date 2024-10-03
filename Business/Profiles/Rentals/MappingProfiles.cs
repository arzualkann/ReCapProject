using AutoMapper;
using Business.Requests.Rentals;
using Business.Responses.Rentals;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Rentals
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Rental, CreateRentalRequest>().ReverseMap();
            CreateMap<Rental, CreateRentalResponse>().ReverseMap();

            CreateMap<Rental, UpdateRentalRequest>().ReverseMap();
            CreateMap<Rental, UpdateRentalResponse>().ReverseMap();

            CreateMap<Rental, GetByIdRentalResponse>().ReverseMap();
            CreateMap<Rental, GetAllRentalResponse>().ReverseMap();
        }
    }
}
