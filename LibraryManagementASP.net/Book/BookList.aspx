<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" AutoEventWireup="true" CodeBehind="BookList.aspx.cs" Inherits="LibraryManagementASP.net.Book.BookList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <br/>
    
    <div class="btn-group btn-block">
        <asp:HyperLink ID="HyperLink1" CssClass="btn btn-success" NavigateUrl="BookEntry.aspx"  runat="server">Add New</asp:HyperLink>
        
        <asp:Button ID="btnUpdate" CssClass="btn btn-warning" runat="server" OnClick="btnUpdate_OnClick" Text="Update"  />
        <asp:Button ID="btnDelete" CssClass="btn btn-danger" runat="server" Text="Delete" OnClick="btnDelete_OnClick"  />
        <asp:Button ID="btnReports" CssClass="btn btn-info"  Text="Report"  runat="server" OnClick="btnReports_OnClick"/> 
    </div>
    
    <br/>
    
    <hr/>
    
    <div class="table-responsive">

    

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-responsive table-condensed" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="Book_ID" DataSourceID="SqlDataSource1" GridLines="Horizontal" AllowPaging="True" AllowSorting="True">
        <Columns>
            <asp:CommandField ShowSelectButton="True"  ButtonType="Button" />
            <asp:BoundField DataField="Book_ID" HeaderText="Book_ID" InsertVisible="False" ReadOnly="True" SortExpression="Book_ID" />
            <asp:BoundField DataField="Book_Name" HeaderText="Book_Name" SortExpression="Book_Name" />
            <asp:BoundField DataField="Author_Name" HeaderText="Author_Name" SortExpression="Author_Name" />
            <asp:BoundField DataField="Publication" HeaderText="Publication" SortExpression="Publication" />
            <asp:BoundField DataField="Purchase_Date" HeaderText="Purchase_Date" SortExpression="Purchase_Date" />
            <asp:BoundField DataField="Book_Price" HeaderText="Book_Price" SortExpression="Book_Price" />
            <asp:BoundField DataField="Books_Quantity" HeaderText="Books_Quantity" SortExpression="Books_Quantity" />
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

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:LibraryCon %>" SelectCommand="SELECT [Book_ID], [Book_Name], [Author_Name], [Publication], [Purchase_Date], [Book_Price], [Books_Quantity] FROM [BooksInfoEntry]"></asp:SqlDataSource>

</asp:Content>
