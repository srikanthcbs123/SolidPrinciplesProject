
namespace Open_Closed_Principle.Services
{
    public class PDFReportGenertion : IReportGeneration
    {
        //Here we are writing the logic for only PDF report genertion
        public async Task<string> GeneralReport(List<Customer> lstCustomer, string Reporttype)
        {
            //write a logic for generting the pdf report.

            return "PDF Report Is Generted successfully";
        }
    }
}
