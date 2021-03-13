using Data.Interfaces;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class DapperRepository<TEntity> : IDapperRepository<TEntity> where TEntity : class
    {
        private readonly IGenericRepository<TEntity> _repository;

        public DapperRepository(IGenericRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            var response = await _repository.AddAsync(entity).ConfigureAwait(false);
            return response;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var response = await _repository.GetAllAsync().ConfigureAwait(false);
            return response;
        }

        public async Task<TEntity> GetByIdAsync(int? id)
        {
            var response = await _repository.GetByIdAsync(id).ConfigureAwait(false);
            return response;
        }

        public async Task<TEntity> RemoveAsync(int? id)
        {
            var response = await _repository.RemoveAsync(id).ConfigureAwait(false);
            return response;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var response = await _repository.UpdateAsync(entity).ConfigureAwait(false);
            return response;
        }
    }
}
