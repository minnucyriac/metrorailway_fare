using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Guest_Default : System.Web.UI.Page
{
    Cls_metro obj = new Cls_metro();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillgrid();

        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        fillgrid();
    }
   public void fillgrid()
   {
        string sel = "select p.train_name,q.station_name,r.arrival_time,r.departure_time from tbl_train p,tbl_station q,tbl_schedule r where p.train_id=r.train_id and q.station_no=r.station_no";
        obj.FillGridView(sel,gridview);
    }
}