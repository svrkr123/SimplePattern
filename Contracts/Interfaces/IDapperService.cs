using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts.Interfaces
{
    public interface IDapperService<TDto> where TDto: class
    {
        Task<IEnumerable<TDto>> GetAllAsync();
        Task<TDto> GetByIdAsync(int? id);
        Task<TDto> AddAsync(TDto dto);
        Task<TDto> UpdateAsync(TDto dto);
        Task<TDto> RemoveAsync(int? id);
    }
}
