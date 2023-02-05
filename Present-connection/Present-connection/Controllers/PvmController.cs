using Common.Dtos;
using Common.Models;
using Common.Services;
using Microsoft.AspNetCore.Mvc;

namespace Present_connection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PvmController : ControllerBase
    {

        [HttpPost]
        public async Task<int> GetPvmAsync([FromBody] FormDto data)
        {
            var countries = await CountryApiService.GetCountryListAsync();
            var clientCountry = countries.Where(x => x.Name == data.clientCountry);

            //var client = new Client(data.clientFirstName, data.clientLastName, data.clientStatus,)
            //var pvm = PvmCalculationService.CalculatePvm(data.order, data.pvmPercent)
            return 0;
        }

        [HttpGet]
        public async Task<List<string>> GetCountriesAsync()
        {
            var countries = await CountryApiService.GetCountryListAsync();
            return countries.Select(x => x.Name).ToList();
        }
    }
}