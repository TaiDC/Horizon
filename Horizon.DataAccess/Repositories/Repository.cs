using Horizon.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Horizon.DataAccess.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Models.Common.BaseObject
    {
        protected readonly ApplicationDbContext _dataContext;
        protected DbSet<TEntity> DbSetEntity;
        public Repository(ApplicationDbContext context)
        {
            _dataContext = context;
            DbSetEntity = _dataContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            entity.DateCreate = DateTime.Now;
            DbSetEntity.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            foreach (var item in entities)
            {
                item.DateCreate = DateTime.Now;
            }
            DbSetEntity.AddRange(entities);
        }

        public TEntity Find(Expression<Func<TEntity, bool>> expression)
        {
            return DbSetEntity.Where(expression).FirstOrDefault();
        }

        public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await DbSetEntity.Where(expression).FirstOrDefaultAsync();
        }

        public TEntity GetById(object id)
        {
            return DbSetEntity.Find(id);
        }

        public IEnumerable<TEntity> GetList()
        {
            return DbSetEntity.ToList();
        }

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> expression)
        {
            return DbSetEntity.Where(expression).ToList();
        }

        public async Task<IEnumerable<TEntity>> GetListAsync()
        {
            return await DbSetEntity.ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await DbSetEntity.Where(expression).ToListAsync();
        }

        public void Remove(TEntity entity)
        {
            DbSetEntity.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            DbSetEntity.RemoveRange(entities);
        }

        public void Reset()
        {
            var entries = _dataContext.ChangeTracker.Entries<TEntity>().Where(e => e.State != EntityState.Unchanged).ToList();
            foreach (var entry in entries)
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }

        public void Update(TEntity entity)
        {
            DbSetEntity.Attach(entity);
            entity.DateModify = DateTime.Now;
            _dataContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
