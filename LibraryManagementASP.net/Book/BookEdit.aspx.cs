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
    public partial class BookEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //for initial data load; get method
            {
                if (Session["Book_ID"] == null)
                {
                    Response.Redirect("BookList.aspx");
                }
                else
                {
                    int bookid = Convert.ToInt32(Session["Book_ID"]);
                    DataLoad(bookid);
                }
            }
        }

        private void DataLoad(int bookid)
        {
            string conString = WebConfigurationManager.ConnectionStrings["LibraryCon"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"select * from BooksInfoEntry where Book_ID = '{bookid}'";

                    con.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        bookID.Value = reader["Book_ID"].ToString();
                        txtbkName.Text = reader["Book_Name"].ToString();
                        txtbkAuthor.Text = reader["Author_Name"].ToString();
                        txtPub.Text = reader["Publication"].ToString();
                        txtPurchaseDate.Text = reader["Purchase_Date"].ToString();
                        txtBkPrice.Text = reader["Book_Price"].ToString();
                        txtBkQunt.Text = reader["Books_Quantity"].ToString();
                    }

                }
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            try
            {
                DataUpdate();
                Response.Redirect("BookList.aspx");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private void DataUpdate()
        {
            string conString = WebConfigurationManager.ConnectionStrings["LibraryCon"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = $"UPDATE [dbo].[BooksInfoEntry] SET[Book_Name] = '{txtbkName.Text}' ,[Author_Name] = '{txtbkAuthor.Text}' ,[Publication] = '{txtPub.Text}' ,[Purchase_Date] = '{txtPurchaseDate.Text}' ,[Book_Price] = '{txtBkPrice.Text}' ,[Books_Quantity] = '{txtBkQunt.Text}' WHERE Book_ID = '{bookID.Value}' ";

                con.Open();
                cmd.ExecuteNonQuery();
            }
           
        }
    }
}

