using Common.Interfaces;
using Common.Models;

namespace Common.Services
{
    public class PvmCalculationService : IPvmCalculationService
    {
        public double CalculatePvm(double order, int pvmPercent, Client client, Supplier supplier)
        {
            double pvm = 0;

            if (supplier.IsPvmPayer != true || client.Country.Region != "Europe")
            {
                return pvm;
            }

            if(client.Country.Region == "Europe" && !client.IsPvmPayer && client.Country.Name != supplier.Country.Name)
            {
                pvm = order / 100 * pvmPercent;
            }

            if(client.Country.Region == "Europe" && client.IsPvmPayer && client.Country.Name != supplier.Country.Name)
            {
                return pvm;
            }

            if (supplier.Country.Name == client.Country.Name)
            {
                pvm = order / 100 * pvmPercent;
            }

            return pvm;
        }
    }
}
