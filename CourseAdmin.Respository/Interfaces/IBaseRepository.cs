﻿using CourseAdmin.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CourseAdmin.Respository.Interfaces
{
    public interface IBaseRepository<TEntity> : IUnitOfWork where TEntity : BaseEntity
    {
        Task<TEntity> GetById(object id);
        Task<TEntity> Find(Expression<Func<TEntity, bool>> filter);
        Task Add(TEntity entity);
        Task Add(params TEntity[] entities);
        Task Add(IEnumerable<TEntity> entities);
        Task Update(TEntity entity);
        Task Update(params TEntity[] entities);
        Task Update(IEnumerable<TEntity> entities);
        Task Remove(TEntity entity);
        Task Remove(object id);
        Task Remove(params TEntity[] entities);
        Task Remove(IEnumerable<TEntity> entities);
        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> GetWhere(Expression<Func<TEntity, bool>> filter);
        Task<int> CountAll();
        Task<int> CountWhere(Expression<Func<TEntity, bool>> filter);
        Task<bool> Exists(Expression<Func<TEntity, bool>> filter);

    }
}
