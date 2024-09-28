namespace Single_Responsibility_Principle
{
    public interface ISMSSender
    {
        Task<bool> SendSmsAsync(string to, string message);
    }
}
