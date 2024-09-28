
namespace Open_Closed_Principle.Services
{
    public class CrystalReportGenertion : IReportGeneration
    {
      //Here we are writing the logic for only Crystal report genertion
        public async Task<string> GeneralReport(List<Customer> lstCustomer, string Reporttype)
        {
            //write a logic for generting the Crystal report.

            return "Crystal Report Is Generted successfully";
        }
    }
}
