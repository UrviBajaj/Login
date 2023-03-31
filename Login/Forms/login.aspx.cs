using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Configuration;


namespace Login
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(modGlobal.ConStr);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from logindb where username='"+ txtUserName.Text+"' and password ='"+ txtPassword.Text+"'");
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    lblMessage.Text = "Login Sucess......!!";
                    lblMessage.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    lblMessage.Text = "UserId & Password Is not correct Try again..!!";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }

            }
            catch (Exception ex)
            {
                lblMessage.Text= ex.Message;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        
        }
    }
}