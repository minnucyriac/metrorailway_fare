using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class Project_Admin_Default2 : System.Web.UI.Page
{
    Cls_metro obj = new Cls_metro();
    public static string eid;
    public static int f;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillgrid();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if(f==0)
        {
        String ins = "insert into tbl_rate(distance,rate)values('"+txtdist.Text+"','"+txtrate.Text+"') ";
        obj.ExecuteCommand(ins);
        fillgrid();
        txtdist.Text = " ";
        txtrate.Text = " ";
        }
        else
        {
            String up = "update tbl_rate set distance = '" + txtdist.Text + "', rate ='" + txtrate.Text + "' where distance = '" + eid + "' ";
        obj.ExecuteCommand(up);
        fillgrid();

        }

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        eid = Convert.ToString(e.CommandArgument);
        if(e.CommandName == "ed")
        {
            String sel = "select* from tbl_rate where distance = '"+eid+"' ";
            DataTable dt = obj.GetDataTable(sel);
          
            txtdist.Text = Convert.ToString(dt.Rows[0]["distance"]);
            txtrate.Text = Convert.ToString(dt.Rows[0]["rate"]);
            f = 1;
     

        }

        if(e.CommandName == "del")
        {
            
            String del = "delete from tbl_rate where distance = '"+eid+"' ";
            obj.ExecuteCommand(del);
            Response.Write("<script>alert('deleted successfully')</script>");

            fillgrid();
        }

    }

    public void fillgrid()
    {
        string sel = "select * from tbl_rate";
        obj.FillGridView(sel,GridView1);
    }
}