using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using DataAccess.Repository;
using Common;

namespace WebPages.Dashboard.Admin
{
    public partial class AddLesson : System.Web.UI.Page
    {
        private LessonsRepository lr = new LessonsRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSabtLesson_Click(object sender, EventArgs e)
        {
            Lesson le = new Lesson();

            le.LessonTitle = tbxLessonTitle.Value;
            le.Unit = tbxUnit.Value.ToInt();

            // kar.Email = tbxEmail.Value;

            lr.SaveLesson(le);
            Response.Redirect("http://localhost:4911/Dashboard/Admin/Lessons.aspx");
        }
    }
}