using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void linktschedule_Click(object sender, EventArgs e)
    {
        Response.Redirect("~Admin/schedule.aspx");       
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/Traindetails.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/RouteDetails.aspx");
    }
    protected void linkfare_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/fair details.aspx");
    }
}