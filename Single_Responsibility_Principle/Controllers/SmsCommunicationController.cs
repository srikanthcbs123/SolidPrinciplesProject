using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Single_Responsibility_Principle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmsCommunicationController : ControllerBase
    {
        private readonly ISMSSender _smsService;
        public SmsCommunicationController(ISMSSender smsService)
        {
            _smsService = smsService;
        }
        [HttpPost]
        [Route("SendSMSToCustomers")]
        public async Task<IActionResult> SendSMSToCustomer(string to, string message)
        {
            await _smsService.SendSmsAsync(to, message);
            return Ok();
        }
    }
}
