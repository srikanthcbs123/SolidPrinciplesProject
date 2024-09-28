using System.Data;

namespace Open_Closed_Principle
{
    public interface IReportGeneration
    {
        public Task<string> GeneralReport(List<Customer> lstCustomer, string Reporttype);
    }
}
