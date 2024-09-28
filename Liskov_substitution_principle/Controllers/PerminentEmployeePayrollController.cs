using Liskov_substitution_principle.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Liskov_substitution_principle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerminentEmployeePayrollController : ControllerBase
    {
        private readonly IEmployeepayroll _employeePayroll;
        public PerminentEmployeePayrollController(IEmployeepayroll employeePayroll)
        {
            this._employeePayroll = employeePayroll;   
        }
        [HttpGet]
        [Route("PerminentEmployeePayroll")]
        public async Task<IActionResult> EmployeePayroll()
        {
            //For Perminent employee we can get the bonus and sal information like below.
            var Bonusresult = await this._employeePayroll.Bonus();
            var Salaryresult = await this._employeePayroll.Sal();
            return Ok();
        }
    }
}
