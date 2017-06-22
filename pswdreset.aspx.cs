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
    protected void btsave_Click(object sender, EventArgs e)
    {
        string sel = "select * from tbl_userreg where user_username='" + txtuname.Text + "' and user_sqstn='" + drpsqstn.SelectedValue + "' and user_answer='" + txtanswer.Text + "'";
        DataTable dt = obj.GetDataTable(sel);
        if (dt.Rows.Count > 0)
        {
            Session["userid"] = dt.Rows[0]["user_id"];
            Response.Redirect("resetpswd.aspx");

        }
        else
        {
            Response.Write("<script>alert('Invalid Details')</script>");
        }
    }
}