
namespace Open_Closed_Principle.Services
{
    public class CSVReportGeneration : IReportGeneration
    {
        //Here we are writing the logic for only csv report genertion
        public async Task<string> GeneralReport(List<Customer> lstCustomer, string Reporttype)
        {
            //write a logic for generting the CSV report.

            return "CSV Report Is Generted successfully";
        }
    }
}
