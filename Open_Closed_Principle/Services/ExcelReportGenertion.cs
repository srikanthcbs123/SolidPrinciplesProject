
namespace Open_Closed_Principle.Services
{
    public class ExcelReportGenertion : IReportGeneration
    {
        //Here we are writing the logic for only Excel report genertion
        public async  Task<string> GeneralReport(List<Customer> lstCustomer, string Reporttype)
        {
            //write a logic for generting the Excel report.

            return "Excel Report Is Generted successfully";
        }
    }
}
