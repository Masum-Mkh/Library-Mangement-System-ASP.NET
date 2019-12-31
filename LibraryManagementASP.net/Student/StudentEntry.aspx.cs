using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementASP.net.Student
{
    public partial class StudentEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            try
            {
                DataSave();
                Response.Redirect("StudentList.aspx");
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception);
            }
        }

        private void DataSave()
        {
            string conString = WebConfigurationManager.ConnectionStrings["LibraryCon"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = $"INSERT INTO [dbo].[StudentInfoEntry] ([Student_Name] ,[Enrollment_No] ,[Department] ,[Student_Semester] ,[Student_Contact] ,[Student_Email]) VALUES ('{txtStuName.Text}' ,'{txtStuCon.Text}' ,'{txtStuDept.Text}' ,'{txtStuSem.Text}' ,'{txtStuCon.Text}' ,'{txtStuEmail.Text}') ";

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}