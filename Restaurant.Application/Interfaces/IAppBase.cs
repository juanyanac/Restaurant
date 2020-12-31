using Restaurant.Application.DTO;
using Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Application.Interfaces
{
    public interface IAppBase<TEntity, TEntityDTO> where TEntity : EntityBase where TEntityDTO : DTOBase
    {
        int Add(TEntityDTO entity);
        void Remove(int id);
        void Remove(TEntityDTO entity);
        void Update(TEntityDTO entity);
        TEntityDTO SelectById(int id);
        IEnumerable<TEntityDTO> SelectAll();
    }
}
