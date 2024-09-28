namespace Interface_Segregation_Principle.Interfaces
{
    public interface INetworkLog
    {
        Task<string> NetworkLog(ErrorLog errorLog);
    }
}
