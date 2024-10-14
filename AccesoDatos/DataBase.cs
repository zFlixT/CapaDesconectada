using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class DataBase
    {
        public static string ConnectionString
        {
            get {
                return ConfigurationManager.ConnectionStrings["NWConnection"].ConnectionString;}
        }

        public static SqlConnection GetSqlConnection()
        {
            SqlConnection conexion = new SqlConnection(ConnectionString);
            conexion.Open();
            return conexion;
        }
    }
}
