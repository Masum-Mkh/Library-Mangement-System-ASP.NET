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
    public partial class BookDelete : System.Web.UI.Page
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

        protected void btnDelete_OnClick(object sender, EventArgs e)
        {
            try
            {
                DataDelete();
                Response.Redirect("BookList.aspx");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private void DataDelete()
        {
            string conString = WebConfigurationManager.ConnectionStrings["LibraryCon"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = $"DELETE FROM BooksInfoEntry where Book_ID ='{txtStuID.Value}'";

                con.Open();
                cmd.ExecuteNonQuery();
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
                        txtStuID.Value = reader["Book_ID"].ToString();


                        lblMessage.Text = $"Confirm To Delete {reader["Book_Name"].ToString()}?";

                        
                    }

                }
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }
    }
}