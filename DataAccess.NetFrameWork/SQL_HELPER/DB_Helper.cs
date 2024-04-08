using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetFrameWork.SQL_HELPER
{
    public static class DB_Helper
    {

        public static SqlConnection GetSqlConnection()
        {
            

            var connStr = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            var conn = new SqlConnection(connStr);
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            return conn;
        }
    }
}
