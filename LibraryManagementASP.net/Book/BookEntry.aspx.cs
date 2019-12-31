using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementASP.net.Book
{
    public partial class BookEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            try
            {
                DataSave();
                Response.Redirect("BookList.aspx");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private void DataSave()
        {
            string conString = WebConfigurationManager.ConnectionStrings["LibraryCon"].ConnectionString;
            using (SqlConnection con=new SqlConnection(conString))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText =
                    $"INSERT INTO [dbo].[BooksInfoEntry] ([Book_Name] ,[Author_Name] ,[Publication] ,[Purchase_Date] ,[Book_Price] ,[Books_Quantity]) VALUES ('{txtbkName.Text}' ,'{txtbkAuthor.Text}' ,'{txtPub.Text}' ,'{txtPurchaseDate.Text}' ,'{txtBkPrice.Text}' ,'{txtBkQunt.Text}' )";

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}