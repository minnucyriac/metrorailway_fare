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
        if (!IsPostBack)
        {
            string sel="select * from tbl_userreg where user_id='"+Session["userid"]+"'";
            DataTable dt = obj.GetDataTable(sel);
            lblaadharno.Text = Convert.ToString(dt.Rows[0]["user_aadharno"]);
            lbleid.Text = Convert.ToString(dt.Rows[0]["user_email"]);
            lblname.Text = Convert.ToString(dt.Rows[0]["user_fname"]) + Convert.ToString(dt.Rows[0]["user_mname"]) + Convert.ToString(dt.Rows[0]["user_lname"]);
            string sele = "select * from tbl_vallet where useradhar_no='" +lblaadharno.Text + "'";
            DataTable dtt = obj.GetDataTable(sele);
            lblwamt.Text = Convert.ToString(dtt.Rows[0]["val_amount"]);
        }
    }
    protected void linkedit_Click(object sender, EventArgs e)
    {
        Response.Redirect("editprofile.aspx");
    }
    protected void linkwallet_Click(object sender, EventArgs e)
    {
        Session["flag"] = 1;
        Session["sname"] = lblname.Text;
        Session["aadharno"] = lblaadharno.Text;
        Response.Redirect("~/User/Default.aspx");
        
    }
}