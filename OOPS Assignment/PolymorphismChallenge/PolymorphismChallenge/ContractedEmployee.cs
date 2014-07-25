using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismChallenge
{
    class ContractedEmployee: Employee
    {
        public override int GetEmployeeSalary(Employee emp)
        {
            Console.WriteLine("Employee Type: " + emp.GetType());
            return (emp.GetConsideredHours(emp) * emp.CompensationRatePerHour) - emp.DeductionAmount;
        }

        public override int GetConsideredHours(Employee emp)
        {
            return emp.TotalHoursOfWork;
        }
    }
}
