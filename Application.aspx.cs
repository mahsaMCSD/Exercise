using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class Application : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnSend_Click(object sender, EventArgs e)
    {
        try
        {
            BAL myBAL = new BAL();
            BAL._userName = txtUserName.Text.Trim();
            BAL._FamilyName = txtFamilyName.Text.Trim();
            BAL._UserEmailActive = false;

            int ok = myBAL.InsertData();
            if (ok > 0)
            {
                Response.Write("ثبت نام با موفقیت انجام شد");
            }
            else
            {
                Response.Write("ثبت نام با مشکل مواجه گردیده است!");
            }
        }
        catch (Exception Err)
        {
            Response.Write("امکان استفاده از سیستم وجود ندارد");
        }

    }
}