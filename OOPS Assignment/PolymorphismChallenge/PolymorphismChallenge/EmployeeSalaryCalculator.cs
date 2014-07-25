using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismChallenge
{
    class EmployeeSalaryCalculator
    {
        //Calculates Salary for each Employee
        public void calculateSalaryOfEmployee(List <Employee> employee)
        {
            int salary;
            foreach (var emp in employee)
            {
                //Depending on the type of employee obj, the corresponding method is called at runtime
                salary = emp.GetEmployeeSalary(emp);
                Console.WriteLine("Salary of " + emp.EmployeeName + " is : " + salary);
            }
        }
    }
}
