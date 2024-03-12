using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db_Layer;
using Business_Entity_Layer;
using System.Data;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Business_Access_Layer
{
    public class Operations
    {
        public Connections db = new Connections();
        public Informations info = new Informations();
        //here we declare queries and Database operations needed for application

        public int insertUser(Informations info)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO users VALUES ('"+info.username+"','"+info.password+"','"+info.fullname+"','"+info.email+"')";
            return db.ExeNonQuery(cmd);
        }
    }
}
