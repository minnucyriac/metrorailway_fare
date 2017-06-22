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
        if (!IsPostBack)
        {
            filldrop();
        }
    }
    public void filldrop()
    {
        obj.FillDrop(drpsource, "station_name", "station_no", "tbl_station");
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        //Session["username"] = txtuname.Text;
        string ins="insert into tbl_punch(punch_sname,punch_dname,punch_aadharno,punch_dist,punch_amt) values('"+drpsource.SelectedValue+"','0','0','0','0')";
        obj.ExecuteCommand(ins);
        Response.Redirect("welcome.aspx");
    }
    protected void drpsource_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}