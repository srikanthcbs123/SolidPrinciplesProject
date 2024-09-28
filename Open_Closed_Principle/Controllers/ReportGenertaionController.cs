using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Open_Closed_Principle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportGenertaionController : ControllerBase
    {
        private readonly IReportGeneration _reportGenertion;
        public ReportGenertaionController(IReportGeneration reportGenertion)
        {
            _reportGenertion=reportGenertion;
        }
        [HttpPost]
        [Route("GenerteReportsByType")]
        public async Task<IActionResult> GenerteReport(string FileType)
        {
            //dummy data creation of customer.
            List<Customer> lstObj = new();
            Customer obj = new Customer();
            obj.CustomerName = "test";
            obj.CustomerEmail = "sample@gmail.com";
            obj.CustomerMobile = "1234567890";
            obj.CustomerId = 1234567;
            lstObj.Add(obj);
            var result = await this._reportGenertion.GeneralReport(lstObj, FileType);
            //Fallow the below way to call the respective report type
            //this is the way we can achieve the openclosed priniciple.
            if(FileType  == "csv")
            {
                var csvresult = await this._reportGenertion.GeneralReport(lstObj, FileType);
            }
            else if(FileType == "pdf")
            {
                var pdfresult = await this._reportGenertion.GeneralReport(lstObj, FileType);
            }
            else if(FileType == "excel")
            {
                var Excelresult = await this._reportGenertion.GeneralReport(lstObj, FileType);
            }
            else if (FileType == "Crystal")
            {
                var Excelresult = await this._reportGenertion.GeneralReport(lstObj, FileType);
            }
            return Ok();
        }
    }
}
