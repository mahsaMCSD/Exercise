using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Web.Configuration;

/// <summary>
/// Summary description for DAL
/// </summary>
public static class DAL
{
    public static SqlConnection scon()
    {
        SqlConnection scon = new SqlConnection(WebConfigurationManager.ConnectionStrings["strPcia"].ConnectionString);
        scon.Open();
        return scon;
    }
    public static int ExecutenonQuery(SqlCommand scom)
    {
        int ok = 0;
        scom.Connection = scon();
        scom.ExecuteNonQuery();
        scon().Close();
        scom.Dispose();
        return ok;
    }
}