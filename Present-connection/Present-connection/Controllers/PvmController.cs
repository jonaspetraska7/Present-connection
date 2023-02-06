using Common.Dtos;
using Common.Interfaces;
using Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace Present_connection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PvmController : ControllerBase
    {
        private readonly IPvmCalculationService _pvmCalculationService;
        private readonly ICountryApiService _countryApiService;

        public PvmController(IPvmCalculationService pvmCalculationService, ICountryApiService countryApiService)
        {
            _countryApiService = countryApiService;
            _pvmCalculationService = pvmCalculationService;
        }

        [HttpPost("GetInvoice")]
        public async Task<FormDto> GetInvoiceAsync([FromBody] FormDto data)
        {
            var countries = await _countryApiService.GetCountryListAsync();
            var client = new Client(data, countries);
            var supplier = new Supplier(data, countries);

            data.pvm = _pvmCalculationService.CalculatePvm(data.order, data.pvmPercent, client, supplier);
            data.total = data.order + data.pvm;

            return data;
        }

        [HttpGet("GetCountries")]
        public async Task<List<string>> GetCountriesAsync()
        {
            var countries = await _countryApiService.GetCountryListAsync();
            return countries.Select(x => x.Name).ToList();
        }
    }
}