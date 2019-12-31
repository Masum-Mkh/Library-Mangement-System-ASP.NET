<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" AutoEventWireup="true" CodeBehind="StudentEntry.aspx.cs" Inherits="LibraryManagementASP.net.Student.StudentEntry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <fieldset>
        <legend>Student Info Entry :</legend>
        
        <div class="form-group row">
            <asp:Label ID="lbl1" AssociatedControlID="txtStuName" CssClass="control-label col-md-5 text-right" Text="Student Name :" runat="server"></asp:Label>
            <asp:TextBox ID="txtStuName" CssClass="form-control col-md-7" runat="server"></asp:TextBox>
        </div>
        
        <div class="form-group row">
            <asp:Label ID="Label1" AssociatedControlID="txtStuEnrol" CssClass="control-label col-md-5 text-right" Text="Enrollment :" runat="server"></asp:Label>
            <asp:TextBox ID="txtStuEnrol" CssClass="form-control col-md-7" runat="server"></asp:TextBox>
        </div>
        <div class="form-group row">
            <asp:Label ID="Label2" AssociatedControlID="txtStuDept" CssClass="control-label col-md-5 text-right" Text="Department :" runat="server"></asp:Label>
            <asp:TextBox ID="txtStuDept" CssClass="form-control col-md-7" runat="server"></asp:TextBox>
        </div>
        <div class="form-group row">
            <asp:Label ID="Label3" AssociatedControlID="txtStuSem" CssClass="control-label col-md-5  text-right" Text="Semester :" runat="server"></asp:Label>
            <asp:TextBox ID="txtStuSem" CssClass="form-control col-md-7" runat="server"></asp:TextBox>
        </div>
        <div class="form-group row">
            <asp:Label ID="Label4" AssociatedControlID="txtStuCon" CssClass="control-label col-md-5 text-right" Text="Contact :" runat="server"></asp:Label>
            <asp:TextBox ID="txtStuCon" CssClass="form-control col-md-7" runat="server"></asp:TextBox>
        </div>
        <div class="form-group row">
            <asp:Label ID="Label5" AssociatedControlID="txtStuEmail" CssClass="control-label col-md-5  text-right" Text="Email :" runat="server"></asp:Label>
            <asp:TextBox ID="txtStuEmail" CssClass="form-control col-md-7" runat="server"></asp:TextBox>
        </div>
        
       <%-- <div class="form-group row">
            <asp:Label ID="Label6" AssociatedControlID="DropDownList1" CssClass="control-label col-md-5  text-right" Text="Book :" runat="server"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="DropDataSource" DataTextField="Book_Name" DataValueField="Book_ID"></asp:DropDownList>
            <asp:SqlDataSource ID="DropDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:LibraryCon %>" SelectCommand="SELECT [Book_ID], [Book_Name] FROM [BooksInfoEntry]"></asp:SqlDataSource>
        </div>--%>
       
        <div class="btn-group col-md-offset-5">
            <asp:Button ID="btnSubmit" CssClass="btn btn-success"  runat="server" Text="Submit" OnClick="btnSubmit_OnClick"/>
            <button type="reset" class="btn btn-warning">Reset</button>
        </div>
    </fieldset>

</asp:Content>
