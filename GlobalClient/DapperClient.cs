using Contracts.Dtos;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

namespace GlobalClient
{
    public partial class ApiClient
    {
        public async Task<IEnumerable<DapperDto>> GetDapperList()
        {
            var requestUrl = CreateRequestUri(string.Format(CultureInfo.InvariantCulture, "Dapper/DapperList"));
            return await GetAsync<IEnumerable<DapperDto>>(requestUrl).ConfigureAwait(false);
        }

        public async Task<BaseResult<DapperDto>> InsertDapper(DapperDto dapperDto)
        {
            var requestUrl = CreateRequestUri(string.Format(CultureInfo.InvariantCulture, "Dapper/DapperList"));
            return await PostAsync<DapperDto>(requestUrl, dapperDto).ConfigureAwait(false);
        }
    }
}
