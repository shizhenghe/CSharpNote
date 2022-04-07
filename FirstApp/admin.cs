using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FirstApp
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            string constr = "server=localhost; User Id = root; password = 2571834079; Database = csharp";
            MySqlConnection con = new MySqlConnection();
            try
            {
                con.Open();
                string cmdstr = "select * from stone;";
                MySqlCommand cmd = new MySqlCommand(cmdstr, con);
                cmd.Connection = con;

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds, "stone");

                dataGridView1.DataSource = ds.Tables["stone"];
                dataGridView1.GridColor = Color.YellowGreen;
                dataGridView1.ScrollBars = ScrollBars.Vertical;

                
            }
            catch(MySqlException)
            {

            }*/
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {
            
        }

        MysqlData con = new MysqlData();
        DataSet ds = new DataSet();

        private void query_Click(object sender, EventArgs e)
        {
            
            
            string sqlstr = "select * from stone";
            
            //con.ExecuteUpdata(sqlstr);
            ds = con.ExecuteQuery(sqlstr);
            //dataGridView1.AutoGenerateColumns = false;        //是否自动生成列， 关闭后可以自己在编辑列里面自定义显示数据
            dataGridView1.DataSource = ds.Tables["stone"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
