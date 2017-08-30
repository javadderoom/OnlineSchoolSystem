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
    public partial class SesionHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvSessionHistory.DataSource =
        }

        protected void gvSessionHistory_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                // Retrieve the row index stored in the
                // CommandArgument property.
                int index = Convert.ToInt32(e.CommandArgument);

                // Retrieve the row that contains the button
                // from the Rows collection.
                GridViewRow row = gvSessionHistory.Rows[index];

                Response.Redirect("http://localhost:4911/Dashboard/Admin/EditStudent.aspx?userid=" + row.Cells[0].Text);
            }
            if (e.CommandName == "Details")
            {
                // Retrieve the row index stored in the
                // CommandArgument property.
                int index = Convert.ToInt32(e.CommandArgument);

                // Retrieve the row that contains the button
                // from the Rows collection.
                GridViewRow row = gvSessionHistory.Rows[index];

                string id = row.Cells[0].Text;


            }
            if (e.CommandName == "Delet")
            {
                // Retrieve the row index stored in the
                // CommandArgument property.
                int index = Convert.ToInt32(e.CommandArgument);

                // Retrieve the row that contains the button
                // from the Rows collection.
                GridViewRow row = gvSessionHistory.Rows[index];

                vStudentRepository rep = new vStudentRepository();

                SchoolDBEntities db = new SchoolDBEntities();
                db.Students.Remove(rep.FindByStudentCode(row.Cells[0].Text));
            }
        }
    }
}