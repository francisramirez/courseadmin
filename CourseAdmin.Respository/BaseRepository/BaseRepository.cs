using CourseAdmin.Respository.Interfaces;
using CourseAdmin.Domain.BaseEntities;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace CourseAdmin.Respository.BaseRepository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        public Task Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task Add(params TEntity[] entities)
        {
            throw new NotImplementedException();
        }

        public Task Add(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Commit()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountWhere(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Find(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetWhere(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task Remove(object id)
        {
            throw new NotImplementedException();
        }

        public Task Remove(params TEntity[] entities)
        {
            throw new NotImplementedException();
        }

        public Task Remove(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RollBack()
        {
            throw new NotImplementedException();
        }

        public Task Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(params TEntity[] entities)
        {
            throw new NotImplementedException();
        }

        public Task Update(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
