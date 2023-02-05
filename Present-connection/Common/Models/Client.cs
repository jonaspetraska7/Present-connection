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
    }
}
