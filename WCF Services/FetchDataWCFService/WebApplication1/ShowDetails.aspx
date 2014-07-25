<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowDetails.aspx.cs" Inherits="WebApplication1.ShowDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form style="margin:auto; width:60%" id="form1" runat="server">
    <div>
        <h1>Employee Data</h1>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"  OnRowEditing="GridView1_RowEditing" OnRowUpdated="GridView1_RowUpdated" OnRowUpdating="GridView1_RowUpdating" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit" style="text-align:center;">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField ItemStyle-Width = "30px"  HeaderText = "CustomerID">
                    <ItemTemplate>
                        <asp:Label Width="30px" ID="lblEmpID" runat="server" Text='<%# Eval("EmpId")%>'>
                        </asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtEmpID" Width = "40px" MaxLength = "5" runat="server"></asp:TextBox>
                    </FooterTemplate>       

                    <ItemStyle Width="30px"></ItemStyle>
                </asp:TemplateField>
<%--NAME OF EMPLOYEE--%>
                <asp:TemplateField ItemStyle-Width = "50px"  HeaderText = "Name">
                    <ItemTemplate>
                        <asp:Label  Width="150px" ID="lblName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"EmpName")%>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEditName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"EmpName")%>'></asp:TextBox>
                    </EditItemTemplate> 
                    <FooterTemplate>
                        <asp:TextBox ID="txtAddName" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemStyle Width="100px"></ItemStyle>
                </asp:TemplateField>
<%--DEPARTMENT--%>
                <asp:TemplateField ItemStyle-Width = "100px"  HeaderText = "Department">
                    <ItemTemplate>
                        <asp:Label ID="lblDept" runat="server"
                            Text='<%# Eval("DeptNo")%>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEditDeptNo" runat="server"
                            Text='<%# Eval("DeptNo")%>'></asp:TextBox>
                    </EditItemTemplate> 
                    <FooterTemplate>
                        <asp:TextBox ID="txtAddDeptNo" runat="server"></asp:TextBox>
                    </FooterTemplate>

                    <ItemStyle Width="150px"></ItemStyle>
                </asp:TemplateField>
<%--AGE OF EMPLOYEE --%>
                <asp:TemplateField ItemStyle-Width = "150px"  HeaderText = "Age">
                    <ItemTemplate>
                        <asp:Label ID="lblAge" runat="server"
                            Text='<%# Eval("age")%>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEditAge" runat="server"
                            Text='<%# Eval("age")%>'></asp:TextBox>
                    </EditItemTemplate> 
                    <FooterTemplate>
                        <asp:TextBox ID="txtAddAge" runat="server"></asp:TextBox>
                    </FooterTemplate>

                    <ItemStyle Width="150px"></ItemStyle>
                </asp:TemplateField>
<%-- ACTIONS --%>
                <asp:TemplateField ItemStyle-Width="100px" HeaderText="Action" FooterText="Add">
                    <FooterTemplate>
                           <asp:Button ID="lbtnAdd" runat="server" CommandName="ADD" Text="Add" Width="100px"></asp:Button>
                    </FooterTemplate>

<ItemStyle Width="100px"></ItemStyle>
                </asp:TemplateField> 

                <asp:CommandField ShowEditButton="True" ButtonType="Button" ShowDeleteButton="True" CausesValidation="False" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
