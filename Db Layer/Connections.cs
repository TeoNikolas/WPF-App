using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Db_Layer
{
    public class Connections
    {
        /*private string ConnectionString = "Server=localhost;port=3306;username=root;" +
            "password=;database=requirement_management_system;Sslmode=none;"; */

        private MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=mydb;port=3306;password=160304;");
        public MySqlConnection GetConnection()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public int ExeNonQuery(MySqlCommand cmd)
        {
            cmd.Connection = GetConnection();
            int rowsaffected = -1;
            rowsaffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsaffected;
        }

        public object ExeScalar(MySqlCommand cmd)
        {
            cmd.Connection = GetConnection();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            con.Close();
            return obj;
        }

        public DataTable ExeReader(MySqlCommand cmd)
        {
            cmd.Connection = GetConnection();
            MySqlDataReader mydr;
            DataTable dt = new DataTable();
            mydr = cmd.ExecuteReader();
            dt.Load(mydr);
            con.Close();
            return dt;
        }
    }
}
