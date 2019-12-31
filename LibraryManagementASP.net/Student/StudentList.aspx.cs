using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementASP.net.Student
{
    public partial class StudentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
                    cmd.CommandText = $"select * from vwStudents";
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "vwStudents");

                    ReportDocument rd = new ReportDocument();
                    string reportpath = Server.MapPath(@"\Student\StudentListReport.rpt");

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

        protected void btnUpdate_OnClick(object sender, EventArgs e)
        {
            if (GridView1.SelectedIndex < 0)
            {
                return;
            }

            Session["Student_ID"] = GridView1.SelectedValue;

            //Session.Add("StudentID",GridView1.SelectedValue);

            Response.Redirect("StudentEdit.aspx");
            //Server.Transfer("StudentEdit.aspx");
        }

        protected void btnDelete_OnClick(object sender, EventArgs e)
        {
            if (GridView1.SelectedIndex < 0)
            {
                return;
            }

            Session["Student_ID"] = GridView1.SelectedValue;

            //Session.Add("StudentID",GridView1.SelectedValue);

            Response.Redirect("StudentDelete.aspx");
            //Server.Transfer("StudentEdit.aspx");
        }
    }
}