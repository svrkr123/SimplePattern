using App.Interfaces;
using AutoMapper;
using Contracts.Dtos;
using Contracts.Interfaces;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public class DapperService: IDapperService<DapperDto>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public DapperService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<DapperDto> AddAsync(DapperDto dto)
        {
            var response = await _uow.dapperRepository.AddAsync(_mapper.Map<Dapper>(dto)).ConfigureAwait(false);
            return _mapper.Map<DapperDto>(response);
        }

        public async Task<IEnumerable<DapperDto>> GetAllAsync()
        {
            var response = _mapper.Map<IEnumerable<DapperDto>>(await _uow.dapperRepository.GetAllAsync().ConfigureAwait(false));
            return response;
        }

        public async Task<DapperDto> GetByIdAsync(int? id)
        {
            var response = await _uow.dapperRepository.GetByIdAsync(id).ConfigureAwait(false);
            return _mapper.Map<DapperDto>(response);
        }

        public async Task<DapperDto> RemoveAsync(int? id)
        {
            var response = await _uow.dapperRepository.RemoveAsync(id).ConfigureAwait(false);
            return _mapper.Map<DapperDto>(response);
        }

        public async Task<DapperDto> UpdateAsync(DapperDto dto)
        {
            var response = await _uow.dapperRepository.UpdateAsync(_mapper.Map<Dapper>(dto)).ConfigureAwait(false);
            return _mapper.Map<DapperDto>(response);
        }
    }
}
