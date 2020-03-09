using System.Collections.Generic;

namespace DDDCore.Domain.Interfaces.AppServices
{
    public interface IAppServiceBase<TEntity>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
