using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Cls_NewBorn
/// </summary>
public class Cls_metro
{

    SqlConnection con = new SqlConnection("Data Source=DESKTOP-A21O27K;Initial Catalog=db_fingermetro;Integrated Security=True");
    public Cls_metro()
    {
        con.Open();
}   
    public void ExecuteCommand(string str)
    {
        SqlCommand cmd = new SqlCommand(str, con);
        cmd.ExecuteNonQuery();
    }
   
    public DataTable GetDataTable(String querystr)
    {
        SqlDataAdapter ada = new SqlDataAdapter(querystr, con);
        DataTable dt = new DataTable();
        ada.Fill(dt);
        return dt;
    }
    public void FillGridView(string querystr, GridView grid)
    {
        DataTable dt = GetDataTable(querystr);
        grid.DataSource = dt;
        grid.DataBind();
    }
    public void FillDataList(string querystr, DataList list)
    {
        DataTable dt = GetDataTable(querystr);
        list.DataSource = dt;
        list.DataBind();
    }
    public void FillDetailsView(string querystr, DetailsView list)
    {
        DataTable dt = GetDataTable(querystr);
        list.DataSource = dt;
        list.DataBind();
    }
    public void FillDrop(DropDownList drop, string display, string valfield, string tbl)
    {
        string str = "select " + display + "," + valfield + " from " + tbl + "";
        DataTable dt1 = GetDataTable(str);
        drop.DataSource = dt1;
        drop.DataTextField = display;
        drop.DataValueField = valfield;
        drop.DataBind();
        drop.Items.Insert(0, "--SELECT--");
    }
    public void FillDrop(DropDownList dd1, string display, string valfield, string tbl, string condition1)
    {
        string str = "select * from " + tbl + " where " + condition1 + "";
        DataTable dt1 = new DataTable();
        dt1 = GetDataTable(str);
        dd1.DataSource = dt1;
        dd1.DataTextField = display;
        dd1.DataValueField = valfield;
        dd1.DataBind();
        dd1.Items.Insert(0, "--SELECT--");
    }
    public void FillCheck(CheckBoxList chk, string display, string valfield, string tbl)
    {
        string str = "select " + display + "," + valfield + " from " + tbl + "";
        DataTable dt1 = GetDataTable(str);
        chk.DataSource = dt1;
        chk.DataTextField = display;
        chk.DataValueField = valfield;
        chk.DataBind();
    }
    public void FillCheck(CheckBoxList chk, string display, string valfield, string tbl, string condition1)
    {
        string str = "select " + display + "," + valfield + " from " + tbl + " where " + condition1 + "";
        DataTable dt1 = new DataTable(str);
        chk.DataSource = dt1;
        chk.DataTextField = display;
        chk.DataValueField = valfield;
        chk.DataBind();
    }

    public void FillRadio(RadioButtonList rdb, string display, string valfield, string tbl)
    {
        string str = "select " + display + "," + valfield + " from " + tbl + "";
        DataTable dt1 = GetDataTable(str);
        rdb.DataSource = dt1;
        rdb.DataTextField = display;
        rdb.DataValueField = valfield;
        rdb.DataBind();
    }
    public void FillRadio(RadioButtonList rdb, string display, string valfield, string tbl, string condition1)
    {
        string str = "select " + display + "," + valfield + " from " + tbl + "";
        DataTable dt1 = GetDataTable(str);
        rdb.DataSource = dt1;
        rdb.DataTextField = display;
        rdb.DataValueField = valfield;
        rdb.DataBind();
    }
}
		//
		// TODO: Add constructor logic here
		//

