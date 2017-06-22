using System;
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sel = "select * from tbl_userreg where user_username='" + txtuname.Text + "' and user_password='" + txtpassword.Text + "'";
        DataTable dt = obj.GetDataTable(sel);
        Session["username"] = txtuname.Text;
        string sele = "select * from tbl_admindb where admin_uname='" + txtuname.Text + "' and admin_password='" + txtpassword.Text + "'";
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
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        
        Response.Redirect("pswdreset.aspx");
    }
    protected void txtpassword_TextChanged(object sender, EventArgs e)
    {

    }
}