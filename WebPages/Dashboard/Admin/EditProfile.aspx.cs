using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using DataAccess.Repository;
using Common;

namespace WebPages.Dashboard
{
    public partial class EditProfile : System.Web.UI.Page
    {
        private vStudentRepository srr = new vStudentRepository();

        public void load()
        {
            vStudent stu = srr.GetStudentByUsername("javad");

            lblStuID.InnerText = stu.StuID.ToString();
            lblStudentCode.InnerText = stu.StudentCode.ToString();
            lblFirstName.InnerText = stu.FirstName;
            lblLastName.InnerText = stu.LastName;
            tbxFatherName.Value = stu.FathersFirstName;
            tbxBirthYear.Value = stu.BirthDate.Substring(0, 4);
            tbxIDNumber.Value = stu.NationalCode.ToString();
            tbxFixTel.Value = stu.PhoneNumber;
            tbxMobile.Value = stu.MobileNumber;
            tbxZipCode.Value = stu.ZipCode;
            tbxEmail.Value = stu.Email;
            tbxAddress.InnerText = stu.Address;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load();
            }
        }

        protected void btnSabtEditProfile_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            SchoolDBEntities db = new SchoolDBEntities();

            Student stuu = db.Students.Where(p => p.UserName == "javad").Single();

            stu.StuID = lblStuID.InnerText.ToInt();
            stu.FirstName = stuu.FirstName;
            stu.LastName = stuu.LastName;
            stu.SGarde = stuu.SGarde;
            stu.CGrade = stuu.CGrade;
            stu.UserName = stuu.UserName;
            stu.Password = stuu.Password;
            stu.FatherID = stuu.FatherID;
            stu.MotherID = stuu.MotherID;
            stu.RemainedSalary = stuu.RemainedSalary;
            stu.StudentCode = lblStudentCode.InnerText;
            stu.BirthDate = string.Format("{0}{1}{2}", tbxBirthYear.Value, stuu.BirthDate.Substring(4, 2), stuu.BirthDate.Substring(6, 2));
            stu.NationalCode = stuu.NationalCode;
            stu.PhoneNumber = tbxFixTel.Value;
            stu.MobileNumber = tbxMobile.Value;
            stu.ZipCode = tbxZipCode.Value;
            stu.Email = tbxEmail.Value;
            stu.Address = tbxAddress.InnerText;
            stu.ParentUser = stuu.ParentUser;
            stu.ParentPass = stuu.ParentPass;
            vStudentRepository sr = new vStudentRepository();
            sr.SaveStudent(stu);
            Response.Redirect("http://localhost:4911/Dashboard/Dashboard.aspx");
        }
    }
}