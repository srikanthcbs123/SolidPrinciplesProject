using MailKit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Ocsp;

namespace Single_Responsibility_Principle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailCommunicationController : ControllerBase
    {
        //if you create object and accessing the methods In mailservice class
        //we called this as tightly coupled between the classes.
        //===========
        // MailService obj=new MailService()
        private readonly IMailService _mailService;
        //constructor Injection
        //we are Inject the Interfaces into constructior to avopid tightly coupling between the classes.
        public EmailCommunicationController(IMailService mailService)
        {
            _mailService = mailService;
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
    }
}
