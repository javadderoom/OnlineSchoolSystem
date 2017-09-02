using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess.Repository;
using Common;
using DataAccess;

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

            vReportExamsRepository v = new vReportExamsRepository();
            string id = Request.QueryString["LGID"];
            lblmianginkatbi.InnerText = Convert.ToDouble(v.getAverageLessonGroup(id.ToInt(), 0)).ToString();
            lblmianginshafahi.InnerText = Convert.ToDouble(v.getAverageLessonGroup(id.ToInt(), 1)).ToString();

            TamrinRepository tr = new TamrinRepository();
            int cnt = tr.countTamrinByid(id.ToInt());
            lbltamrincount.InnerText = cnt.ToString();

            vJavabeTamrinRepository jt = new vJavabeTamrinRepository();
            OzviatRepository or = new OzviatRepository();
            int stucnt = or.countStudentsOfLessonGroupByid(id.ToInt());
            if (cnt == 0 || stucnt == 0)
                lblanswer.InnerText = "0";
            else
                lblanswer.InnerText = (((jt.TedadejavabeTamrin(id.ToInt()) /
                    (stucnt * cnt) * 100))).ToString();

            vLessonGroupRepository lg = new vLessonGroupRepository();
            List<string> St = or.FindStudentCodeByLGID(id.ToInt());
            lblStuCount.InnerText = St.Count.ToString();
            vLessonGroup lgg = lg.FindByLGID(id.ToInt());
            lblTeacharName.InnerText = lgg.FirstName + " " + lgg.LastName;
            lblClassNum.InnerText = lgg.Class;
            lblLessonTitle.InnerText = lgg.LessonTitle;

        }
    }
}