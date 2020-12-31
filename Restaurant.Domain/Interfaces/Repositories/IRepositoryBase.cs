using Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase <TEntity> where TEntity : EntityBase
    {
        int Add(TEntity entity);
        void Remove(int id);
        void Remove(TEntity entity);
        void Update(TEntity entity);
        TEntity SelectById(int id);
        IEnumerable<TEntity> SelectAll();
    }
}
