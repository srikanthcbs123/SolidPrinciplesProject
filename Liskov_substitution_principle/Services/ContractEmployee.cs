using Liskov_substitution_principle.Interface;

namespace Liskov_substitution_principle.Services
{
    public class ContractEmployee : ISalaryPayroll
    {
        public async Task<string> sal()
        {
            //get the salary of contract employee  
            return "100000";
        }
    }
}
