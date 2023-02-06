using Common.Dtos;
using Common.Enum;

namespace Common.Models
{
    public class Client : Person
    {
        public Client(string firstName, string lastName, StatusEnum status, Country country, bool isPvmPayer)
        {
            FirstName = firstName;
            LastName = lastName;
            Status = status;
            Country = country;
            IsPvmPayer = isPvmPayer;
        }

        public Client(FormDto dto, List<Country> countries)
        {
            FirstName = dto.clientFirstName;
            LastName = dto.clientLastName;
            Status = dto.clientStatus == StatusEnum.Physical.ToString() ? StatusEnum.Physical : StatusEnum.Juridical;
            Country = countries.Where(x => x.Name == dto.clientCountry).First();
            IsPvmPayer = dto.clientPvmStatus;
        }
    }
}
