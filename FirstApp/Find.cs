using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public delegate void tabcontroltabpage();
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }

        private void Find_Load(object sender, EventArgs e)
        {

        }

        private void Aabt_Click(object sender, EventArgs e)
        {

        }

        private void Aabt_MouseEnter(object sender, EventArgs e)
        {
            Aa.ShowAlways = true;
            Aa.SetToolTip(this.Aabt, "区分大小写");
        }

        private void ABbt_MouseEnter(object sender, EventArgs e)
        {
            AB.ShowAlways = true;
            AB.SetToolTip(this.ABbt, "全字匹配");
        }

        private void searchbt_MouseEnter(object sender, EventArgs e)
        {
            search.ShowAlways = true;
            search.SetToolTip(this.searchbt, "查找");
        }

        private void nextbt_MouseEnter(object sender, EventArgs e)
        {
            next.ShowAlways = true;
            next.SetToolTip(this.nextbt, "查找");
        }

        private void replacebt_MouseEnter(object sender, EventArgs e)
        {
            replace.ShowAlways = true;
            replace.SetToolTip(this.replacebt, "替换");
        }

        private void replaceallbt_MouseEnter(object sender, EventArgs e)
        {
            replaceall.ShowAlways = true;
            replaceall.SetToolTip(this.replaceallbt, "全部替换");
        }

        private void fathertb_Click(object sender, EventArgs e)
        {
            fathertb.Text = "";
        }

        private void subtb_Click(object sender, EventArgs e)
        {
            subtb.Text = "";
        }

        Fisher edit = new Fisher();
        public string findtext;
        private void searchbt_Click(object sender, EventArgs e)
        {
            findtext = fathertb.Text; 
            if(edit.untitled.TabCount > 0)
            {
                var tabpage = edit.untitled.SelectedTab as TabPage;
                var rhb = tabpage.Controls[0] as RichTextBox;
                findtext = Convert.ToString(rhb.Find(fathertb.Text));
                rhb.SelectionColor = Color.FromName("Orange");
                MessageBox.Show(findtext);
            }
        }
    }
}
