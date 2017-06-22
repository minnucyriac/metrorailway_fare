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


public partial class Admin_Default : System.Web.UI.Page
{
    Cls_Metro obj = new Cls_Metro();
    NBioAPI m_NBioAPI;
    NBioAPI.IndexSearch m_IndexSearch;
    DataTable dtbl;
    DataTable newDT;
    string db_filename = "";
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            filldrop();
            
        }

        m_NBioAPI = new NBioAPI();
        m_IndexSearch = new NBioAPI.IndexSearch(m_NBioAPI);
        
        table_creater();
    }
     public void filldrop()
    {
        obj.FillDrop(drptrain, "train_name", "train_id", "tbl_train");
        obj.FillDrop(drpsource, "station_name", "station_no"," tbl_station");

        
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

    protected void btnsave_Click(object sender, EventArgs e)
    {
        String sel="select * from tbl_userreg where user_username='"+txtuname.Text+"'";
        DataTable dt = obj.GetDataTable(sel);


       
        string selq = " select * from tbl_aadhar where userdb_aadharno='" +dt.Rows[0]["user_aadharno"]+ "' ";

        DataTable dtt = obj.GetDataTable(selq);
        db_filename = dtt.Rows[0]["filename"].ToString();
        Session["aadharno"] = dtt.Rows[0]["userdb_aadharno"];
        string[] array = db_filename.Split('.');
        db_filename = array[0];

        loadDb_fromSystem();



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
            Response.Write("" + ret);
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
            lblsource.Text = "The FingerPrint does not match!!";
            return;
        }

        // Add item to list of result

        String ins = "insert into tbl_punch(punch_trainid,punch_sname,punch_dname,punch_aadharno,punch_dist,punch_tickets,punch_amt,punch_date)values('" + drptrain.SelectedValue + "','" + drpsource.SelectedValue + "','0','" + Session["aadharno"] + "','0','" + txttickets.Text + "','0','" + DateTime.Now.ToShortDateString() + "')";
        obj.ExecuteCommand(ins);
        string selID = "select max(punch_id) as pid from tbl_punch where punch_aadharno='" + Session["aadharno"] + "'";
        DataTable dt1 = obj.GetDataTable(selID);
        string sel = "select * from tbl_punch where punch_aadharno='" + Session["aadharno"] + "' and punch_id='"+dt1.Rows[0]["pid"]+"'";
        DataTable dt = obj.GetDataTable(sel);
        string selI = "select train_vcapacity from tbl_train where train_id='" + dt.Rows[0]["punch_trainid"] + "'";
        DataTable dt11 = obj.GetDataTable(selI);
        if (Convert.ToInt32(dt11.Rows[0]["train_vcapacity"]) > 0)
        {
            Double a = Convert.ToInt32(dt11.Rows[0]["train_vcapacity"]) - Convert.ToInt32(dt.Rows[0]["punch_tickets"]);
            String se = "update tbl_train set train_vcapacity='"+a+"' where train_id='" + dt.Rows[0]["punch_trainid"] + "'";
            obj.ExecuteCommand(se);
            Session["valid"] = Convert.ToInt32(dt1.Rows[0]["pid"]);
            Session["source"] = drpsource.SelectedValue;
            Response.Write("success");
            //Label1.Text = Convert.ToString(Session["source"]);
            Response.Redirect("welcome.aspx");
        }
        else
        {
            Response.Write("<script>alert('Insufficient Seats')</script>");
        }



    }

    public uint myCallback(ref NBioAPI.IndexSearch.CALLBACK_PARAM_0 cbParam0, IntPtr userParam)
    {
        return NBioAPI.IndexSearch.CALLBACK_RETURN.OK;
    }  


}