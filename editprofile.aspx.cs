using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class User_Default2 : System.Web.UI.Page
{
    Cls_metro obj = new Cls_metro();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string sel = "select * from tbl_userreg where user_id='" + Session["userid"] + "'";
            obj.ExecuteCommand(sel);
            DataTable dt = obj.GetDataTable(sel);
            txteid.Text = Convert.ToString(dt.Rows[0]["user_email"]);
            txtuname.Text = Convert.ToString(dt.Rows[0]["user_username"]);
            txtcontact.Text = Convert.ToString(dt.Rows[0]["user_contactno"]);
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string up = "update tbl_userreg set user_email='" + txteid.Text + "',user_username='" + txtuname.Text + "',user_contactno='" + txtcontact.Text + "'where user_id='"+Session["userid"]+"'";
        obj.ExecuteCommand(up);
        Response.Write("<script>alert('updated successfully')</script>");
        
    }
}