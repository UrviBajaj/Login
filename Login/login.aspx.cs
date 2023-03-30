using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Configuration;
using System.Reflection.Emit;

namespace Login
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["dbconnection"].ToString());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from logindb where username='"txtUsername.Text+"' and password ='"+txtPassword.Text"');
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Label4.Text = "Login Sucess......!!";
                }
                else
                {
                    Label4.Text = "UserId & Password Is not correct Try again..!!";

                }
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        }
    }
}