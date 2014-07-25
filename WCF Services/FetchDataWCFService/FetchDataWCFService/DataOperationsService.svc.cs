using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace FetchDataWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
  
    public class DataOperationsService : IDataOperationsService
    {
        TableFunctions tf = new TableFunctions(); 
        
        //Service fetches the Data
        public EmployeeData GetData()
        {
            tf.establishConnection();

            Employee emp = new Employee();
            List<Employee> employees = new List<Employee>(); 
            
            DataTable dt  = tf.getData("atman50");

            //Take all the records from dt and add it to the Employees List
            foreach (DataRow row in dt.Rows)
            {
                //Display data row
                emp = new Employee();
                emp.EmpId = (int)row["empId"];
                emp.EmpName = (String)row["empName"]; 
                emp.DeptNo = (int)row["departmentNo"];
                emp.Age = (int)row["age"];

                employees.Add(emp);
            }

            //'EmployeeData' stores the List of employees as a member 'EmpData'
            EmployeeData empData = new EmployeeData();
            empData.EmpData = employees;

            //Close database Connection
            tf.closeConnection();

            //Return the employee data to the client
            return empData ;
        }

        //Update info service func.
        public Boolean updateInfo(Employee emp)
        {
            tf.establishConnection();
            tf.updateTable(emp.EmpId, emp.EmpName, emp.DeptNo, emp.Age);
            tf.closeConnection();

            return true;
        }

        //Insert new info service func.
        public Boolean insertRow(Employee emp) 
        {
            tf.establishConnection();
            tf.insertRecord(emp.EmpId, emp.EmpName, emp.DeptNo, emp.Age);
            tf.closeConnection();

            return true;
        }

        //Delete info service func.
        public Boolean deleteRow(int empId)
        {
            tf.establishConnection();
            tf.deleteRecord(empId);
            tf.closeConnection();

            return true;
        }

        //Unused
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
