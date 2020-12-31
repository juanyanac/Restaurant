using Microsoft.EntityFrameworkCore;
using Restaurant.Domain.Entities;
using Restaurant.Domain.Interfaces.Repositories;
using Restaurant.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        protected readonly Context context;
        public RepositoryBase(Context context) : base()
        {
            this.context = context;
        }
        public int Add(TEntity entity)
        {
            context.InitTransaction();
            var id = context.Set<TEntity>().Add(entity).Entity.Id;
            context.SaveChanges();
            return id;
        }

        public void Remove(int id)
        {
            var entity = SelectById(id);
            if (entity != null)
            {
                context.InitTransaction();
                context.Set<TEntity>().Remove(entity);
                context.SendChanges();
            }
        }

        public void Remove(TEntity entity)
        {
            context.InitTransaction();
            context.Set<TEntity>().Remove(entity);
            context.SendChanges();
        }

        public IEnumerable<TEntity> SelectAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public TEntity SelectById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
            context.InitTransaction();
            context.Set<TEntity>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SendChanges();
        }
    }
}
