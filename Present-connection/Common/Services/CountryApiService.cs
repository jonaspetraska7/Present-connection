using Common.Interfaces;
using Common.Models;
using Newtonsoft.Json.Linq;

namespace Common.Services
{
    public class CountryApiService : ICountryApiService
    {
        public async Task<List<Country>> GetCountryListAsync()
        {
            var countryList = new List<Country>();

            using var client = new HttpClient();

            var response = await client.GetAsync("https://api.first.org/data/v1/countries");
            var json = await response.Content.ReadAsStringAsync();
            var result = JObject.Parse(json)["data"];
            var countryCodes = result?.Children();

            foreach (var code in countryCodes)
            {
                countryList.Add(new Country() { Name = code.First["country"].ToString(), Region = code.First["region"].ToString() });
            }

            return countryList;
        }
    }
}
