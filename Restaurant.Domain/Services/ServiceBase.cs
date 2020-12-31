using Restaurant.Domain.Entities;
using Restaurant.Domain.Interfaces.Repositories;
using Restaurant.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : EntityBase
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        public int Add(TEntity entity)
        {
            return repository.Add(entity);
        }

        public void Remove(int id)
        {
            repository.Remove(id);
        }

        public void Remove(TEntity entity)
        {
            repository.Remove(entity);
        }

        public IEnumerable<TEntity> SelectAll()
        {
            return repository.SelectAll();
        }

        public TEntity SelectById(int id)
        {
            return repository.SelectById(id);
        }

        public void Update(TEntity entity)
        {
            repository.Update(entity);
        }
    }
}
