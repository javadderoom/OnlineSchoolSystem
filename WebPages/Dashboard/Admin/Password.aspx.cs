using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;

namespace WebPages.Dashboard
{
    public partial class Password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnPassSabt_Click(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SchoolDBEntities db = new SchoolDBEntities();

            Student stuu = db.Students.Where(p => p.UserName == "javad").Single();
            if (tbxCurrentPassword.Value == stuu.Password)
            {
                stuu.Password = tbxNewPassword.Value;
                db.SaveChanges();
            }
        }
    }
}