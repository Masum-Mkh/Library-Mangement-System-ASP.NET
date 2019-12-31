<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="LibraryManagementASP.net.Student.StudentList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/>
    
    <div class="btn-group btn-block">
        <asp:HyperLink ID="HyperLink1" CssClass="btn btn-success" NavigateUrl="StudentEntry.aspx" runat="server">Add New</asp:HyperLink>
        
        <asp:Button ID="btnUpdate" CssClass="btn btn-warning" runat="server" Text="Update" OnClick="btnUpdate_OnClick" />
        <asp:Button ID="btnDelete" CssClass="btn btn-danger" runat="server" Text="Delete" OnClick="btnDelete_OnClick" />
        <asp:Button ID="btnReports" CssClass="btn btn-info"  Text="Report" OnClick="btnReports_OnClick" runat="server"/> 
    </div>
    
    <br/>
    
    <hr/>

    <div class="table-responsive">

    
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" CssClass="table table-responsive table-condensed" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="Student_ID" DataSourceID="SqlDataSource1" GridLines="Horizontal" AllowPaging="True">
        <Columns>
            <asp:CommandField ShowSelectButton="True" ButtonType="Button" />
            <asp:BoundField DataField="Student_ID" HeaderText="Student_ID" InsertVisible="False" ReadOnly="True" SortExpression="Student_ID" />
            <asp:BoundField DataField="Student_Name" HeaderText="Student_Name" SortExpression="Student_Name" />
            <asp:BoundField DataField="Enrollment_No" HeaderText="Enrollment_No" SortExpression="Enrollment_No" />
            <asp:BoundField DataField="Department" HeaderText="Department" SortExpression="Department" />
            <asp:BoundField DataField="Student_Semester" HeaderText="Student_Semester" SortExpression="Student_Semester" />
            <asp:BoundField DataField="Student_Contact" HeaderText="Student_Contact" SortExpression="Student_Contact" />
            <asp:BoundField DataField="Student_Email" HeaderText="Student_Email" SortExpression="Student_Email" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />
    </asp:GridView>
    </div>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:LibraryCon %>" SelectCommand="SELECT [Student_ID], [Student_Name], [Enrollment_No], [Department], [Student_Semester], [Student_Contact], [Student_Email] FROM [StudentInfoEntry]"></asp:SqlDataSource>
    
    

    <br />
        
    

</asp:Content>
