using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Web.Configuration;

/// <summary>
/// Summary description for BAL
/// </summary>
public class BAL
{
    public static string _userName { get; set; }
    public static string _FamilyName { get; set; }
    public static bool _UserEmailActive { get; set; }
   public int InsertData()
    {
        SqlCommand scom = new SqlCommand();
        scom.CommandText = ("insert into tblUser(UserName,UserFamily,UserEmailActive)values(@UserName,@UserFamily,@UserEmailActive)");
        scom.Parameters.AddWithValue("@UserName", _userName);
        scom.Parameters.AddWithValue("@UserFamily", _FamilyName);
        scom.Parameters.AddWithValue("@UserEmailActive", _UserEmailActive);
        return DAL.ExecutenonQuery(scom);

    }
}