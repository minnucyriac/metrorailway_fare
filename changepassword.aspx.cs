using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class User_Default2 : System.Web.UI.Page
{
    Cls_Metro obj = new Cls_Metro();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sel = "select * from tbl_userreg where user_id='" + Session["userid"] + "' and user_password='"+txtcpswd.Text+"'";
 
        DataTable dt = obj.GetDataTable(sel);
        if (dt.Rows.Count>0)
        {
            string up = "update tbl_userreg set user_password='" + txtnpswd.Text + "' where user_id='" + Session["userid"] + "'";
            obj.ExecuteCommand(up);
            Response.Write("<script>alert('password reset successfully')</script>");

        }
        else
        {
            Response.Write("<script>alert('Invalid password')</script>");
        }
    }
}