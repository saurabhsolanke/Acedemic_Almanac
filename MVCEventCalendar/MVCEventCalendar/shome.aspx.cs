﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace MVCEventCalendar
{
    public partial class shome : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Downloads\Almanac3.0\MVCEventCalendar\MVCEventCalendar\App_Data\almanac.mdf;Integrated Security=True");
        string query;

        protected void Page_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM subject";
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);

            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }

      

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Session["studentid"] = null;
            Session["password"] = null;

            Response.Redirect("index.aspx");
        }
    }
}