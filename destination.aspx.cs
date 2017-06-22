using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using NITGEN.SDK.NBioBSP;
using System.IO;
using System.Net.Mail;

public partial class Admin_Default : System.Web.UI.Page
{
    Cls_Metro obj = new Cls_Metro();
    NBioAPI m_NBioAPI;
    NBioAPI.IndexSearch m_IndexSearch;
    DataTable dtbl;
    DataTable newDT;
    string db_filename = "";
    public static double amt;
    public static double a;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            filldrop();

        }
        
        m_NBioAPI = new NBioAPI();
        m_IndexSearch = new NBioAPI.IndexSearch(m_NBioAPI);
        //con.Open();
        table_creater();
       
    }
    public void table_creater()
    {
        dtbl = new DataTable();
        dtbl.Columns.Add(new DataColumn("UserID", typeof(Int32)));
        dtbl.Columns.Add(new DataColumn("Fp ID", typeof(Int32)));
        dtbl.Columns.Add(new DataColumn("Sample No", typeof(Int32)));
        dtbl.AcceptChanges();
        Session["tempSession"] = dtbl;

    }
    public void filldrop()
    {
        obj.FillDrop(drpdest, "station_name", "station_no", " tbl_station");

    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
         
        String selec="select * from tbl_userreg where user_username='"+txtuname.Text+"'";
        DataTable d = obj.GetDataTable(selec);
        string selq = " select * from tbl_aadhar where userdb_aadharno='" + d.Rows[0]["user_aadharno"] + "' ";

        DataTable dtp = obj.GetDataTable(selq);
        db_filename = dtp.Rows[0]["filename"].ToString();
        string[] array = db_filename.Split('.');
        db_filename = array[0];

        loadDb_fromSystem();

        //String up = "update tbl_punch set punch_dname='" + drpdest.SelectedValue + "' where punch_aadharno='" + Session["aadharno"] + "'";
        //obj.ExecuteCommand(up);
        //String se = "select * from tbl_station where station_no='" + drpdest.SelectedValue + "'";
        //DataTable st = obj.GetDataTable(se);
        //lblsource.Text = Convert.ToString(drpdest.SelectedValue);
        //lblsource.Text = Convert.ToString(Session["source"]);
        //String see = "select * from tbl_station where station_no='" + Session["source"] + "'";
        //DataTable stt = obj.GetDataTable(see);
        //string sel = "select * from tbl_route p,tbl_punch q where p.route_from='" + stt.Rows[0]["station_name"] + "' and p.route_to='" + st.Rows[0]["station_name"] + "'";
        //DataTable dt = obj.GetDataTable(sel);
        //Double r = Convert.ToInt32(dt.Rows[0]["route_distance"]);
        //String sele = "select * from tbl_rate where distance='" + r + "'";
        //DataTable dtt = obj.GetDataTable(sele);
        //Double amt = Convert.ToInt32(dtt.Rows[0]["rate"]);
        //string upp = "update tbl_punch set punch_dist='" + r + "',punch_amt='" + amt + "' where punch_aadharno='" + Session["aadharno"] + "'";
        //obj.ExecuteCommand(upp);
        //Response.Redirect("thanks.aspx");
        //Response.Write("success");

      
        
 
    }
     public void loadDb_fromSystem()
    {
        
        string filepath = Server.MapPath("~/data/");
        uint ret = m_IndexSearch.InitEngine();
        string szFileName = filepath + "" + db_filename + ".ISDB";
        m_IndexSearch.ClearDB();
        uint ret_load = NBioAPI.Error.NONE;
        ret_load = m_IndexSearch.LoadDBFromFile(szFileName);
        if (ret_load != NBioAPI.Error.NONE)
        {
            Response.Write("File not found ");
            return;
        }

        filepath = Server.MapPath("~/data/");
        szFileName = filepath + "" + db_filename + ".FID";

        FileStream fs = new FileStream(szFileName, FileMode.Open, FileAccess.Read);
        StreamReader fr = new StreamReader(fs);
        while (fr.Peek() >= 0)
        {
            try
            {
                string szLine = fr.ReadLine();
                string[] szSplit = szLine.Split('\t');

                newDT = new DataTable();
                newDT = dtbl;
                DataRow row = newDT.NewRow();
                row["UserID"] = szSplit[0];
                row["Fp ID"] = szSplit[1];
                row["Sample No"] = szSplit[2];
                newDT.Rows.Add(row);
                newDT.AcceptChanges();


            }
            catch (Exception erp)
            {
                Response.Write("Error" + erp);
            }
        }

        fr.Close();
        fs.Close();


        //GridView1.DataSource = newDT;
        //GridView1.DataBind();

        DataTable temp_data = newDT;
        Session["tempSession"] = temp_data;

        Identify_user();

    }



   


    public void Identify_user()
    {

        NBioAPI.Type.HFIR hCapturedFIR;
        // Get FIR data
        m_NBioAPI.OpenDevice(NBioAPI.Type.DEVICE_ID.AUTO);
        uint ret = m_NBioAPI.Capture(out hCapturedFIR);
        if (ret != NBioAPI.Error.NONE)
        {
            Response.Write(""+ret);
            m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);
            return;
        }

        m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);


        uint nMax;
        m_IndexSearch.GetDataCount(out nMax);
       

        NBioAPI.IndexSearch.CALLBACK_INFO_0 cbInfo0 = new NBioAPI.IndexSearch.CALLBACK_INFO_0();
        cbInfo0.CallBackFunction = new NBioAPI.IndexSearch.INDEXSEARCH_CALLBACK(myCallback);

        // Identify FIR to IndexSearch DB
        NBioAPI.IndexSearch.FP_INFO fpInfo;
        ret = m_IndexSearch.IdentifyData(hCapturedFIR, NBioAPI.Type.FIR_SECURITY_LEVEL.NORMAL, out fpInfo, cbInfo0);
        if (ret != NBioAPI.Error.NONE)
        {
            //Response.Write("" + ret);
            lbldest.Text = "The FingerPrint does not match!!";
            return;
        }

        // Add item to list of result
        String sell = "select * from tbl_userreg where user_username='" + txtuname.Text + "'";
        DataTable dt2 = obj.GetDataTable(sell);



        string selq = " select * from tbl_aadhar where userdb_aadharno='" + dt2.Rows[0]["user_aadharno"] + "' ";

        DataTable dtt1 = obj.GetDataTable(selq);
        string selID = "select max(punch_id) as pid from tbl_punch where punch_aadharno='" + dt2.Rows[0]["user_aadharno"] + "'";
        DataTable dt1 = obj.GetDataTable(selID);
        string selI = "select * from tbl_punch where punch_id='" + dt1.Rows[0]["pid"] + "'";
        DataTable dt11 = obj.GetDataTable(selI);

        Session["valid"] = Convert.ToInt32(dt1.Rows[0]["pid"]);
        Session["aadharno"] = Convert.ToInt32(dtt1.Rows[0]["userdb_aadharno"]);
        String up = "update tbl_punch set punch_dname='" + drpdest.SelectedValue + "' where punch_id='"+Session["valid"]+"'";
        obj.ExecuteCommand(up);

        String se = "select * from tbl_station where station_no='" + drpdest.SelectedValue + "'";
        DataTable st = obj.GetDataTable(se);
        
        String see = "select * from tbl_station where station_no='" + dt11.Rows[0]["punch_sname"] + "'";
        DataTable stt = obj.GetDataTable(see);
        String sel = "select * from tbl_route where route_from='" + stt.Rows[0]["station_name"] + "' and route_to='" + st.Rows[0]["station_name"] + "'";
        DataTable dt = obj.GetDataTable(sel);
        Double r = Convert.ToDouble(dt.Rows[0]["route_distance"]);
        
        String sele = "select * from tbl_rate where distance=" + dt.Rows[0]["route_distance"] + "";
        DataTable dtt = obj.GetDataTable(sele);
        Double amt = Convert.ToInt32(dtt.Rows[0]["rate"]) * Convert.ToInt32(dt11.Rows[0]["punch_tickets"]);
        
        String ss = "select * from tbl_vallet where useradhar_no='" + Session["aadharno"] + "'";
        DataTable val=obj.GetDataTable(ss);
        double rr = Convert.ToInt32(val.Rows[0]["val_amount"]);
        rr = rr - amt;
        
        String upp = "update tbl_punch set punch_dist='" + dt.Rows[0]["route_distance"] + "',punch_amt='" + amt + "' where punch_aadharno='" + Session["aadharno"] + "' and punch_id='" + Session["valid"] + "'";
        obj.ExecuteCommand(upp);
        string selI2 = "select train_vcapacity from tbl_train where train_id='" + dt11.Rows[0]["punch_trainid"] + "'";
        DataTable dt112 = obj.GetDataTable(selI2);
        Double a2 = Convert.ToInt32(dt112.Rows[0]["train_vcapacity"]) + Convert.ToInt32(dt11.Rows[0]["punch_tickets"]);
        String sep = "update tbl_train set train_vcapacity='"+a2+"' where train_id='" + dt11.Rows[0]["punch_trainid"] + "'";
        obj.ExecuteCommand(sep);


        if (rr > 0)
        {
            String str = "update tbl_vallet set val_amount='" + rr + "' where useradhar_no='" + Session["aadharno"] + "'";
            obj.ExecuteCommand(str);
            Mail();
            
            Response.Redirect("thanks.aspx");
            //Response.Write("success");
        }
        else
        {
            Response.Write("<script>alert('Insufficient Balance')</script>");
        }






        



    }

    public uint myCallback(ref NBioAPI.IndexSearch.CALLBACK_PARAM_0 cbParam0, IntPtr userParam)
    {
        return NBioAPI.IndexSearch.CALLBACK_RETURN.OK;
    }
    private void Mail()
    {
        string selEmail = "select user_email from tbl_userreg where user_username='" + txtuname.Text + "'";
        DataTable dtEmail = obj.GetDataTable(selEmail);
        String sell = "select * from tbl_userreg where user_username='" + txtuname.Text + "'";
        DataTable dt2 = obj.GetDataTable(sell);



        string selq = " select * from tbl_vallet where useradhar_no='" + dt2.Rows[0]["user_aadharno"] + "' ";

        DataTable dtt1 = obj.GetDataTable(selq);
        string selID = "select max(punch_id) as pid from tbl_punch where punch_aadharno='" + dt2.Rows[0]["user_aadharno"] + "'";
        DataTable dt1 = obj.GetDataTable(selID);
        string selI = "select * from tbl_punch where punch_id='" + dt1.Rows[0]["pid"] + "'";
        DataTable dt11 = obj.GetDataTable(selI);
        amt = Convert.ToDouble(dt11.Rows[0]["punch_amt"]);
        a= Convert.ToDouble(dtt1.Rows[0]["val_amount"]);
        string EmailID = "";
        if (dtEmail.Rows.Count > 0)
        {
            EmailID = dtEmail.Rows[0]["user_email"].ToString();

            ////Email Sendind Code

            MailMessage mail = new MailMessage();
            mail.To.Add(EmailID);
            mail.From = new MailAddress("macekochimetro@gmail.com");
            mail.Subject = "Amount Deducted!!";

            string Body = "Rs. "+amt+" has been deducted from your account. Your current balance is "+a+"\n ";
            mail.Body = Body;

            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new System.Net.NetworkCredential("macekochimetro@gmail.com", "kochimetro");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(mail);
            //Label1.Text = "Password send to u r mail...";
        }

    }


}