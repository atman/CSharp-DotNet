using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Collections
{
    public class EmployeeList
    {
        private List<Employee> _employeeList = new List<Employee>();

        public EmployeeList()
        {
            FillEmployees();
        }

        private void FillEmployees()
        {
            //TODO: Write code to create and add employees in _employeeList collection.

        }

        //Decide the return type in each case below and also implement the below functions along with the 
        //calling code.

        //CASE 1: The calling users needs to enumerate the collection and read all the employee instances.
        //public <return type> GetEmployees1() { return _employeeList; }

        //CASE 2: The calling users need to take count of the entire collection.
        //public <return type> GetEmployees2() { return _employeeList; }

        //CASE 3: The calling users need to add a record to the collection.
        //public <return type> GetEmployees3() { return _employeeList; }



    }
}
