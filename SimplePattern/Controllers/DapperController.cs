using App.Interfaces;
using AutoMapper;
using Contracts.Dtos;
using Contracts.Interfaces;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimplePattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DapperController : ControllerBase
    {
        //private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly IDapperService<DapperDto> _dapperService;

        public DapperController(IMapper mapper, IDapperService<DapperDto> dapperService)
        {
            //_uow = uow;
            _mapper = mapper;
            _dapperService = dapperService;
        }

        [HttpGet]
        [Route("DapperList")]
        public async Task<IActionResult> GetAllAsync()
        {
            // var result = _mapper.Map<IEnumerable<DapperDto>>(await _uow.dapperRepository.GetAllAsync().ConfigureAwait(false)); 
            var result = await _dapperService.GetAllAsync().ConfigureAwait(false);
            return Ok(result);
        }

        [HttpGet]
        [Route("Dapper/{id}")]
        public async Task<IActionResult> GetByIdAsync(int? id)
        {
            //var result = await _uow.dapperRepository.GetByIdAsync(id).ConfigureAwait(false);
            var result = await _dapperService.GetByIdAsync(id).ConfigureAwait(false);
            return Ok(result);
        }

        [HttpPost]
        [Route("Dapper")]
        public async Task<IActionResult> AddAsync(DapperDto dto)
        {
           // var result = await _uow.dapperRepository.AddAsync(dapper).ConfigureAwait(false);
            var result = await _dapperService.AddAsync(dto).ConfigureAwait(false);
            return Ok(result);
        }

        [HttpPut]
        [Route("Dapper")]
        public async Task<IActionResult> UpdateAsync(DapperDto dto)
        {
            // var result = await _uow.dapperRepository.AddAsync(dapper).ConfigureAwait(false);
            var result = await _dapperService.UpdateAsync(dto).ConfigureAwait(false);
            return Ok(result);
        }

        [HttpDelete]
        [Route("Dapper/{id}")]
        public async Task<IActionResult> RemoveAsync(int? id)
        {
            var result = await _dapperService.RemoveAsync(id).ConfigureAwait(false);
            return Ok(result);
        }
    }
}
