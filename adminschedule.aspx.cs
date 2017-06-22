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
    public static double f = 0,sti,dtime,ti,tid,tidi,tidii,eid;
    public static string tname;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillgrid();
            filldropstation();
            filldroptrain();
        }

    }
    public void filldropstation()
    {
        obj.FillDrop(drpstation, "station_name", "station_no", "tbl_station");
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
     
    }
    public void filldroptrain()
    {
        obj.FillDrop(drptrain,"train_name","train_id","tbl_train");
    }
    public void fillgrid()
    {
        string sel = "select sh.sch_id,t.train_name,s.station_name,sh.arrival_time,sh.departure_time from tbl_station s,tbl_train t,tbl_schedule sh where t.train_id=sh.train_id and s.station_no=sh.station_no";
        obj.FillGridView(sel, GridView1);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (f == 0)
        {

            String ins = "insert into tbl_schedule(train_id,station_no,arrival_time,departure_time) values('" + drptrain.SelectedValue + "','" + drpstation.SelectedValue + "','" + txtarrivaltime.Text + "','" + txtduration.Text + "') ";
            obj.ExecuteCommand(ins);
            fillgrid();
            txtarrivaltime.Text = " ";
            txtduration.Text = " ";
            
        }
        else
        {

            String up = "update tbl_schedule set  train_id= '" + drptrain.SelectedValue + "', station_no='" + drpstation.SelectedValue + "', arrival_time='" + txtarrivaltime.Text + "',departure_time='" + txtduration.Text + "' where sch_id = '" + eid + "' ";
            obj.ExecuteCommand(up);
            fillgrid();
            txtarrivaltime.Text = " ";
            txtduration.Text = " ";
            filldropstation();
            filldroptrain();
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        eid = Convert.ToInt32(e.CommandArgument);
        if (e.CommandName == "edt")
        {
            Response.Write("editing");
            String sel = "select * from tbl_schedule where sch_id = '" + eid + "' ";
            DataTable dt = obj.GetDataTable(sel);
            txtarrivaltime.Text = Convert.ToString(dt.Rows[0]["arrival_time"]);
            txtduration.Text = Convert.ToString(dt.Rows[0]["departure_time"]);
            f = 1;
            filldropstation();
            filldroptrain();

        }

        if (e.CommandName == "del")
        {

            String del = "delete from tbl_schedule where sch_id = '" + eid + "' ";
            obj.ExecuteCommand(del);
            fillgrid();
            txtarrivaltime.Text = " ";
            txtduration.Text = " ";
            filldropstation();
            filldroptrain();
            Response.Write("<script>alert('deleted successfully')</script>");
        }
    }
    protected void edt(object sender, CommandEventArgs e)
    {

    }
    protected void del(object sender, CommandEventArgs e)
    {

    }
    
}