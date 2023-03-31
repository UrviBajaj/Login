using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Login
{
    public class modGlobal
    {
       public static string ConStr  = WebConfigurationManager.ConnectionStrings["dbconnection"].ToString();


    }
}