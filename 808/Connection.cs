using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _808.Services
{
    class Connection
    {

        public static readonly Boolean isPROSERVER = true;
        public static readonly Boolean isERPMAVI = false;
        public static readonly Boolean isMAVIANDROID01 = false;

        /*Donde se conecta*/
        public static String ERPMAVISERVER { get { return isERPMAVI ? "ERPMAVI" : isPROSERVER ? "PROSERVER" : "MAVICUBOS"; } }
        public static String MAVIANDROID01SERVER { get { return isMAVIANDROID01 ? "MAVIANDROID01" : isPROSERVER ? "PROSERVER" : "MAVICBOSANDROID"; } }

        /*Bases de datos*/
        public static readonly String SERVICIOANDROID = "ServicioAndroid";
        public static readonly String INTELISISTMP = "IntelisisTmp";
        public static readonly String ADMINDOC = "AdminDoc";
        public static readonly String SID = "SID";
        public static readonly String SIGMAVI = "SIGMavi";
        public static readonly String COMERCIALIZADORA = "Comercializadora";

        public static String Servidor { get { return isERPMAVI || isMAVIANDROID01 ? "PRODUCCION" : isPROSERVER ? "PROSERVER" : "CUBOS"; } }
        internal static SqlConnection GetConnectionIntelisis()
        {

            SqlConnection con = global::Conexion.ObjetoConexion.getconexion("ERPMAVI", INTELISISTMP);
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(con.ConnectionString)
            {
                ApplicationName = Assembly.GetCallingAssembly().GetName().Name
            };
            con.ConnectionString = builder.ConnectionString;
            con.Open();
            return con;
        }
    }
}
