using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
       Session["flag"] = 1;
        Session["amount"] = txtwamt.Text;
        Response.Redirect("~/Guest/Payment1/First.aspx");
    }
}