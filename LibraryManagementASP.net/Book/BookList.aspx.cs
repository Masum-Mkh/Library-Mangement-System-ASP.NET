using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;

namespace LibraryManagementASP.net.Book
{
    public partial class BookList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_OnClick(object sender, EventArgs e)
        {
            if (GridView1.SelectedIndex < 0)
            {
                return;
            }

            Session["Book_ID"] = GridView1.SelectedValue;

            //Session.Add("StudentID",GridView1.SelectedValue);

            Response.Redirect("~/Book/BookEdit.aspx");
            //Server.Transfer("StudentEdit.aspx");
        }

        protected void btnDelete_OnClick(object sender, EventArgs e)
        {
            if (GridView1.SelectedIndex < 0)
            {
                return;
            }

            Session["Book_ID"] = GridView1.SelectedValue;

            //Session.Add("StudentID",GridView1.SelectedValue);

            Response.Redirect("~/Book/BookDelete.aspx");
            //Server.Transfer("StudentEdit.aspx");
        }

        protected void btnReports_OnClick(object sender, EventArgs e)
        {
            LoadReport();
            Server.Transfer("~/Report/Report.aspx");
        }

        private void LoadReport()
        {
            string conString = WebConfigurationManager.ConnectionStrings["LibraryCon"].ConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"select * from vwBooks";
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "vwBooks");

                    ReportDocument rd = new ReportDocument();
                    string reportpath = Server.MapPath(@"\Book\AllBookReport.rpt");

                    rd.Load(reportpath);
                    rd.SetDataSource(ds);
                    Session["report"] = rd;

                    Response.Redirect("~/Report/Report.aspx");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}