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
       private string ConStr  = WebConfigurationManager.ConnectionStrings["dbconnection"].ToString();
       private SqlConnection con = new SqlConnection(ConStr);
        public bool ValidateConnection(string UserName, string Password)
        {
              //con.Open();
              //SqlCommand cmd = new SqlCommand("select * from logindb where username='" + UserName + "' and password ='" + Password + "'");
               da = new SQLDataAdapter("select * from logindb where username='" + UserName + "' and password ='" + Password + "'",con);
              DataSet ds = new DataSet();
            da.Fill(ds);
            try
            {

                if (ds.Tables[0].Rows.Count>0)
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
                da.Dispose();
                ds.Dispose();
                con.Close();
                con.Dispose();
            }
        }


    }
}
