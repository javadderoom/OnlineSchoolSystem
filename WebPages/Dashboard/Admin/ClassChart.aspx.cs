﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;

namespace WebPages.Dashboard.Admin
{
    public partial class ClassChart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["LGID"];
            ClassChartt.lgid = id.ToInt();
        }
    }
}