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
    }
}
