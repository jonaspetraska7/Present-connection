using Common.Enum;

namespace Common.Models
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public StatusEnum Status { get; set; }
        public Country Country { get; set; }
        public bool IsPvmPayer { get; set; }
    }
}
