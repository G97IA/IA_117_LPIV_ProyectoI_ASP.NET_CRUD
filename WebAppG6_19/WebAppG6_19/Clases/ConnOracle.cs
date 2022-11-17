using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;

namespace WebAppG6_19.Clases
{
    public class ConnOracle
    {
        public static string ConexionOracle()
        {
            return "Data Source= (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 20.102.84.24)(PORT = 1521)))" +
            "(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); User Id = G6_19; Password = D7OEynOQ;";
        }
    }
}