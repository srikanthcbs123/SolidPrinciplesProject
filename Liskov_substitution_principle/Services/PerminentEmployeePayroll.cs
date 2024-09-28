using Liskov_substitution_principle.Interface;

namespace Liskov_substitution_principle.Services
{
    //If you wan you can inherit the respective intefaces if you know the logic
    public class PerminentEmployeePayroll :ISalaryPayroll,IBonusPayroll
    {
        public async Task<string> Bonus()
        {
            //Get the Bonus  information database of employee  and return it.
            return "10000";
        }

        public async Task<string> sal()
        {
            //Get the sal information database of employee  and return it.
            return "1000";
        }
    }
}
