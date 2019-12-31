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
    public partial class StudentEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //for initial data load; get method
            {
                if (Session["Student_ID"] == null)
                {
                    Response.Redirect("StudentEdit.aspx");
                }
                else
                {
                    int studentid = Convert.ToInt32(Session["Student_ID"]);
                    DataLoad(studentid);
                }
            }
        }


        private void DataLoad(int studentid)
        {
            string conString = WebConfigurationManager.ConnectionStrings["LibraryCon"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"select * from StudentInfoEntry where Student_ID = '{studentid}'";
                    
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        txtStuID.Value = reader["Student_ID"].ToString();
                        txtStuName.Text = reader["Student_Name"].ToString();
                        txtStuEnrol.Text = reader["Enrollment_No"].ToString();
                        txtStuDept.Text = reader["Department"].ToString();
                        txtStuSem.Text = reader["Student_Semester"].ToString();
                        txtStuCon.Text = reader["Student_Contact"].ToString();
                        txtStuEmail.Text = reader["Student_Email"].ToString();
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
                Response.Redirect("StudentList.aspx");
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
                cmd.CommandText = $"update  [dbo].[StudentInfoEntry] set [Student_Name] ='{txtStuName.Text}' ,[Enrollment_No]='{txtStuCon.Text}' ,[Department]='{txtStuDept.Text}' ,[Student_Semester]='{txtStuSem.Text}' ,[Student_Contact]='{txtStuCon.Text}' ,[Student_Email]='{txtStuEmail.Text}' where Student_ID = '{txtStuID.Value}' ";

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}