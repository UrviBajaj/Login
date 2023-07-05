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
              SqlCommand cmd = new SqlCommand("usp_Login");
              SqlCommand.CommandType = CommandType.StoredProcedure;
              SqlCommand.Connection = SqlConnection;
                        List<SqlParameter> ParameterList = new List<SqlParameter>()
            {
                        new SqlParameter() { ParameterName = "@UserName", SqlDbType = SqlDbType.nVarChar, Size=50, Value = UserName },
                        new SqlParameter() { ParameterName = "@Password", SqlDbType = SqlDbType.nVarChar, Size=50, Value = Password },
            }
            SqlCommand.Parameters.AddRange(ParameterList.ToArray());
               //da = new SQLDataAdapter("select * from logindb where username='" + UserName + "' and password ='" + Password + "'",con);
            da= new SQLDataAdapter(SqlCommand);
              DataSet ds = new DataSet();
            da.Fill(ds,"UserLogin");
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
