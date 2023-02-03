using Microsoft.EntityFrameworkCore;
using MiniETrade.Dal;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MiniETrade.Core
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        Context _db;
        public BaseRepository(Context db)
        {
            _db = db;
        }
        public async Task<T> AddAsync(T entity)
        {
            await Set().AddAsync(entity);
            return entity;
        }

        public bool AddRange(List<T> entities)
        {
            try
            {
                Set().AddRange(entities);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int Id)
        {
            try
            {
                Set().Remove(Find(Id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public T Find(int Id)
        {
            return Set().Find(Id);
        }

        public async Task<T> Get(Expression<Func<T, bool>> filter)
        {
            return await Set().FirstOrDefaultAsync(filter);
        }

        public async Task<List<T>> List(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? await Set().ToListAsync() : await Set().Where(filter).ToListAsync();
        }

        public DbSet<T> Set()
        {
            return _db.Set<T>();
        }

        public  bool Update(T entity)
        {
            try
            {
                 Set().Update(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}