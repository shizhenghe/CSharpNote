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
    public partial class Login : Form
    {
        public int AutoStatu;
        public Login()
        {
            InitializeComponent();
            if(passwordTB.Text == "Password")
            {
                eye.Enabled = false;
            }
            string constr = "server=localhost; User Id = root; password = 2571834079; Database = csharp";
            MySqlConnection con = new MySqlConnection(constr);

            try
            {
                con.Open();
                string sqlcom = "select * from close order by InsTim DESC limit 1;";
                MySqlCommand cmd = new MySqlCommand(sqlcom, con);
                cmd.Connection = con;
                //MySqlDataReader reader = cmd.ExecuteReader();
                //sqlcom = "select * from close ;";
                //cmd = new MySqlCommand(sqlcom, con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet dt = new DataSet();
                da.Fill(dt, "close");

                foreach(DataRow row in dt.Tables["close"].Rows)
                {
                    usernameTB.Text = row["name"].ToString();
                    if(Convert.ToInt32(row["Auto"]) == 1)
                    {
                        AutoStatu = Convert.ToInt32(row["Auto"]);
                        passwordTB.PasswordChar = '*';
                        passwordTB.Text = row["password"].ToString();
                        checkBox1.Checked = true;
                    }
                    if(Convert.ToInt32(row["Hold"]) == 1)
                    {
                        passwordTB.PasswordChar = '*';
                        eye.Enabled = false;
                        passwordTB.Text = row["password"].ToString();
                        checkBox2.Checked = true;
                    }
                }
                con.Close();
            }
            catch (MySqlException)
            {

            }
        }

        //object[] reserve = new object[2];

        public string uname, upwd;

        public void Confirm()
        {
            string account = this.usernameTB.Text;
            string password = this.passwordTB.Text;

            if (account.Equals("") || password.Equals(""))
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
            else
            {
                string constructorString = "server=localhost; User Id = root; password = 2571834079; Database = csharp";
                MySqlConnection con = new MySqlConnection(constructorString);
                try
                {
                    con.Open();
                    string sqlcmd = "select * from csharp.stone where name = '" + account + "' and password = '" + password + "'";
                    MySqlCommand cmd = new MySqlCommand(sqlcmd, con);
                    if (Convert.ToString(cmd.ExecuteScalar()) != "")
                    {
                        //sign.DialogResult = DialogResult.OK;
                        Fisher edit = new Fisher();
                        this.Hide();
                        edit.Show();

                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误！");

                    }
                }
                catch (MySqlException)
                {
                    MessageBox.Show("打开数据库失败！");
                    //return 0;
                }
            }
        }

        private void Register_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            register reg = new register();
            reg.ShowDialog();
        }

        private void passwordTB_Click_1(object sender, EventArgs e)
        {
            if (passwordTB.Text == "Password" && passwordTB.Focused)
            {
                passwordTB.ForeColor = Color.Black;
                passwordTB.Text = "";
                passwordTB.PasswordChar = '*';
            }
        }   

        private void passwordTB_LostFocus1(object sender, System.EventArgs e)
        {
            if (passwordTB.Text.Equals(""))
            {
                passwordTB.ForeColor = Color.Gray;
                passwordTB.PasswordChar = '\0';
                passwordTB.Text = "Password";
            }
        }

        private void usernameTB_Click_1(object sender, EventArgs e)
        {
            if (usernameTB.Text == "Account" && usernameTB.Focused)
            {
                usernameTB.Text = "";
                usernameTB.ForeColor = Color.Black;
            }
        }

        private void usernameTB_LostFocus1(object sender, System.EventArgs e)
        {
            if (usernameTB.Text.Equals(""))
            {
                usernameTB.ForeColor = Color.Gray;
                usernameTB.Text = "Account";
            }
        }

        int counteye = 0;
        private EventArgs e;

        private void eye_Click_1(object sender, EventArgs e)
        {
            if(counteye == 0)
            {
                passwordTB.PasswordChar = '\0';
                counteye = 1;
            }
            else
            {
                passwordTB.PasswordChar = '*';
                counteye = 0;
            }
                
        }
        

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.search.Links[0].LinkData = "http://www.baidu.com";
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        

        private void sign_Click(object sender, EventArgs e)
        {
            Confirm();
 
            uname = this.usernameTB.Text;
            upwd = this.passwordTB.Text;

            if (usernameTB.Text != "" && passwordTB.Text != "")
            {
                string constr = "server=localhost; User Id = root; password = 2571834079; Database = csharp";

                MySqlConnection con = new MySqlConnection(constr);
                try
                {
                    con.Open();
                    string sqlcom = "insert into river(name, password) values (@name, @password)";
                    MySqlCommand cmd = new MySqlCommand(sqlcom, con);
                    cmd.Parameters.AddWithValue("@name", uname);
                    cmd.Parameters.AddWithValue("@password", upwd);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                catch (MySqlException)
                {

                }
            }

            HoldMsg();
        }

        public void HoldMsg()
        {
            bool Auto, Hold;
            Auto = this.checkBox1.Checked;
            Hold = this.checkBox2.Checked;
            DateTime date = new DateTime();
            //DataFormats simpleDateFormat = new DataFormats.Format("yyyy-MM-dd HH:mm:ss");
            //DateTime simpleDateFormat = new DateTime.SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
            String time = DateTime.Now.ToLongTimeString();
            date = Convert.ToDateTime(time);
            //punchTime = simpleDateFormat.format(date);
            if (this.checkBox2.Checked == true)
            {
                string constr = "server=localhost; User Id = root; password = 2571834079; Database = csharp";

                MySqlConnection con = new MySqlConnection(constr);
                try
                {
                    con.Open();
                    string sqlcom = "insert into close(Auto, Hold, name, password, InsTim) values (@auto, @hold, @name, @password, @instim)";
                    MySqlCommand cmd = new MySqlCommand(sqlcom, con);
                    //cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@auto", Auto);
                    cmd.Parameters.AddWithValue("@hold", Hold);
                    cmd.Parameters.AddWithValue("@name", this.usernameTB.Text);
                    cmd.Parameters.AddWithValue("@password", this.passwordTB.Text);
                    cmd.Parameters.AddWithValue("@instim", date);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    //Application.Exit();
                }
                catch (MySqlException)
                {

                }
            }
            else
            {

            }
        }

        private void admin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admlogin AdmLogin = new admlogin();
            AdmLogin.Text = "admlogin";
            this.Hide();
            AdmLogin.Show();
        }

        private void passwordTB_TextChanged_1(object sender, EventArgs e)
        {
            if (passwordTB.Text != "Password" && passwordTB.Text != "")
            {
                eye.Enabled = true;
            }
            else
            {
                eye.Enabled = false;
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                this.sign_Click(sender, e);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            /*
             if(checkBox2.Checked)
             {
                 string username = this.usernameTB.Text;
                 string password = this.passwordTB.Text;

                 if (usernameTB.Text != "" && passwordTB.Text != "")
                 {
                     string constr = "server=localhost; User Id = root; password = 2571834079; Database = csharp";

                     MySqlConnection con = new MySqlConnection(constr);
                     try
                     {
                         con.Open();
                         /*
                         string sqlcom = "insert into river(name, password) values (@name, @password)";
                         MySqlCommand cmd = new MySqlCommand(sqlcom, con);
                         cmd.Parameters.AddWithValue("@name", username);
                         cmd.Parameters.AddWithValue("@password", password);
                         cmd.ExecuteNonQuery();
                         cmd.Dispose();*/
            /*
            string sqlcom = "select * from csharp.river where name = '" + username + "' and password = '" + password + "'";
            //cmd = new MySqlCommand(sqlcom, con);
            DataSet ds = new DataSet(); 
            MySqlDataAdapter da = new MySqlDataAdapter(sqlcom, con);
            da.Fill(ds, "ds");
            con.Close();
            if(ds.Tables.Count > 0)
            {
                usernameTB.Text = ds.Tables[0].ToString();
                passwordTB.Text = ds.Tables[1].ToString();
            }
            //usernameTB.DataSource = ds.Tables[1];
            //passwordTB. = ds.Tables[1];

        }
        catch (MySqlException)
        {

        }*/
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            /*
            calculator auto = new calculator();
            this.Hide();
            auto.Show();*/

        }
      
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //reserve[0] = this.usernameTB.Text;
            //reserve[1] = this.passwordTB.Text;
            //checkBox1.Checked = true;
        }

        private void eye_Click(object sender, EventArgs e)
        {
            //passwordTB.PasswordChar = '\0';
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void passwordTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void passwordTB_Leave(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {

        }

        private void usernameTB_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void usernameTB_Click(object sender, EventArgs e)
        {

        }

        private void passwordTB_Click(object sender, EventArgs e)
        {

        }

        private void sign_KeyDown(object sender, KeyEventArgs e)
        {

        }

        internal void Login_FormClosed(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        /*
        private void passwordTB_LostFocus(object sender, System.EventArgs e)
        {
            if (passwordTB.Text.Equals(""))
            {
                passwordTB.ForeColor = Color.Gray;
                passwordTB.PasswordChar = '\0';
                passwordTB.Text = "Password";
            }
        }*/
    }
}
