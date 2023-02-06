using Common.Models;

namespace Common.Interfaces
{
    public interface ICountryApiService
    {
        public Task<List<Country>> GetCountryListAsync();
    }
}
