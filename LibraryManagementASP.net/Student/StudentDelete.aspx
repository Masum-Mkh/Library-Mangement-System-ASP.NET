<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" AutoEventWireup="true" CodeBehind="StudentDelete.aspx.cs" Inherits="LibraryManagementASP.net.Student.StudentDelete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
     <fieldset>
        <legend>Student Info Delete :</legend>
        
         <asp:HiddenField ID="txtStuID" runat="server" />
         <asp:Label ID="lblMessage"  CssClass="control-label text-info " Text="" runat="server"></asp:Label>
      
       
        <div class=" ">
            <asp:Button ID="btnDelete" CssClass="btn btn-danger"  runat="server" Text="Delete" OnClick="btnSubmit_OnClick"/>
            <asp:Button ID="btnCancel" CssClass="btn btn-warning" runat="server" Text="Cancel" />
        </div>
    </fieldset>

</asp:Content>
