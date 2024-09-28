
namespace Open_Closed_Principle.Services
{
    public class ReportGenerationService: IReportGeneration
    {

        public ReportGenerationService() 
        {

        }
        //Don't write the logic as below to generte the reports based on ReportType.
        public async Task<string> GeneralReport(List<Customer> lstCustomer, string Reporttype)
        {
            //Don't write like this ....
            if (Reporttype =="csv")
            {
                //Write a Logic to generte the csv report
            }
            else if(Reporttype =="pdf")
            {
                //write a Logic to generte the pdf report
            }
            else if (Reporttype == "xlsx")
            {
                //write a Logic to generte the pdf report
            }
            else if(Reporttype == "CrystalRport")
            {
                //write a Logic to generte the CrystalRport report
            }
            //-------may in feature one  or more report types will come.
            //----If you create like this way you are violating the open closed prinicple..
            return "";
        }
    }
}
