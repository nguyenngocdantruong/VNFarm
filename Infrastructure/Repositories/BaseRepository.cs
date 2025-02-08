using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VNFarm.Infrastructure.Repositories
{
    internal abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbs;
        public BaseRepository(DbContext context)
        {
            _context = context;
            _dbs = context.Set<T>();
        }

        public async Task<T> Add(T entity)
        {
            await _dbs.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> Any(Expression<Func<T, bool>> predicate)
        {
            return await _dbs.AnyAsync(predicate);
        }

        public async Task<int> Count()
        {
            return await _dbs.CountAsync();
        }

        public async Task<T?> Delete(int id)
        {
            var entity = await _dbs.FindAsync(id);
            if(entity != null)
            {
                _dbs.Remove(entity);
                await _context.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            return await _dbs.AsNoTracking().Where(predicate).ToListAsync();
        }

        public async Task<T?> First(Expression<Func<T, bool>> predicate)
        {
            return await _dbs.FirstOrDefaultAsync(predicate);
        }

        public async Task<T?> Get(int id)
        {
            var entity = await _dbs.FindAsync(id);
            return entity;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbs.AsNoTracking().ToListAsync();
        }

        public virtual async Task<bool> Update(T entity)
        {
            _dbs.Update(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
