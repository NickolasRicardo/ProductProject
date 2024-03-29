﻿using AutoMapper;
using ProductApplication.Application.DTO;
using ProductApplication.Application.Interfaces.Services;
using ProductApplication.CrossCutting.Pagination;
using ProductApplication.Domain.Interfaces.Services;
using System.Linq.Expressions;

namespace ProductApplication.Application.Services.Services
{
    public class ApplicationServiceBase<TEntity, TDto> : IApplicationServiceBase<TEntity, TDto> where TEntity : class
                                                                                                where TDto : DTOBase
    {
        protected readonly IServiceBase<TEntity> _service;
        protected readonly IMapper _mapper;

        public ApplicationServiceBase(IServiceBase<TEntity> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task Add(TDto item)
        {
            var obj = _mapper.Map<TEntity>(item);

            await _service.Add(obj);
        }

        public async Task Delete(int id)
        {
            await _service.Delete(id);
        }

        public async Task<TDto> Find(params object[] keys)
        {
            var obj = await _service.Find(keys);

            var objDTO = _mapper.Map<TDto>(obj);

            return objDTO;
        }

     
        public async Task<PagedModel<TDto>> Get(Expression<Func<TEntity, bool>> predicate, CrossCutting.Conditions.QueryParam param)
        {
            var listObj = await _service.Get(predicate, param);

            var objDTO = _mapper.Map<PagedModel<TDto>>(listObj);

            return objDTO;

        }

        public async Task<PagedModel<TDto>> GetAll(CrossCutting.Conditions.QueryParam param)
        {
            var listObj = await _service.GetAll(param);

            var objDTO = _mapper.Map<PagedModel<TDto>>(listObj);

            return objDTO;

        }

        public async Task<TDto> GetByFilter(Expression<Func<TEntity, bool>> predicate)
        {
            var obj = await _service.GetByFilter(predicate);

            var objDTO = _mapper.Map<TDto>(obj);

            return objDTO;
        }

        public async Task<TDto> GetById(int id)
        {
            var obj = await _service.GetById(id);

            var objDTO = _mapper.Map<TDto>(obj);

            return objDTO;
        }

        public async Task Update(TDto item)
        {
            var obj = _mapper.Map<TEntity>(item);

            await _service.Update(obj);
        }
    }
}
