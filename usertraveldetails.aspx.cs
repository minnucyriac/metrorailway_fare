using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Guest_Default : System.Web.UI.Page
{
    Cls_Metro obj = new Cls_Metro();
    public static double s;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    public void fillgrid()
    {
        string sel="select * from tbl_userreg where user_id='"+Session["userid"]+"'";
        DataTable dt=obj.GetDataTable(sel);
        string sele = "select * from tbl_punch where punch_aadharno='" + dt.Rows[0]["user_aadharno"] + "'and punch_date between'" + txtfromdate.Text + "' and '" + txttodate.Text + "'";
        DataTable dtt=obj.GetDataTable(sele);
        obj.FillGridView(sele, GridView1);
        if (dtt.Rows.Count == 0)
        {
            Response.Write("<script>alert('0 RECORDS FOUND')</script>");
        }
        string selec = "select sum(punch_amt) as s from tbl_punch where  punch_aadharno='" + dt.Rows[0]["user_aadharno"] + "'and punch_date between'" + txtfromdate.Text + "' and '" + txttodate.Text + "'";
        DataTable dttt = obj.GetDataTable(selec);
        lblamt.Text = Convert.ToString(dttt.Rows[0]["s"]);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        fillgrid();
    }
}