using Common.Dtos;
using Common.Enum;

namespace Common.Models
{
    public class Supplier : Person
    {
        public Supplier(string firstName, string lastName, Country country, bool isPvmPayer)
        {
            FirstName = firstName;
            LastName = lastName;
            Status = StatusEnum.Juridical;
            Country = country;
            IsPvmPayer = isPvmPayer;
        }

        public Supplier(FormDto dto, List<Country> countries)
        {
            FirstName = dto.supplierFirstName;
            LastName = dto.supplierLastName;
            Country = countries.Where(x => x.Name == dto.supplierCountry).First();
            IsPvmPayer = dto.supplierPvmStatus;
        }
    }
}
