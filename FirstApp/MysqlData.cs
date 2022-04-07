using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace FirstApp
{
    public class MysqlData
    {
        private string constr = "server = localhost; User Id = root; password = 2571834079; Database = csharp; pooling = false; Charset = utf8; port = 3306";

        public DataSet ExecuteQuery(string sqlstr)
        {
            //查
            MySqlCommand cmd;
            MySqlConnection con;
            MySqlDataAdapter msda;
            con = new MySqlConnection(constr);
            con.Open();
            cmd = new MySqlCommand(sqlstr, con);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            DataSet ds = new DataSet();
            msda = new MySqlDataAdapter(cmd);
            msda.SelectCommand = cmd;
            msda.Fill(ds, "stone");
            con.Close();
            return ds;
        }

        public int ExecuteUpdata(string sqlstr)
        {
            //增改删
            MySqlCommand cmd;
            MySqlConnection con;
            con = new MySqlConnection(constr);
            con.Open();
            cmd = new MySqlCommand(sqlstr, con);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            int iud = 0;
            iud = cmd.ExecuteNonQuery();
            con.Close();
            return iud;
        }
    }
}
