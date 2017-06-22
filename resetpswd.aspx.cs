using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Default : System.Web.UI.Page
{
    Cls_Metro obj = new Cls_Metro();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BTNSAVE_Click(object sender, EventArgs e)
    {
        string up="update tbl_userreg set user_password='"+txtpswd.Text+"' where user_id= '"+Session["userid"]+"'";
        obj.ExecuteCommand(up);
        Response.Write("<script>alert('password reset successfully')</script>");
        Response.Redirect("userprofile.aspx");
    }
}