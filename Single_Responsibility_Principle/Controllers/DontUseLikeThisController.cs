using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Single_Responsibility_Principle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DontUseLikeThisController : ControllerBase
    {
        private readonly IMailService _mailService;
        private readonly ISMSSender _smsSender;
        //constructor Injection
        //we are Inject the Interfaces into constructior to avopid tightly coupling between the classes.
        public DontUseLikeThisController(IMailService mailService, ISMSSender smsSender)
        {
            _mailService = mailService;
            _smsSender = smsSender;
        }
        [HttpPost]
        [Route("SendEmailToCustomers")]
        public async Task<IActionResult> SendEmailToCustomers([FromBody] MailRequest mailRequest)
        {
            //communicate to database by using customerId and get the customerdaetials.
            // Customer customer = new Customer();//old way of creating the object 
            Customer customerObj = new();//shortcut way to creating object in latest versions of c#.net. 
            //send the REQUEST TO SERVICES.
            await _mailService.SendEmailAsync(mailRequest);
            return Ok();

        }
        [HttpPost]
        [Route("SendSMSToCustomers")]
        public async Task<IActionResult> SendSMSToCustomer(string to, string message)
        {     //send the REQUEST TO SERVICES.
            await _smsSender.SendSmsAsync(to, message);
            return Ok();
        }
    }
}
