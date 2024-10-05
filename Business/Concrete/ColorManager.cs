using AutoMapper;
using Azure.Core;
using Business.Abstract;
using Business.Contants;
using Business.Requests.Colors;
using Business.Responses.CarImages;
using Business.Responses.Colors;
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

        public async Task<IDataResult<CreateColorResponse>> AddAsync(CreateColorRequest request)
        {
            Color color = _mapper.Map<Color>(request);
            await _colorRepository.AddAsync(color);
            CreateColorResponse response=_mapper.Map<CreateColorResponse>(color);
            return new SuccessDataResult<CreateColorResponse>(response,ColorMessages.ColorAdded);
        }
        public async Task<IResult> DeleteAsync(DeleteColorRequest request)
        {
            var item = await _colorRepository.GetByIdAsync(c => c.Id == request.Id);
            await _colorRepository.DeleteAsync(item);
            return new SuccessResult(ColorMessages.ColorDeleted);
        }

        public async Task<IDataResult<List<GetAllColorResponse>>> GetAllAsync()
        {
            var list = await _colorRepository.GetAllAsync();
            List<GetAllColorResponse> response = _mapper.Map<List<GetAllColorResponse>>(list);
            return new SuccessDataResult<List<GetAllColorResponse>>(response);
        }

        public async Task<IDataResult<GetByIdColorResponse>> GetByIdAsync(int id)
        {
            var item = await _colorRepository.GetByIdAsync(x => x.Id == id);
            GetByIdColorResponse response = _mapper.Map<GetByIdColorResponse>(item);
            return new SuccessDataResult<GetByIdColorResponse>(response);
        }

        public async Task<IDataResult<UpdateColorResponse>> UpdateAsync(UpdateColorRequest request)
        {
            var item = await _colorRepository.GetByIdAsync(c => c.Id == request.Id);
            _mapper.Map(request, item);
            await _colorRepository.UpdateAsync(item);
            UpdateColorResponse response = _mapper.Map<UpdateColorResponse>(item);
            return new SuccessDataResult<UpdateColorResponse>(response, ColorMessages.ColorUpdated);
        }
    }
}
