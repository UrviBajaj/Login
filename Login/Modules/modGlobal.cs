using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace Login
{
    public class modGlobal
    {
       private static string ConStr  = WebConfigurationManager.ConnectionStrings["dbconnection"].ToString();
       private static SqlConnection con = new SqlConnection(ConStr);
        public static bool ValidateConnection(string UserName, string Password)
        {
              con.Open();
              SqlCommand cmd = new SqlCommand("select * from logindb where username='" + UserName + "' and password ='" + Password + "'");
              SqlDataReader sdr = cmd.ExecuteReader();
            try
            {

                if (sdr.Read())
                {
                    return true;
                }
                else
                {
                   return false;
                }

            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }


    }
}