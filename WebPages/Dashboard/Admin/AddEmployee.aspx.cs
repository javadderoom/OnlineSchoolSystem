using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using DataAccess.Repository;

namespace WebPages.Dashboard.Admin
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        private KarmandRepository rep = new KarmandRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSabtEditProfile_Click(object sender, EventArgs e)
        {
            Karmand kar = new Karmand();

            kar.UserName = tbxUserName.Value;
            kar.UserPass = tbxPassword.Value;

            kar.PersonalCode = tbxPersonalCode.Value;

            kar.FirstName = tbxFirstName.Value;
            kar.LastName = tbxLastName.Value;
            kar.BirthDate = string.Format("{0}{1}{2}", tbxBirthDay.Value.Substring(0, 4), tbxBirthDay.Value.Substring(5, 2), tbxBirthDay.Value.Substring(8, 2));

            kar.PhoneNumber = tbxFixTel.Value;
            kar.Mobile = tbxMobile.Value;

            // kar.Email = tbxEmail.Value;

            rep.SaveEmployees(kar);
            Response.Redirect("http://localhost:4911/Dashboard/Admin/Employees.aspx");
        }
    }
}