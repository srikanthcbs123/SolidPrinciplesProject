namespace Single_Responsibility_Principle
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);//method heading or method signature
    }//there is no body for abstract methods.
}
