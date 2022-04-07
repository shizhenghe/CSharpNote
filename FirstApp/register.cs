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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        public void passwordTB_LostFocus(object sender, System.EventArgs e)
        {

        }

        public void delay(int times)
        {
            int start = Environment.TickCount;
            while(Math.Abs(Environment.TickCount -start) < times)
            {
                Application.DoEvents();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string account = this.usernameTB.Text;
            string password = this.passwordTB.Text;
            string tel = this.telTB.Text;

            //InputHelper Input = new InputHelper(goods_name, remarks_, number_);

            if (account.Equals("") || password.Equals("") || tel.Equals(""))
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
            else
            {
                //" + account + "' and password = '" + password + "
                string constructorString = "server=localhost; User Id = root; password = 2571834079; Database = csharp";
                MySqlConnection con = new MySqlConnection(constructorString);
                try
                {
                    con.Open();
                    //string sqlcmd = "insert into stone (name, password, tel) value (" + account + ", " + password + ", " + tel + ");";
                    string sqlstr = "insert into stone(name,password,tel) values (@name,@password,@tel)";
                    //MySqlConnection mysqlconn = this.getConnection();

                    MySqlCommand cmd = new MySqlCommand(sqlstr, con);
                    cmd.Parameters.AddWithValue("@name", account);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@tel", areanum.Text + tel);
                    cmd.ExecuteNonQuery();              //执行sql语句
                    //int Gid = (int)(cmd.ExecuteScalar());
                    //object obj = cmd.ExecuteScalar();
                    cmd.Dispose();

                    sqlstr = "select * from csharp.stone where name = '" + account + "' and password = '" + password + "'";
                    cmd = new MySqlCommand(sqlstr, con);
                    if (Convert.ToString(cmd.ExecuteScalar()) != "")
                    {
                        message.Text = "注册成功,5s后自动跳转";
                        delay(4000);
                        this.Hide();
                        Login log = new Login();
                        //register.Close();
                        
                        log.ShowDialog(); 
                    }
                    else
                    {
                        MessageBox.Show("注册失败");
                    }
                    //con.Close();
                    //con.Dispose();
                    //MySqlCommand cmd = new MySqlCommand(sqlcmd, con);
                }
                catch (MySqlException)
                { 
                    //MessageBox.Show("打开数据库失败！");
                    //return 0;
                }

                Login login = new Login();

                if(Signupnow.DialogResult == DialogResult.OK)
                {
                    login.usernameTB.Text = this.usernameTB.Text;
                    login.passwordTB.Text = this.passwordTB.Text;
                    login.sign.DialogResult = DialogResult.OK;
                    
                }
            }
        }

        private void usernameTB_TextChanged(object sender, EventArgs e)
        {
            usernameTB.MaxLength = 20;
        }

        private void register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void passwordTB_Click(object sender, EventArgs e)
        {
            if(passwordTB.Text == "Password" && passwordTB.Focused)
            {
                passwordTB.Text = "";
                passwordTB.PasswordChar = '*';
            }
        }

        private void PasswordTB_LostFocus(object sender, System.EventArgs e)
        {
            if(passwordTB.Text.Equals(""))
            {
                passwordTB.PasswordChar = '\0';
                passwordTB.Text = "Password";
            }
        }

        private void Username_LostFocus(object sender, System.EventArgs e)
        {
            if (usernameTB.Text.Equals(""))
            {
                usernameTB.Text = "Nickname";
            }
        }

        private void usernameTB_Click(object sender, EventArgs e)
        {
            if(usernameTB.Text == "Nickname" && usernameTB.Focused)
            {
                usernameTB.Text = "";
            }
        }

        private void telTB_LostFocus(object sender, System.EventArgs e)
        {
            if (telTB.Text.Equals(""))
            {
                //passwordTB.PasswordChar = '\0';
                telTB.Text = "tel";
            }
        }

        private void telTB_Click(object sender, EventArgs e)
        {
            if (telTB.Text == "tel" && telTB.Focused)
            {
                telTB.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        int countregeye = 0;
        private void regeye_Click(object sender, EventArgs e)
        {
            if(countregeye == 0)
            {
                passwordTB.PasswordChar = '\0';
                countregeye = 1;
            }
            else
            {
                passwordTB.PasswordChar = '*';
                countregeye = 0;
            }
        }

        private void register_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                this.button1_Click(sender, e);
            }
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void passwordTB_TextChanged(object sender, EventArgs e)
        {
            //if(passwordTB.Click)
        }
    }
}
