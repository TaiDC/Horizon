using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Horizon.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : Horizon.Models.Common.BaseObject
    {
        TEntity GetById(object id);
        IEnumerable<TEntity> GetList();
        Task<IEnumerable<TEntity>> GetListAsync();
        TEntity Find(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> expression);
        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> expression);
        Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> expression);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        void Reset();
    }
}
