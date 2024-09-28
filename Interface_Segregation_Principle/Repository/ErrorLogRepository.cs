using Interface_Segregation_Principle.Interfaces;
using System.Data;
using System.Data.SqlClient;
namespace Interface_Segregation_Principle.Repository
{
    public class ErrorLogRepository : IDataBaseLog, INetworkLog, IProjectLog
    {
        string connectionString = "data source=DESKTOP-N6885P9; integrated security=yes; initial catalog=StudentManagement";
        public async Task<string> DataBaseLog(ErrorLog errorLog)
        {
            //Here you can write the logic as per your requirment
            //Example purpose i am logging the error in database
            //For that purpose we are using ado.net logic for save the error in database.
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("USP_ErrorLog_Text", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_ErrorDesc", errorLog.ErrorDesc);
                cmd.Parameters.AddWithValue("@p_ErrorMessage", errorLog.ErrorMessage);
                cmd.Parameters.AddWithValue("@p_Severity", "High");
                cmd.Parameters.AddWithValue("@p_MethodName", errorLog.MethodName);
                cmd.Parameters.AddWithValue("@p_Reference", errorLog.QueryString);
                cmd.Parameters.AddWithValue("@p_Host", errorLog.Host);
                cmd.Parameters.AddWithValue("@p_Controller", errorLog.Controller);
                cmd.Parameters.AddWithValue("@p_StackTrace", errorLog.StackTrace);
                cmd.Parameters.AddWithValue("@p_UserId", errorLog.CreatedBy);

                con.Open();
                await cmd.ExecuteNonQueryAsync();
                con.Close();
            }
            return "Error Information is saved in databse.";
        }

        public Task<string> NetworkLog(ErrorLog errorLog)
        {
            //write the logic to log the errors in Network folder.
            File.Create(@"E:\myclass examples&notes\SolidPrinciplesProject\Interface_Segregation_Principle\ProjectLevelErrorLogs\file1.txt").Close();
            Console.WriteLine("File created");
            return "Error is logged successfully";
        }

        public Task<string> ProjectLog(ErrorLog errorLog)
        {
            //write the logic to log the errors in ProjectLevel folder.
            return "Error is logged successfully";
        }
    }
}
