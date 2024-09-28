using Liskov_substitution_principle.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Liskov_substitution_principle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractEmployeePayrollController : ControllerBase
    {
        private readonly ISalaryPayroll _salaryPayroll;
        public ContractEmployeePayrollController(ISalaryPayroll salaryPayroll)
        {
                _salaryPayroll= salaryPayroll;
        }

        [HttpGet]
        [Route("ContractEmployeePayroll")]
        public async Task<IActionResult> EmployeePayroll()
        {
            //For Contract employee we can get the  sal information like below.
            //For Contract employee we don't have bonus.
            var Salaryresult =this._salaryPayroll.sal();
            return Ok();
        }
    }
}
