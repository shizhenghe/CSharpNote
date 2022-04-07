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
    public partial class newfile : Form
    {
        public newfile()
        {
            InitializeComponent();
        }

        private void entrybt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newfile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                this.entrybt_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                this.Close();
            }
        }

        private void newfile_Load(object sender, EventArgs e)
        {

        }
    }
}
