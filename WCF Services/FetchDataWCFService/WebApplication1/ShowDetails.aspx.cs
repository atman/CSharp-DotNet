using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
//To avoid typing the entire namespace
using WebApplication1.FetchDataWCFService;

namespace WebApplication1
{
    public partial class ShowDetails : System.Web.UI.Page
    {
        EmployeeData empInfo;
        DataOperationsServiceClient client;

        //Get data when the page loads
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.ShowFooter = true;
            client = new DataOperationsServiceClient();
            empInfo = client.GetData();

            if (!IsPostBack)
            {
                BindEmployeeDetails();
            }
            
        }

        protected void BindEmployeeDetails()
        {
            //Get Data from the Service
            empInfo = client.GetData();
            //Bind it to the GridView
            GridView1.DataSource = empInfo.EmpData;
            GridView1.DataBind();
            client.Close();
        }

        //For Different row Commands
        protected void GridView1_RowCommand(Object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("ADD"))
            {
                //Get current row details
                TextBox empId = (TextBox)GridView1.FooterRow.FindControl("txtEmpId");
                TextBox txtEditName = (TextBox)GridView1.FooterRow.FindControl("txtAddName");
                TextBox txtEditDeptNo = (TextBox)GridView1.FooterRow.FindControl("txtAddDeptNo");
                TextBox txtEditAge = (TextBox)GridView1.FooterRow.FindControl("txtAddAge");

                //Store the int values
                int intEmpId;
                int intDeptNo;
                int intAge;

                int.TryParse((empId.Text + ""), out intEmpId);
                int.TryParse((txtEditDeptNo.Text + ""), out intDeptNo);
                int.TryParse((txtEditAge.Text + ""), out intAge);

                //Create an Employee Object to store the newly added data
                Employee emp = new Employee();

                emp.EmpId = intEmpId;
                emp.EmpName = txtEditName.Text;
                emp.DeptNo = intDeptNo;
                emp.Age = intAge;

                //Send the data back to the service
                Boolean response = client.insertRow(emp);

                //Bind details to show the data
                BindEmployeeDetails();
            }

        }

        //Row Editing
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindEmployeeDetails();
        }

        //Unused right now
        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e) 
        {
    
        }

        //Delete a row
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int empId;
            //Get the id of the row to be deleted
            int.TryParse(((Label)GridView1.Rows[e.RowIndex].FindControl("lblEmpId")).Text, out empId);

            //Send the ID of the employee to be deleted
            Boolean response = client.deleteRow(getSelectedEmployee(empId).EmpId);

            //Rebind
            BindEmployeeDetails();
        }

        //While the Row is updating
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label empId = (Label)GridView1.Rows[e.RowIndex].FindControl("lblEmpId");
            TextBox txtEditName = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtEditName");
            TextBox txtEditDeptNo = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtEditDeptNo");
            TextBox txtEditAge = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtEditAge");
           
            int intEmpId;
            int intDeptNo;
            int intAge;
            
            int.TryParse((empId.Text+""), out intEmpId);
            int.TryParse((txtEditDeptNo.Text+""), out intDeptNo);
            int.TryParse((txtEditAge.Text+""), out intAge);

            Boolean response=false;
            
            //Get the employee info of the currently being edited record
            Employee emp = getSelectedEmployee(intEmpId);
            
            emp.EmpName = txtEditName.Text;
            emp.DeptNo = intDeptNo;
            emp.Age = intAge;
            
            //Call the service to update the info
            response = client.updateInfo(emp); 

            //T0 instantly display the new data and remove the current selection
            GridView1.EditIndex = -1;
            BindEmployeeDetails();
        }

        //When cancel is presse, revert to the previous view
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindEmployeeDetails();
        }

        //Get the info of the selected row
        //Used since this functionlity could be reused
        protected Employee getSelectedEmployee(int id) 
        {
            Employee foundEmp=null;
            foreach (Employee emp in empInfo.EmpData)
            {
                if (emp.EmpId == id)
                {
                    return emp;
                }
            }
            return foundEmp;
        }
    }
}