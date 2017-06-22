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
    public static double eid,f;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillgrid();

        }

    }
    protected void gridview_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        eid = Convert.ToInt32(e.CommandArgument);
        if (e.CommandName == "ed")
        {
            String sel = "select * from tbl_station where station_no='" + eid + "'";
            DataTable dt=obj.GetDataTable(sel);
            f = 1;
            txtname.Text = Convert.ToString(dt.Rows[0]["station_name"]);
            
        }
        if (e.CommandName == "del")
         {
             String del = "delete from tbl_station where station_no='" + eid + "'";
             obj.ExecuteCommand(del);
             Response.Write("<script>alert('deleted successfully')</script>");

             fillgrid();


        }

    }
protected void btnsub_Click(object sender, EventArgs e)
{
    if (f == 0)
    {
        String ins = "insert into tbl_station(station_name)values('" + txtname.Text + "')";
        obj.ExecuteCommand(ins);
        txtname.Text = " ";
        fillgrid();
    }
    else
    {
        String up = "update tbl_station set station_name='" + txtname.Text + "' where station_no='" + eid + "'";
        obj.ExecuteCommand(up);
        f = 0;
        fillgrid();
    }
}
    public void fillgrid()
    {
        string sel = "select * from tbl_station";
        obj.FillGridView(sel, gridview);

    }
}