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
            fillgrid();
        }
    }
    public void fillgrid()
    {
        string sel = "select * from tbl_complaint";
        obj.FillGridView(sel, GridView1);
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}