using DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPages.Dashboard.Admin
{
    public partial class studentsPayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadStudents();
            }
        }

        public void LoadStudents()
        {
            vStudentRepository sr = new vStudentRepository();
            gvStudents.DataSource = sr.GetAllStudents();
            gvStudents.DataBind();
            vStudent st = new vStudent();
            tbxSearch.Value = "";
        }

        protected void gvStudents_RowDataBound(object sender, GridViewRowEventArgs e)
        {
        }


        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxSearch.Value != "")
            {
                vStudentRepository sr = new vStudentRepository();

                gvStudents.DataSource = sr.searchStudents(tbxSearch.Value);
                gvStudents.DataBind();
            }
        }

        protected void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        protected void gvStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void gvStudents_RowEditing(object sender, GridViewEditEventArgs e)
        {
        }

        private vStudentRepository rep = new vStudentRepository();

        protected void gvStudents_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "Details")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvStudents.Rows[index];

                Response.Redirect("http://localhost:4911/Dashboard/Admin/adminStudentsPayment.aspx?stuCode=" + row.Cells[0].Text);
            }

        }
    }
}