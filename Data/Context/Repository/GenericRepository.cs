using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly MainContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(MainContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync().ConfigureAwait(false);
            return entity;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync().ConfigureAwait(false);
        }

        public async Task<TEntity> GetByIdAsync(int? id)
        {
            return await _dbSet.FindAsync(id).ConfigureAwait(false);
        }

        public async Task<TEntity> RemoveAsync(int? id)
        {
            var data = await _dbSet.FindAsync(id).ConfigureAwait(false);
            _dbSet.Remove(data);
            await _context.SaveChangesAsync().ConfigureAwait(false);
            return data;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync().ConfigureAwait(false);
            return entity;
        }
    }
}
