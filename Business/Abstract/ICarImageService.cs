using Business.Requests.CarImages;
using Business.Responses.CarImages;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        Task<List<CarImage>> GetList();
        Task<CarImage> Get(int id);
        Task<CarImage> Add(IFormFile file, CreateCarImageRequest request);
        Task<CarImage> Update(IFormFile file, CarImage carImage);
        Task<CarImage> Delete(CarImage carImage);
        Task<List<CarImage>> GetImagesByCarId(int id);


    }
}
