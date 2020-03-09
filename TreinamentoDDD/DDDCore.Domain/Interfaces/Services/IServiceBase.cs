using System;
using System.Collections.Generic;
using System.Text;

namespace DDDCore.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
