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
    public partial class subfrom : Form
    {
        Fisher cal = new Fisher();
        public string info, type, str, strext;      //path type nameandextension namewithoutextension
        public long count;
        public subfrom()
        {
            InitializeComponent();
            
            cal.openFileDialog1.Filter = "(所有文件(*.*))|*.*|(图片文件(*.gif;*.jpg))|*.gif;*.jpg|(office文件(*.doc;*.xls;*.ppt))|*.doc;*.xls;*.ppt";
            if (cal.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                info = cal.openFileDialog1.FileName;         //info = filedialog
                str = System.IO.Path.GetFileName(info);
                type = System.IO.Path.GetExtension(info);
                strext = System.IO.Path.GetFileNameWithoutExtension(info);

                this.Text = str;
            }
            if (info != null)
                this.richTextBox1.LoadFile(info, RichTextBoxStreamType.PlainText);
            count = this.richTextBox1.Text.Length;       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
