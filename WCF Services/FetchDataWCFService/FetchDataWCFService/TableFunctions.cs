using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace FetchDataWCFService
{
    //Handles all the database operations
    public class TableFunctions
    {
        SqlConnection conn;
        //Create Connection to the Database
        public void establishConnection()
        {
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = @"Initial Catalog=Training2014; user=freshers2014; Password=ivp@123; Data Source=192.168.0.61\poc08j";
                conn.Open();
                Console.WriteLine("Connection Established! ");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while Connecting... " + e);
            }
        }

        //Close Connection to the Database
        public void closeConnection()
        {
            try
            {
                conn.Close();
                Console.WriteLine("Connection Closed! ");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while Closing... " + e);
            }
        }
        //Update data
        public void updateTable(int empId, String empName, int empDeptNo, int empAge)
        {
            try
            {
                //Assign Stored Proc to be executed
                SqlCommand commandUpdate = new SqlCommand("updateData", conn);

                //Add Parameters
                commandUpdate.Parameters.AddWithValue("@empId", empId);
                commandUpdate.Parameters.AddWithValue("@empName", empName);
                commandUpdate.Parameters.AddWithValue("@departmentNo", empDeptNo);
                commandUpdate.Parameters.AddWithValue("@age", empAge);

                //Assign the command type and execute
                commandUpdate.CommandType = CommandType.StoredProcedure;
                commandUpdate.ExecuteNonQuery();
            }
            catch (Exception e)
            { 
                Console.WriteLine("Error while Updating... " + e);
            }
        }
        //Add new Record of Employee
        public void insertRecord(int empId, String empName, int empDeptNo, int empAge)
        {
            try
            {
                //Assign Stored Proc to be executed
                SqlCommand commandInsert = new SqlCommand("insertData", conn);

                //Add Parameters
                commandInsert.Parameters.AddWithValue("@empId", empId);
                commandInsert.Parameters.AddWithValue("@empName", empName);
                commandInsert.Parameters.AddWithValue("@departmentNo", empDeptNo);
                commandInsert.Parameters.AddWithValue("@age", empAge);

                //Assign the command type and execute
                commandInsert.CommandType = CommandType.StoredProcedure;
                commandInsert.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while Adding... " + e);
                throw;
            }
        }

        //Delete Record
        public void deleteRecord(int empId)
        {
            try
            {
                //Assign Stored Proc to be executed
                SqlCommand commandDelete = new SqlCommand("deleteRecord", conn);

                //Add Parameters
                commandDelete.Parameters.AddWithValue("@empId", empId);

                //Assign the command type and execute
                commandDelete.CommandType = CommandType.StoredProcedure;
                commandDelete.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while Adding... " + e);
                throw;
            }
        }

        //Get Data From the Database in the form of a Dataset
        public DataTable getData(String tableName)
        {
            //Declarations
            SqlDataAdapter adapter = null;
            DataTable dt = null;
            try
            {
                //Assign query
                adapter = new SqlDataAdapter("select * FROM " + tableName, conn);
                SqlCommandBuilder cmdBldr = new SqlCommandBuilder(adapter);

                DataSet ds = new DataSet();
                String tempTable = tableName + "Temp";

                //Adapter fills the dataset and the table is named tempTable
                adapter.Fill(ds, tempTable);
                //Store tempTable in dt, since ds can have multiple tables
                dt = ds.Tables[tempTable];

            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR : " + e);
                Console.ReadKey();
            }
            //Return the datatable
            return dt;
        }
    }
}