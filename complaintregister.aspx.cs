using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Default : System.Web.UI.Page
{
    Cls_Metro obj=new Cls_Metro();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        string sel = "insert into tbl_complaint (complaint_title,complaint_description,complaint_date,complaint_time) values('" + txttitle.Text + "','" + txtdescription.Text + "','"+DateTime.Now.ToShortDateString()+"','"+DateTime.Now.ToShortTimeString()+"')";
        obj.ExecuteCommand(sel);
        Response.Write("<script>alert('complaint registered')</script>");
        txttitle.Text = " ";
        txtdescription.Text = " ";

    }
}