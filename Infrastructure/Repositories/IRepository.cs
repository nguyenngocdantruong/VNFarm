using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VNFarm.Infrastructure.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<T?> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
        Task<T> Add(T entity);
        Task<bool> Update(T entity);
        Task<T?> Delete(int id);
        Task<int> Count();
        Task<bool> Any(Expression<Func<T, bool>> predicate);
        Task<T?> First(Expression<Func<T, bool>> predicate);
        Task<int> Save();
    }
}
