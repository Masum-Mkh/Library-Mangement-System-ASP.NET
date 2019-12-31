<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" AutoEventWireup="true" CodeBehind="BookEdit.aspx.cs" Inherits="LibraryManagementASP.net.Book.BookEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    
    <fieldset>
        <legend>Book Info Update :</legend>
    </fieldset>
    
    <asp:HiddenField ID="bookID" runat="server" />
     
    <div class="form-group row">
        <asp:Label ID="lblBkName" AssociatedControlID="txtbkName" CssClass="control-label col-md-5 text-right" Text="Book Name :" runat="server"></asp:Label>
        <span class="col-md-7 ">
            <asp:TextBox ID="txtbkName" CssClass="form-control " runat="server"></asp:TextBox>
        </span>
    </div>
    
    <div class="form-group row">
        <asp:Label ID="lblAuthor" AssociatedControlID="txtbkAuthor" CssClass="control-label col-md-5 text-right" Text="Author Name :" runat="server"></asp:Label>
        <span class="col-md-7 ">
            <asp:TextBox ID="txtbkAuthor" CssClass="form-control " runat="server"></asp:TextBox>
        </span>
    </div>
    
    <div class="form-group row">
        <asp:Label ID="Label1" AssociatedControlID="txtPub" CssClass="control-label col-md-5 text-right" Text="Publication :" runat="server"></asp:Label>
        <span class="col-md-7 ">
            <asp:TextBox ID="txtPub" CssClass="form-control" runat="server"></asp:TextBox>
        </span>
    </div>
    
    <div class="form-group row">
        <asp:Label ID="Label2" AssociatedControlID="txtPurchaseDate" CssClass="control-label col-md-5 text-right" Text="Purchase Date :" runat="server"></asp:Label>
        <span class="col-md-7 ">
            <asp:TextBox ID="txtPurchaseDate" CssClass="form-control " data-provide="datepicker" data-date-format="dd-M-yyyy" data-date-orientation="bottom left" runat="server"></asp:TextBox>
        </span>
    </div>
    
    <div class="form-group row">
        <asp:Label ID="Label3" AssociatedControlID="txtBkPrice" CssClass="control-label col-md-5 text-right" Text="Book Price :" runat="server"></asp:Label>
        <span class="col-md-7 ">
            <asp:TextBox ID="txtBkPrice" CssClass="form-control " runat="server"></asp:TextBox>
        </span>
    </div>
    
    <div class="form-group row">
        <asp:Label ID="Label4" AssociatedControlID="txtBkQunt" CssClass="control-label col-md-5 text-right" Text="Book Quantity :" runat="server"></asp:Label>
        <span class="col-md-7 ">
            <asp:TextBox ID="txtBkQunt" CssClass="form-control " runat="server"></asp:TextBox>
        </span>
    </div>
    
    <div class="btn-group col-md-offset-5">
        <asp:Button ID="btnSubmit" CssClass="btn btn-success" runat="server" Text="Submit" OnClick="btnSubmit_OnClick"/>
        <button type="reset" class="btn btn-warning">Reset</button>
    </div>

</asp:Content>
