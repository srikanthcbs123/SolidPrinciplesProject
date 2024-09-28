namespace Interface_Segregation_Principle.Interfaces
{
    public interface IDataBaseLog
    {
        Task<string> DataBaseLog(ErrorLog errorLog);
    }
}
