using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class MainContext: DbContext
    {
        public MainContext(DbContextOptions<MainContext> options): base(options)
        {

        }

        public DbSet<Dapper> dappers { get; set; }
    }
}
