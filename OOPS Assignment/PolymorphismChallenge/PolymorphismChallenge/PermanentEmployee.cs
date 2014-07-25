using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismChallenge
{
    class PermanentEmployee: Employee
    {
        public override int GetEmployeeSalary(Employee perEmp)
        {
            Console.WriteLine("Employee Type: "+ perEmp.GetType());
            return (perEmp.GetConsideredHours(perEmp) * perEmp.CompensationRatePerHour) - perEmp.DeductionAmount;
        }

        public override int GetConsideredHours(Employee perEmp)
        {
            int maxHrsAllowedForPermanentEmployees = perEmp.DaysofAttendance * 8;
            if (perEmp.TotalHoursOfWork < maxHrsAllowedForPermanentEmployees)
            {
                return perEmp.TotalHoursOfWork;
            }
            else
            {
                return maxHrsAllowedForPermanentEmployees;
            }
        }
    }
}
