using Common.Models;

namespace Common.Interfaces
{
    public interface IPvmCalculationService
    {
        public double CalculatePvm(double order, int pvmPercent, Client client, Supplier supplier);
    }
}
