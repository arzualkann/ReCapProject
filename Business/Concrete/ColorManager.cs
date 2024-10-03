using AutoMapper;
using Business.Abstract;
using Business.Contants;
using Business.Requests.Colors;
using Business.Responses.Colors;
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
    public class ColorManager : IColorService
    {
        private readonly IColorRepository _colorRepository;
        private readonly IMapper _mapper;
        private readonly ColorBusinessRules _colorBusinessRules;

        public ColorManager(IColorRepository colorRepository, IMapper mapper, ColorBusinessRules colorBusinessRules)
        {
            _colorRepository = colorRepository;
            _mapper = mapper;
            _colorBusinessRules = colorBusinessRules;
        }

        public Task<IDataResult<CreateColorResponse>> AddAsync(CreateColorRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(DeleteColorRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<GetAllColorResponse>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<GetByIdColorResponse>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<UpdateColorResponse>> UpdateAsync(UpdateColorRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
