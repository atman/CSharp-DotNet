using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee perEmp = new PermanentEmployee();
            Employee conEmp = new ContractedEmployee();

            //Initilizing values for the employees
            perEmp.EmployeeId = 1;
            perEmp.EmployeeName = "Atman";
            perEmp.DaysofAttendance = 21;
            perEmp.DeductionAmount = 0;
            perEmp.CompensationRatePerHour = 25;
            perEmp.TotalHoursOfWork = 100;

            conEmp.EmployeeId = 2;
            conEmp.EmployeeName = "Batman";
            conEmp.DeductionAmount = 1200;
            conEmp.DaysofAttendance = 17;
            conEmp.CompensationRatePerHour = 28;
            conEmp.TotalHoursOfWork = 145;

            //Create and Add to list
            List<Employee> payRollList = new List<Employee>();
            payRollList.Add(perEmp);
            payRollList.Add(conEmp);

            EmployeeSalaryCalculator empSalCalc = new EmployeeSalaryCalculator();
            empSalCalc.calculateSalaryOfEmployee(payRollList);

            Console.ReadKey();
        }
    }
}
