using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login login = new Login();
            if(login.AutoStatu == 1)
            {
                Fisher edit = new Fisher();
                Application.Run(edit);
            }
            else
                Application.Run(new Login());

            
            /*
            Login login = new Login();

            login.ShowDialog();

            if(login.DialogResult ==  DialogResult.OK)
            {
                login.Hide();
                Application.Run(new calculator());
            }
            
            else if (login.DialogResult == DialogResult.Yes)
            {
                
                login.Hide();
                register reg = new register();

                reg.ShowDialog();

                //register.ActiveForm.ShowDialog();
                //reg.ShowDialog();

                if (reg.DialogResult == DialogResult.OK)
                {
                    reg.Hide();
                    Application.Run(new Login());
                }
                else
                {
                    reg.Dispose();
                    return;
                }
            }
            else if(login.DialogResult == DialogResult.Cancel)
            {
                login.Dispose();
                return;
            }*/

            /* Sgin up now 点击返回到登陆界面 */
            /*
            //register reg = new register();

            //register.ActiveForm.ShowDialog();
            //reg.ShowDialog();

            if (reg.ShowDialog() == DialogResult.OK)
            {
                reg.Hide();
                Application.Run(new Login());
            }
            else
            {
                reg.Dispose();
                return;
            }*/
        }
    }
}
