﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class User_Default : System.Web.UI.Page
{
    Cls_Metro obj = new Cls_Metro();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        String sel = "select * from tbl_userreg where user_username='" + txtuname.Text + "' and user_password='" + txtpassword.Text + "'";
        DataTable dt = obj.GetDataTable(sel);
        Session["username"] = txtuname.Text;
        String sele = "select * from tbl_admin where admin_uname='" + txtuname.Text + "' and admin_password='" + txtpassword.Text + "'";
        DataTable dtt = obj.GetDataTable(sele);
        if (dt.Rows.Count > 0)
        {
            Session["f"] = 1;
            Session["userid"] = dt.Rows[0]["user_id"];
            Response.Redirect("~/User/homepage.aspx");
        }
        else if (dtt.Rows.Count > 0)
        {
            Response.Redirect("~/Admin/details.aspx");
        }
        else
        {
            Response.Write("<script>alert('invalid userlogin')</script>");
        }
    }
    //protected void fpswd_Click(object sender, EventArgs e)
    //{

    //    Response.Redirect("http://localhost:4467/Project/User/pswdreset.aspx");
    }
}