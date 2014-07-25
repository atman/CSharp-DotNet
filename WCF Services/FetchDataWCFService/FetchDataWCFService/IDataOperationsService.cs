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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IDataOperationsService
    {
        //All the functions offered by the service
        [OperationContract]
        EmployeeData GetData();

        [OperationContract]
        Boolean updateInfo(Employee emp);

        [OperationContract]
        Boolean deleteRow(int id);

        [OperationContract]
        Boolean insertRow(Employee emp);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    //List of Employees is stored in 'EmployeeData'
    [DataContract]
    public class EmployeeData 
    {
        [DataMember]
        public List<Employee> EmpData { get; set; }
    }

    //Employee class
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int EmpId { get; set; }
        [DataMember]
        public String EmpName {get;set;}
        [DataMember]
        public int DeptNo { get; set; }
        [DataMember]
        public int Age { get; set; }

    }
    
    //Unused
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";
   

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }

    }
}
