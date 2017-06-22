using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Guest_Default : System.Web.UI.Page
{
    Cls_metro obj = new Cls_metro();
    public static int f ;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (f == 0)
            {
                Panel1.Visible = false;
                Button1.Visible = true;

            }
            else {
                Panel1.Visible = true;
                Button1.Visible = false;
                string sel = "select * from tbl_userreg where user_id='" + Session["userid"] + "'";
                DataTable dt = obj.GetDataTable(sel);
                string sele="select * from tbl_vallet where vallet_id='"+Session["valid"]+"'";
                DataTable dtt = obj.GetDataTable(sele);
                if (dt.Rows.Count > 0)
                {

                    txtfname.Text = dt.Rows[0]["user_fname"].ToString();
                    txtmname.Text = dt.Rows[0]["user_mname"].ToString();
                    txtlname.Text = dt.Rows[0]["user_lname"].ToString();
                    txteid.Text = dt.Rows[0]["user_email"].ToString();
                    txtcontactno.Text = dt.Rows[0]["user_contactno"].ToString();
                    txtvallet.Text = dtt.Rows[0]["val_amount"].ToString();
                    radgen.SelectedValue = dt.Rows[0]["user_gender"].ToString();
                }
            
            }
        }
     
    }
    protected void btnsubmit_Click(object sender, EventArgs e)

    {
      
    }
   protected void txtadarno_TextChanged(object sender, EventArgs e)
    {
        string sel = "select * from tbl_userreg where user_aadharno='"+txtadarno.Text+"'";
        DataTable dt = obj.GetDataTable(sel);
        if (dt.Rows.Count >0)
        {
            
            Response.Write("<script>alert('User already exist')</script>");
        }
    }
    protected void txtbname_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string ins = "insert into tbl_userreg(user_fname,user_mname,user_lname,user_gender,user_email,user_contactno,user_aadharno,user_username,user_password,user_sqstn,user_answer)values('" + txtfname.Text +"', ' " + txtmname.Text + "', '" + txtlname.Text + "','" + radgen.SelectedValue + "','" + txteid.Text + "','"+txtcontactno.Text+"','" + 0 + "','" +0 + "','" + 0 + "','"+0+"','"+0+"')";
        obj.ExecuteCommand(ins);
        string sel = "select max(user_id) as id from tbl_userreg";
        DataTable dt = obj.GetDataTable(sel);
        if (dt.Rows.Count > 0)
        {
            Session["userid"] = dt.Rows[0]["id"].ToString();
            Session["amount"] = txtvallet.Text;
            f = 1;
           Response.Redirect("~/Guest/Payment1/First.aspx");
        }
        
    }
    protected void btnsav_Click(object sender, EventArgs e)
    {
        string up = "update tbl_userreg set user_username='" + txtuname.Text + "',user_password='" + txtpswd.Text + "',user_aadharno='" + txtadarno.Text + "',user_sqstn='"+drpsqstn.SelectedValue+"',user_answer='"+txtanswer.Text+"' where user_id='" + Session["userid"] + "'";
        obj.ExecuteCommand(up);
        string upd = "update tbl_vallet set useradhar_no='" + txtadarno.Text + "' where vallet_id= '" + Session["valid"] + "'";
        obj.ExecuteCommand(upd);
        f = 0;
        Response.Write("<script>alert('inserted successfully')</script>");
        //Response.Redirect("~/Guest/New user.aspx");
    }
    protected void txtuname_TextChanged(object sender, EventArgs e)
    {
        string sel = "select * from tbl_userreg where user_username='" + txtuname.Text + "'";
        DataTable dt = obj.GetDataTable(sel);
        if (dt.Rows.Count > 0)
        {

            Response.Write("<script>alert('Username already exist')</script>");
        }
    }
}