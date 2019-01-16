using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ClassLibrary
{
    public class DataBase
    {
        private string strConn1 = string.Format("server={0};user={1};password={2};database={3};", "192.168.3.130", "root", "1234", "test");
        private string strConn2 = string.Format("server={0};user={1};password={2};database={3};", "192.168.3.151", "root", "1234", "ubun");

        public MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = strConn1;
                conn.Open();
                return conn;
            }
            catch ( MySqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
