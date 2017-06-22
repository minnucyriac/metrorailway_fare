using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class Admin_Default : System.Web.UI.Page
{
    Cls_metro obj = new Cls_metro();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        Session["username"] = txtuname.Text;
        Response.Redirect("~/Admin/details.aspx");
    }
}