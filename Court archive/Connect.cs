using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Court_archive
{
    internal class Connect
    {
        public static string connString = Properties.Settings.Default.connString;
        public static SqlConnection connect()
        {
            try {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                return conn;
            }
            catch
            {
                return null;
            }
        }
        public void disconnect(){
            connect().Close();
        }
        public static SqlDataReader user_id;
        
    }
}
