using DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPages.Dashboard.Admin
{
    public partial class adminStudentsPayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadPayments();
            }
        }

        public void loadPayments()
        {
            string id = Request.QueryString["stuCode"];
            vPaymentHistoryRepository ph = new vPaymentHistoryRepository();
            gvPaymentHistory.DataSource = ph.getPaymentHistoryByStuCode(id);
            gvPaymentHistory.DataBind();
            int? rs = ph.calculateRemainedSalary() * 10;


            if (rs < 0)
            {
                lblSalary.Text = " " + -rs + " " + "هزار ریال";
                lblSalary.ForeColor = Color.Red;
                lblSalary.Text += "(بدهکار)";
            }

            else
            {
                lblSalary.Text = " " + rs + "  " + "هزار ریال";
                lblSalary.ForeColor = Color.Green;
                lblSalary.Text += "(بستانکار)";
            }


        }

        protected void gvPaymentHistory_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }
    }
}