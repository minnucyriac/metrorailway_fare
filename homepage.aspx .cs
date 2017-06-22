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
    protected void linkview_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/User/userprofile.aspx");
    }
    protected void linkedit_Click(object sender, EventArgs e)
    {
        Response.Redirect("/User/editprofile.aspx");
    }
    protected void linkchangepswd_Click(object sender, EventArgs e)
    {
        Response.Redirect("changepassword.aspx");
    }
    protected void linkcomplaint_Click(object sender, EventArgs e)
    {
        Response.Redirect("complaintregister.aspx");
    }
    protected void linkwallet_Click(object sender, EventArgs e)
    {
        Response.Redirect("walletrenew.aspx");
    }
    protected void linktravel_Click(object sender, EventArgs e)
    {
        Response.Redirect("");
    }
    protected void linkfair_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/User/fairdetails.aspx");

    }
}