﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MVCEventCalendar
{
    public partial class samplelogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "admin" && txtpassword.Text == "123")
            {
                Response.Redirect("adminhome.aspx");
            }
            else
            {
                Label2.Visible = true;
            }
        }
    }
}