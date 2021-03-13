using App.Interfaces;
using Data.Interfaces;
using Data.Models;
using Repository.Interfaces;
using Repository.Repositories;

namespace App.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IGenericRepository<Dapper> _repository;

        public UnitOfWork(IGenericRepository<Dapper> repository)
        {
            _repository = repository;
        }
        public IDapperRepository<Dapper> dapperRepository => new DapperRepository<Dapper>(_repository);
    }
}
