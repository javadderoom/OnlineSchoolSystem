using System;
using System.Web.UI.WebControls;
using DataAccess.Repository;
using Common;
using System.Data;

namespace WebPages.Dashboard.Admin
{
    public partial class ReportStudentsChart : System.Web.UI.Page
    {
        private int id = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["stuCode"].ToString().ToInt();
            if (!IsPostBack)
            {
                setlabels();
                setGrid();
            }
        }

        private void setGrid()
        {
            StudentRepository s = new StudentRepository();
            gvClasses.DataSource = s.getStudentAverageGroupByLGIDByStuCode(id);
            gvClasses.DataBind();
        }

        private void setlabels()
        {
            StudentRepository s = new StudentRepository();
            DataTable dt = s.getStudentsInfoByStuCode(id);
            if (dt.Rows.Count == 0)
            {
                lblStuCode.InnerText = "";
                lblFullName.InnerText = "";
                lblMaghta.InnerText = "";
                lblClassNum.InnerText = "";
            }
            else
            {
                lblStuCode.InnerText = dt.Rows[0][0].ToString();
                lblFullName.InnerText = dt.Rows[0][1].ToString();
                lblMaghta.InnerText = dt.Rows[0][2].ToString();
                lblClassNum.InnerText = dt.Rows[0][3].ToString();
            }

            lblmianginkatbi.InnerText = s.getStudentAverageInCurrentYear(id, 0).ToString();
            lblmianginshafahi.InnerText = s.getStudentAverageInCurrentYear(id, 1).ToString();
        }

        protected void gvClasses_RowDataBound(object sender, GridViewRowEventArgs e)
        {
        }
    }
}