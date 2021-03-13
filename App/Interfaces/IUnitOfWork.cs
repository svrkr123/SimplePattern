using Data.Models;
using Repository.Interfaces;

namespace App.Interfaces
{
    public interface IUnitOfWork
    {
        IDapperRepository<Dapper> dapperRepository { get; }
    }
}
