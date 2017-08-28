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
    public partial class AddStudent : System.Web.UI.Page
    {
        private vStudentRepository rep = new vStudentRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSabtEditProfile_Click(object sender, EventArgs e)
        {
            Student stu = new Student();

            //stu.StuID = stuu.StuID;
            //stu.SGarde = stuu.SGarde;
            //stu.CGrade = stuu.CGrade;
            //stu.UserName = stuu.UserName;
            //stu.Password = stuu.Password;
            //stu.FatherID = stuu.FatherID;
            //stu.MotherID = stuu.MotherID;
            //stu.RemainedSalary = stuu.RemainedSalary;

            //stu.StudentCode = id;
            //stu.ParentUser = stuu.ParentUser;
            //stu.ParentPass = stuu.ParentPass;
            //stu.FirstName = tbxFirstName.Value;
            //stu.LastName = tbxLastName.Value;
            //stu.BirthDate = string.Format("{0}{1}{2}", tbxBirthYear.Value, stuu.BirthDate.Substring(4, 2), stuu.BirthDate.Substring(6, 2));
            //stu.NationalCode = stuu.NationalCode;
            //stu.PhoneNumber = tbxFixTel.Value;
            //stu.MobileNumber = tbxMobile.Value;
            //stu.ZipCode = tbxZipCode.Value;
            //stu.Email = tbxEmail.Value;

            //rep.SaveStudent(stu);
            //Response.Redirect("http://localhost:4911/Dashboard/Admin/Students.aspx");
        }
    }
}