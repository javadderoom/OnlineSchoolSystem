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
    public partial class SessionDetails : System.Web.UI.Page
    {
        private SessionRepository sr = new SessionRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadSessionDetails();
        }

        private void LoadSessionDetails()
        {
        }
    }
}