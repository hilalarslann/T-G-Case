using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniETrade.Core
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T?> Get(Expression<Func<T, bool>> filter);
        Task<List<T>> List(Expression<Func<T, bool>> filter = null);
        T Find(int Id);
        Task<T> AddAsync(T entity);
        bool AddRange(List<T> entities);
        bool Update(T entity);
        bool Delete(int Id);
        DbSet<T> Set();
    }
}
