﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity: class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int? id);
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> RemoveAsync(int? id);
    }
}
