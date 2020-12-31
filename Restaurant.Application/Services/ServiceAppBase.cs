using AutoMapper;
using Restaurant.Application.DTO;
using Restaurant.Application.Interfaces;
using Restaurant.Domain.Entities;
using Restaurant.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Application.Services
{
    public class ServiceAppBase<TEntity, TEntityDTO> : IAppBase<TEntity, TEntityDTO> where TEntity : EntityBase where TEntityDTO : DTOBase
    {
        private readonly IServiceBase<TEntity> service;
        private readonly IMapper iMapper;
        public ServiceAppBase(IMapper iMapper, IServiceBase<TEntity> service) : base()
        {
            this.iMapper = iMapper;
            this.service = service;
        }
        public int Add(TEntityDTO entity)
        {
            return service.Add(iMapper.Map<TEntity>(entity));
        }

        public void Remove(int id)
        {
            service.Remove(id);
        }

        public void Remove(TEntityDTO entity)
        {
            service.Remove(iMapper.Map<TEntity>(entity));
        }

        public IEnumerable<TEntityDTO> SelectAll()
        {
            return iMapper.Map<IEnumerable<TEntityDTO>>(service.SelectAll());
        }

        public TEntityDTO SelectById(int id)
        {
            return iMapper.Map<TEntityDTO>(service.SelectById(id));
        }

        public void Update(TEntityDTO entity)
        {
            service.Update(iMapper.Map<TEntity>(entity));
        }
    }
}
