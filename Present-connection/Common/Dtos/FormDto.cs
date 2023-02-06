namespace Common.Dtos
{
    public class FormDto
    {
        public string clientFirstName { get; set; }
        public string clientLastName { get; set; }
        public string clientStatus { get; set; }
        public string clientCountry { get; set; }
        public bool clientPvmStatus { get; set; }
        public string supplierFirstName { get; set; }
        public string supplierLastName { get; set; }
        public string supplierCountry { get; set; }
        public bool supplierPvmStatus { get; set; }
        public double order { get; set; }
        public int pvmPercent { get; set; }
        public double pvm { get; set; }
        public double total { get; set; }
    }
}
