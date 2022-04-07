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
    public partial class admlogin : Form
    {
        public admlogin()
        {
            InitializeComponent();
        }

        private void sign_Click(object sender, EventArgs e)
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
                    string sqlcmd = "select * from csharp.admin where name = '" + account + "' and password = '" + password + "'";
                    MySqlCommand cmd = new MySqlCommand(sqlcmd, con);
                    if (Convert.ToString(cmd.ExecuteScalar()) != "")
                    {
                        Fisher cal = new Fisher();
                        this.Hide();
                        admin adm = new admin();
                        adm.Show();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误！");

                    }
                }
                catch (MySqlException)
                {
                    MessageBox.Show("打开数据库失败！");
                }
            }
        }

        int counteye = 0;
        private void eye_Click(object sender, EventArgs e)
        {
            if (counteye == 0)
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

        private void admlogin_Load(object sender, EventArgs e)
        {
            if (passwordTB.Text == "Password")
            {
                passwordTB.PasswordChar = '\0';
                eye.Enabled = false;
            }     
            else
            {
                passwordTB.PasswordChar = '*';
            }
        }

        private void usernameTB_LostFocus(object sender, System.EventArgs e)
        {
            if (usernameTB.Text.Equals(""))
            {
                usernameTB.ForeColor = Color.Gray;
                usernameTB.Text = "Account";
            }
        }

        private void passwordTB_LostFocus(object sender, System.EventArgs e)
        {
            if (passwordTB.Text.Equals(""))
            {
                passwordTB.ForeColor = Color.Gray;
                passwordTB.PasswordChar = '\0';
                passwordTB.Text = "Password";
                eye.Enabled = false;
            }
            else
                eye.Enabled = true;
        }

        private void usernameTB_Click(object sender, EventArgs e)
        {
            if (usernameTB.Text == "Account" && usernameTB.Focused)
            {
                usernameTB.Text = "";
                usernameTB.ForeColor = Color.Black;
            }
        }

        private void passwordTB_Click(object sender, EventArgs e)
        {
            if (passwordTB.Text == "Password" && passwordTB.Focused)
            {
                passwordTB.ForeColor = Color.Black;
                passwordTB.Text = "";
                passwordTB.PasswordChar = '*';
            }
            if(passwordTB.Text != "Password" && passwordTB.Text != "")
            {
                eye.Enabled = true;
            }
        }

        private void admlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void passwordTB_TextChanged(object sender, EventArgs e)
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

        private void title_Click(object sender, EventArgs e)
        {

        }
    }
}
