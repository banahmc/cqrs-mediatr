using CQRSMediatR.Entities;
using System;
using System.Collections.Generic;

namespace CQRSMediatR.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : IEntity
    {
        TEntity FindOne(Guid id);
        IEnumerable<TEntity> FindAll();
        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
