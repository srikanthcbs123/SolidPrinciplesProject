using Interface_Segregation_Principle;
using Interface_Segregation_Principle.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace TCS.EmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorLogController : ControllerBase
    {
        private readonly ErrorLogRepository _errorLogRepository;
        public ErrorLogController(ErrorLogRepository errorLogRepository)
        {
            this._errorLogRepository = errorLogRepository;
        }
        [HttpPost]
        [Route("SaveErrorDetails")]
        public async Task<IActionResult> Post([FromBody] ErrorLog errorLog)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, ModelState);
                }
                var studentData = await _errorLogRepository.DataBaseLog(errorLog);
                return StatusCode(StatusCodes.Status201Created, "Error Details Saved Succesfully");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "System or Server Error");
            }
        }
    }
}
