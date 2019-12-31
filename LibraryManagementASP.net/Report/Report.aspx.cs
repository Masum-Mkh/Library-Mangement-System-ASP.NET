using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;

namespace LibraryManagementASP.net.Report
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["report"] !=null)
            {
                ReportDocument rd = (ReportDocument) Session["report"];
                CrystalReportViewer1.ReportSource = rd;


            }
            else
            {
                Response.RedirectPermanent("~/");
            }
        }
    }
}