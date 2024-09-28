namespace Interface_Segregation_Principle.Interfaces
{
    public interface IProjectLog
    {
        Task<string> ProjectLog(ErrorLog errorLog);
    }
}
