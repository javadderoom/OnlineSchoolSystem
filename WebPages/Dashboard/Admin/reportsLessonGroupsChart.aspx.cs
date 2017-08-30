using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess.Repository;
using Common;

namespace WebPages.Dashboard.Admin
{
    public partial class reportsLessonGroupsChart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                setLabel();
            }
        }
        public void setLabel()
        {
            vReportLessongroupRepository v = new vReportLessongroupRepository();

            string id = Request.QueryString["LGID"];
            lblNomre.Text = v.getAverageLessonGroup(id.ToInt()).ToString();

        }
    }
}