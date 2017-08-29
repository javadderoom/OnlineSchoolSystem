using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess.Repository;

namespace WebPages.Dashboard.Admin
{
    public partial class NewSesion : System.Web.UI.Page
    {
        int id;

        private void loadSssions()
        {
            id = Convert.ToInt32(Request.QueryString["LGID"]);

            SessionRepository Sesrep = new SessionRepository();
            SessionNumber.Text = Sesrep.CountSessionsByLGID(id);
            vLessonGroupRepository vLesRep = new vLessonGroupRepository();
            var lessonGroup = vLesRep.FindByLGID(id);
            ClassNumber.Text = lessonGroup.Class;
            LessonName.Text = lessonGroup.LessonTitle;
            OzviatRepository ozviatRep = new OzviatRepository();
            StudentCount.Text = ozviatRep.StudentCountByLGID(id);
            gvStudents.DataSource = ozviatRep.FindByLGID(id);
            gvStudents.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadSssions();
            }
        }
    }
}