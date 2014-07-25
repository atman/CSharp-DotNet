using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismChallenge
{
    class Employee
    {
        protected int employeeId;
        protected String employeeName;
        protected int daysOfAttendance;
        protected int totalHoursOfWork;
        protected int compensationRatePerHour;
        protected int deductionAmount;

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int DaysofAttendance { get; set; }
        public int TotalHoursOfWork { get; set; }
        public int CompensationRatePerHour { get; set; }
        public int DeductionAmount { get; set; }

        public virtual int GetEmployeeSalary(Employee emp)
        {
            Console.WriteLine("INSIDE emp getSalary");
            return 0;
        }
        public virtual int GetConsideredHours(Employee emp) 
        {
            Console.WriteLine("INSIDE emp hours");
            return 0;
        }
    }
}
