﻿using System;
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
    public partial class EditKartabl : System.Web.UI.Page
    {
        private KarmandRepository kr = new KarmandRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadKrmand();
        }

        private void LoadKrmand()
        {
            Karmand stu = kr.FindByUserName("moosa");

            lblID.InnerText = stu.EID.ToString();
            lblPersonalCode.InnerText = stu.PersonalCode.ToString();
            lblFirstName.InnerText = stu.FirstName;
            lblLastName.InnerText = stu.LastName;

            tbxBirthDate.Text = stu.BirthDate;

            tbxFixTel.Value = stu.PhoneNumber;
            tbxMobile.Value = stu.Mobile;
            tbxEmail.Value = stu.Email;
        }

        protected void btnSabtEditkartabl_Click(object sender, EventArgs e)
        {
            Karmand stu = new Karmand();
            SchoolDBEntities db = new SchoolDBEntities();

            Karmand stuu = db.Karmands.Where(p => p.UserName == "moosa").Single();

            stu.EID = lblID.InnerText.ToInt();
            stu.FirstName = stuu.FirstName;
            stu.LastName = stuu.LastName;
            stu.PersonalCode = lblPersonalCode.InnerText;
            stu.UserName = stuu.UserName;
            stu.UserPass = stuu.UserPass;

            stu.BirthDate = tbxBirthDate.Text;

            stu.PhoneNumber = tbxFixTel.Value;
            stu.Mobile = tbxMobile.Value;

            stu.Email = tbxEmail.Value;

            KarmandRepository sr = new KarmandRepository();
            sr.SaveEmployees(stu);
            Response.Redirect("http://localhost:4911/Dashboard/Admin/Kartabl.aspx");
        }
    }
}