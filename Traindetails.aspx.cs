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
    public static double eid,f=0;
 
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillgrid();
        }

    }
    protected void grid_train_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        eid = Convert.ToInt32(e.CommandArgument);
        if (e.CommandName == "edt")
        {
            f = 1;
            string sel = "select * from tbl_train where train_id='"+eid+"'";
            DataTable dt=obj.GetDataTable(sel);
            txttname.Text=Convert.ToString(dt.Rows[0]["train_name"]);
            txtcapacity.Text=Convert.ToString(dt.Rows[0]["train_capacity"]);
        }
        if(e.CommandName=="del")
        {
            string del="delete from tbl_train where train_id='"+eid+"'";
            obj.ExecuteCommand(del);
            fillgrid();
            Response.Write("<script>alert('Deleted successfully')</script>");
        }
    }
   protected void btnsave_Click(object sender, EventArgs e)
   {
       if(f==0)
       {
       string ins="insert into tbl_train (train_name,train_capacity) values('"+txttname.Text+"','"+txtcapacity.Text+"')";
        obj.ExecuteCommand(ins);
        fillgrid();
        txttname.Text = " ";
        txtcapacity.Text = " ";
       }
       else
       {
           string up="update tbl_train set train_name='"+txttname.Text+"',train_capacity='"+txtcapacity.Text+"' where train_id='"+eid+"'";
           obj.ExecuteCommand(up);
           f=0;
           fillgrid();
           Response.Write("<script>alert('Updated successfully')</script>");
       }
   }
    public void fillgrid()
    {
        string sel="select * from tbl_train";
        obj.FillGridView(sel,grid_train);
    }
}