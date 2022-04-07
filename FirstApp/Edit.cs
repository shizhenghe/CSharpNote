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
using System.IO;
using System.Text.RegularExpressions;

namespace FirstApp
{
    public partial class Fisher : Form
    {
        public Fisher()
        {
            InitializeComponent();
            //tabpage.Text = "untiled";
        }

        //subfrom sub = new subfrom();
        public string info, str, type;

        /* tabpage重绘 */
        const int close_width = 15, close_height = 3;
        private void calculator_Load(object sender, EventArgs e)
        {
            this.untitled.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.untitled.Padding = new System.Drawing.Point(close_width, close_height);
            this.untitled.DrawItem += new DrawItemEventHandler(this.untitled_DrawItem);
            this.untitled.MouseDown += new System.Windows.Forms.MouseEventHandler(this.untitled_MouseDown);
            //(this.Parent as Login).Close();
        }

        //标签图片
        Bitmap image = new Bitmap(@"E:\visual stdio\algorithm\C#.NET\FirstApp\FirstApp\bin\Debug\IMAGE\close_16px_1084321_easyicon.net.ico");

        private void untitled_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                Rectangle MyTabRect = this.untitled.GetTabRect(e.Index);

                //先添加TabPage属性 
                e.Graphics.DrawString(this.untitled.TabPages[e.Index].Text, this.Font, SystemBrushes.ControlText, MyTabRect.X + 2, MyTabRect.Y + 2);

                //再绘制矩形框
                using (Pen p = new Pen(Color.White))
                {
                    MyTabRect.Offset(MyTabRect.Width - (close_width + 3), 2);
                    MyTabRect.Width = close_width;
                    MyTabRect.Height = close_height;
                    e.Graphics.DrawRectangle(p, MyTabRect);
                }

                //填充矩形框
                Color reccolor = e.State == DrawItemState.Selected ? Color.White : Color.White;
                using (Brush b = new SolidBrush(reccolor))
                {
                    e.Graphics.FillRectangle(b, MyTabRect);
                }

                //画关闭符号
                
                using (Pen objpen = new Pen(Color.Black))
                {
                    /*
                    //手动绘制 \ 线
                    Point p1 = new Point(MyTabRect.X + 3, MyTabRect.Y + 3);
                    Point p2 = new Point(MyTabRect.X + MyTabRect.Width - 3, MyTabRect.Y + MyTabRect.Height - 3);
                    e.Graphics.DrawLine(objpen, p1, p2);

                    //手动绘制 / 线
                    Point p3 = new Point(MyTabRect.X + 3, MyTabRect.Y + MyTabRect.Height - 3);
                    Point p4 = new Point(MyTabRect.X + MyTabRect.Width - 3, MyTabRect.Y + 3);
                    e.Graphics.DrawLine(objpen, p3, p4);*/
                                                                                                                            
                    Bitmap bt = new Bitmap(image);
                    Point p5 = new Point(MyTabRect.X, 4);
                    e.Graphics.DrawImage(bt, p5);                                                                             
                }
                e.Graphics.Dispose();
            }
            catch(Exception)
            {

            }
        }

        private void untitled_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                int x = e.X, y = e.Y;
                //计算关闭区域
                Rectangle myTabRect = this.untitled.GetTabRect(this.untitled.SelectedIndex);
                myTabRect.Offset(myTabRect.Width - (close_width + 3), 2);
                myTabRect.Width = close_width;
                myTabRect.Height = close_width;

                //判断鼠标在区域内， 关闭
                bool isclose = x > myTabRect.X && x < myTabRect.Right && y > myTabRect.Y && y < myTabRect.Bottom;
                if(isclose == true)
                {
                    this.untitled.TabPages.Remove(this.untitled.SelectedTab);
                }
            }
        }

        /* tabpage重绘 */
        private void 起始页SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void 关闭程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关闭CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string[] indexnum = new string[1000];
        string[] pthtext = new string[1000];
        private void 新文件NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newfile nf = new newfile();
            nf.ShowDialog();
            if (nf.filenametb.Text != "")
            {
                TabPage tabpage = new TabPage();
                tabpage.Name = "tp1";
                this.untitled.Controls.Add(tabpage);
                this.untitled.SelectTab(tabpage);       //设置为当前选中的tabpage
                tabpage.ToolTipText = nf.filenametb.Text;
                tabpage.GotFocus += new System.EventHandler(this.tabpage_GotFocus);
                RichTextBox rhb = new RichTextBox();
                rhb.ContextMenuStrip = tabcontrolCMS;
                tabpage.Controls.Add(rhb);
                rhb.Size = tabpage.Size;
                rhb.TextChanged += new System.EventHandler(this.rhb_TextChanged);
                rhb.Click += new System.EventHandler(this.rhb_Click);
                rhb.Focus();
                rhb.KeyDown += new KeyEventHandler(rich_KeyDown);
                tabpage.Text = nf.filenametb.Text;

                name.Text = tabpage.Text + "  ";
                texttype.Text = nf.filetypecb.Text + "  ";
                indexnum[tabpage.TabIndex] = nf.filetypecb.Text;
                textlength.Text = "0" + "         ";
                rhb.KeyDown += new KeyEventHandler(rich_KeyDown);
            }
            else
            {

            }

            //rich.TextChanged+=new System.EventHandler(this.rich_TextChanged);
            //rhb.Size = tabpage.Size;

            //savetext = rhb.Text;

            //rhb.Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
            //rhb.LoadFile(sub.info, RichTextBoxStreamType.PlainText);

            /* * this.richTextBox1.LoadFile(info, RichTextBoxStreamType.PlainText);
            count = this.richTextBox1.MaxLength;
            subfrom sub = new subfrom();
            sub.MdiParent = this;
            sub.Show();*/
        }

        //
        //高亮关键字功能开始
        //
        private void rich_KeyDown(object sender, KeyEventArgs e)
        {
            // throw new Exception("The method or operation is not implemented.");
            //RichTextBox rich = (RichTextBox)sender;
            var tabpage = untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            // throw new Exception("The method or operation is not implemented.");
            string s = GetLastWord(rhb.Text, rhb.SelectionStart);
            
            if (AllClass().IndexOf(s) > -1)
            {
                 MySelect(rhb, rhb.SelectionStart, s, Color.CadetBlue, true);
            }
        }

         // 设定颜色
        public static void MySelect(System.Windows.Forms.RichTextBox tb, int i, string s, Color c, bool font)
        {
            tb.Select(i - s.Length, s.Length);
            tb.SelectionColor  =  c;
             //是否改变字体
            if (font)
                tb.SelectionFont =  new Font( " 宋体 " ,  12 , (FontStyle.Bold));
            else
                tb.SelectionFont = new Font( " 宋体 " ,  12 , (FontStyle.Regular));
                 //以下是把光标放到原来位置，并把光标后输入的文字重置
            tb.Select(i, 0 );
            tb.SelectionFont  = new Font( " 宋体 " ,  12 , (FontStyle.Regular));
            tb.SelectionColor = Color.Black;
        }

        public static List<string> AllClass()
        {
              List<string> list = new List<string>();
              list.Add( " function " );
              list.Add( " return " );
              list.Add( " class " );
              list.Add( " new " );
              list.Add( " extends " );
              list.Add( " var " );
              return  list;
        }

        public static string GetLastWord(string str, int i)
        {
              string x = str;
              Regex reg = new Regex(@" \s+[a-z]+\s* ", RegexOptions.RightToLeft);
              x  =  reg.Match(x).Value;
 
              Regex reg2 = new Regex(@" \s ");
              x  =  reg2.Replace(x,  "" );
              return  x;
        }
        //
        //高亮关键字功能结束
        //

        public int index, line, column;
        int[,] Cousor = new int[1000, 2];
        string savetext = "";
        bool textchangeflag = false;
        private void rhb_TextChanged(object sender, EventArgs e)
        {
            var tabpage = untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            savetext = rhb.Text;          //获取richtextbox的内容
            rhb.KeyDown += new KeyEventHandler(rich_KeyDown);
            textlength.Text = Convert.ToString(savetext.Length) + "         ";
            //5 即重第一个字符开始到光标行的第1个字符缩影
            index = ((RichTextBox)sender).GetFirstCharIndexOfCurrentLine();
            //第一行重 0 开始， 所以 + 1
            line = ((RichTextBox)sender).GetLineFromCharIndex(index) + 1;
            //((RichTextBox)sender).SelectionColor = Color.LightGray;
            //selectstart得到光标所在的位置的索引， 减去当前第一个字符的索引， 为光标的列数
            column = ((RichTextBox)sender).SelectionStart - index + 1;
            cursortext.Text = Convert.ToString(line) + "  " + "rows" + "    " + Convert.ToString(column) + "  " + "columns" + "    ";
            //TabPage tabpage = (TabPage)untitled.SelectedTab;
            Cousor[tabpage.TabIndex, 0] = line;
            Cousor[tabpage.TabIndex, 1] = column;
            if (textchangeflag == false)
            {
                textchangeflag = true;
            }
            // 
        }


        private void rhb_Click(object sender, EventArgs e)
        {
            var tabpage = untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            savetext = rhb.Text;
            textlength.Text = Convert.ToString(savetext.Length) + "         ";
            line = (1 + rhb.GetLineFromCharIndex(rhb.SelectionStart));
            column = (1 + rhb.SelectionStart - (rhb.GetFirstCharIndexFromLine(1 + rhb.GetLineFromCharIndex(rhb.SelectionStart) - 1)));
            cursortext.Text = Convert.ToString(line) + "  " + "rows" + "    " + Convert.ToString(column) + "  " + "columns" + "    ";
            Cousor[tabpage.TabIndex, 0] = line;
            Cousor[tabpage.TabIndex, 1] = column;
            //rhb.SelectionBackColor = Color.LightGray;
            string selectedtext = rhb.SelectedText;
            //if(selectedtext.Length)

        }

        long startlength;
        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subfrom sub = new subfrom();

            if(sub.info != null)
            {
                TabPage tabpage = new TabPage();
                tabpage.Name = "tpl";
                //tabpage.ContextMenuStrip = tabcontrolCMS;
                this.untitled.Controls.Add(tabpage);
                this.untitled.SelectTab(tabpage);

                tabpage.Text = sub.str;
                tabpage.ToolTipText = sub.str;

                RichTextBox rhb = new RichTextBox();
                rhb.ContextMenuStrip = tabcontrolCMS;
                tabpage.Controls.Add(rhb);
                rhb.Focus();
                rhb.Size = tabpage.Size;
                rhb.TextChanged += new System.EventHandler(this.rhb_TextChanged);
                rhb.Click += new System.EventHandler(this.rhb_Click);
                //rhb.TextChanged += new System.EventHandler(this.rhb_TextChanged);
                //rhb.Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
                rhb.LoadFile(sub.info, RichTextBoxStreamType.PlainText);
                pathtext.Text = sub.info;
                pthtext[tabpage.TabIndex] = sub.info;
                name.Text = sub.strext + "  ";
                texttype.Text = sub.type + "  ";
                textlength.Text = Convert.ToString(sub.count) + "         ";
                startlength = sub.count;
            }
            else
            {

            }
        }

        private void 窗口平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 窗口垂直平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void 窗口层叠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void 窗口排列图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void tabpage_Click(object sender, EventArgs e)
        {
            untitled.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tabpage = this.untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            fontDialog1.ShowColor = true;
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowApply = true;
            string selecttext = rhb.SelectedText;
            if(selecttext == "")
            {
                if(fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    rhb.SelectAll();
                    rhb.SelectionColor = fontDialog1.Color;
                    rhb.SelectionFont = fontDialog1.Font;
                }
            }
            else
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    rhb.SelectionColor = fontDialog1.Color;
                    rhb.SelectionFont = fontDialog1.Font;
                    //rhb.SelectionBackColor = fontDialog1.        //选中时需要的颜色Color.Lavender;
                }
            }
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tabpage = this.untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;

            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rhb.BackColor = colorDialog1.Color;
            }
        }

        private void 主题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tabpage = this.untitled.SelectedTab as TabPage;
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach(Control control in this.Controls)
                {
                    control.BackColor = colorDialog1.Color;
                    this.BackColor = colorDialog1.Color;
                }     
            }                
        }

        public string saveinfo, savestr, savetype, savestrext;

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tabpage = untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            rhb.Copy();
            copytext = rhb.SelectedText;
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var tabpage = untitled.Controls["tp1"] as TabPage;
            var tabpage = untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            if(rhb.Focused)
            {
                rhb.Paste();
            }
            //要获得剪切板的数据
            else if(findpanel.Focused)
            {
                if(fathertb.Focused)
                {
                    fathertb.Text = copytext;
                }
                else if(subtb.Focused)
                {
                    subtb.Text = copytext;
                }
            }
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tabpage = untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            rhb.Cut();
            /*
            var tabpage = untitled.Controls["tp1"] as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            rhb.Cut();
            //MessageBox.Show(richTextBox.Text);
            //RichTextBox rhb = new RichTextBox();
            //rhb = (RichTextBox)Finditem();
            //string tetx = this.rhb.SelectedText;
            //rhb.Cut();
            //cmd = "^x";
            /*
            foreach(Control c inControls)
            {
                if(c is RichTextBox && c.Name != "")
                {
                    rhb = c as RichTextBox;
                    Clipboard.SetData(DataFormats.Text, rhb.SelectedText);
                    rhb.SelectedText = "";
                }
            }
            /*
            RichTextBox rhb =          //在ToolStripMenuItem中无法使用richtextbox sender的类型
            Clipboard.SetData(DataFormats.Rtf, ((RichTextBox)sender).SelectedRtf);
            ((RichTextBox)sender).SelectedRtf = "";
            /*
            RichTextBox rhb = new RichTextBox();
            Control ctl = GetControl("rhb");
            if(ctl != null)
            {
                RichTextBox rhb1 = (RichTextBox)ctl;
                if (rhb1.SelectedText.Length > 0)
                {
                    rhb.Cut();
                }
            }*/
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tabpage = untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            rhb.SelectAll();
            
            /*  莫名的不行
            var tabpage = untitled.Controls["tpl"] as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            rhb.SelectAll();*/
        }

        string copytext;
        IDataObject ido;
        private void 复制ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var tabpage = untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            rhb.Copy();
            copytext = rhb.SelectedText;
            //Clipboard有值
            Clipboard.SetDataObject(rhb.SelectedText);
            if(Clipboard.ContainsText())
            {
                ido = Clipboard.GetDataObject();
            }  
        }

        private void 剪切ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var tabpage = untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            rhb.Cut();
            
        }

        private void 粘贴ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var tabpage = untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            rhb.Paste();
        }

        private void 全选ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var tabpage = untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            rhb.SelectAll();
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tabpage = untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            rhb.Undo();
        }

        string findresult;
        int findpanelflag = 0;
        private void 查找ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //findpanelflag = 0;
            if(findpanelflag == 0)
            {
                findpanel.Visible = true;
                searchbt.Enabled = false;
                //string copytext = Convert.ToString(ido.GetData(DataFormats.Text));
                fathertb.Text = copytext;
                findpanelflag = 1;
            }
            else if(findpanelflag == 1)
            {
               
                findpanel.Visible = false;
                
                findpanelflag = 0;
            }
        }

        private void 替换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find find = new Find();
            var tabpage = untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            rhb.SelectedText = find.subtb.Text;
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            //subfrom sub = new subfrom();
            if(untitled.TabCount > 0)
            {
                var tabpage = untitled.SelectedTab as TabPage;
                var rhb = tabpage.Controls[0] as RichTextBox;
                string savetext = rhb.Text;
                if (pathtext.Text == "  ")
                {
                    StreamWriter mystream;
                    int lgth = name.Text.Length;
                    string subname = name.Text.Substring(0, lgth - 2);
                    saveFileDialog1.FileName = subname + texttype.Text;
                    saveFileDialog1.Filter = " All(*.*)| *.* | txt(*.txt)| *.txt | dos(*.dos)| *.dos | ppt(*.ppt)| *.ppt | xls(*.xls)| *.xls | c(*.c)| *.c | html(*.html)| *.html | py(*.py)| *.py | cs(*.cs)| *.cs | css(*.css)| *.css | cpp(*.cpp)| *.cpp | js(*.js)| *.js";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        saveinfo = saveFileDialog1.FileName;
                        pathtext.Text = saveinfo;
                        savetype = System.IO.Path.GetExtension(saveinfo);
                        savestr = System.IO.Path.GetFileNameWithoutExtension(saveinfo);
                        savestrext = System.IO.Path.GetFileName(saveinfo);
                        mystream = new StreamWriter(saveinfo);
                        mystream.Write(savetext);
                        mystream.Close();
                    }
                }
                else
                {
                    StreamWriter sw = File.CreateText(pathtext.Text);
                    sw.Write(savetext);
                    sw.Flush();         //清楚写入器的缓冲区， 将缓冲数据写入基础流
                    sw.Close();
                }
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(untitled.TabCount > 0)
            {
                var tabpage = untitled.SelectedTab as TabPage;
                var rhb = tabpage.Controls[0] as RichTextBox;
                string savetext = rhb.Text;
                if (pathtext.Text == "  ")      //第一次保存
                {
                    StreamWriter mystream;
                    int lgth = name.Text.Length;
                    string subname = name.Text.Substring(0, lgth - 2);
                    saveFileDialog1.FileName = subname + texttype.Text;
                    saveFileDialog1.Filter = " All(*.*)| *.* | txt(*.txt)| *.txt | dos(*.dos)| *.dos | ppt(*.ppt)| *.ppt | xls(*.xls)| *.xls | c(*.c)| *.c | html(*.html)| *.html | py(*.py)| *.py | cs(*.cs)| *.cs | css(*.css)| *.css | cpp(*.cpp)| *.cpp | js(*.js)| *.js";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        saveinfo = saveFileDialog1.FileName;
                        pathtext.Text = saveinfo;
                        pthtext[tabpage.TabIndex] = saveinfo;
                        savetype = System.IO.Path.GetExtension(saveinfo);
                        savestr = System.IO.Path.GetFileNameWithoutExtension(saveinfo);
                        savestrext = System.IO.Path.GetFileName(saveinfo);
                        mystream = new StreamWriter(saveinfo);
                        mystream.Write(savetext);
                        mystream.Close();
                    }
                }
                else        //多次保存
                {
                    StreamWriter sw = File.CreateText(pathtext.Text);
                    sw.Write(savetext);
                    sw.Flush();         //清楚写入器的缓冲区， 将缓冲数据写入基础流
                    sw.Close();
                }
            }
        }

        private void 新建项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newfile nf = new newfile();
            nf.ShowDialog();
            if (nf.filenametb.Text != "")
            {
                TabPage tabpage = new TabPage();
                tabpage.Name = "tp1";
                this.untitled.Controls.Add(tabpage);
                this.untitled.SelectTab(tabpage);       //设置为当前选中的tabpage
                tabpage.ToolTipText = nf.filenametb.Text;
                tabpage.GotFocus += new System.EventHandler(this.tabpage_GotFocus);
                RichTextBox rhb = new RichTextBox();
                rhb.ContextMenuStrip = tabcontrolCMS;
                tabpage.Controls.Add(rhb);
                rhb.Size = tabpage.Size;
                rhb.TextChanged += new System.EventHandler(this.rhb_TextChanged);
                rhb.Click += new System.EventHandler(this.rhb_Click);
                rhb.Focus();
                tabpage.Text = nf.filenametb.Text;

                name.Text = tabpage.Text + "  ";
                texttype.Text = nf.filetypecb.Text + "  ";
                indexnum[tabpage.TabIndex] = nf.filetypecb.Text;
                textlength.Text = "0" + "         ";
            }
            else
            {

            }
        }

        private void newfile_Click(object sender, EventArgs e)
        {
            newfile nf = new newfile();
            nf.ShowDialog();
            if(nf.filenametb.Text != "")
            {
                TabPage tabpage = new TabPage();
                tabpage.Name = "tp1";
                this.untitled.Controls.Add(tabpage);
                this.untitled.SelectTab(tabpage);       //设置为当前选中的tabpage
                tabpage.ToolTipText = nf.filenametb.Text;
                tabpage.GotFocus += new System.EventHandler(this.tabpage_GotFocus);
                RichTextBox rhb = new RichTextBox();
                rhb.ContextMenuStrip = tabcontrolCMS;
                tabpage.Controls.Add(rhb);
                rhb.Size = tabpage.Size;
                rhb.TextChanged += new System.EventHandler(this.rhb_TextChanged);
                rhb.Click += new System.EventHandler(this.rhb_Click);
                rhb.Focus();
                tabpage.Text = nf.filenametb.Text;

                name.Text = tabpage.Text + "  ";
                texttype.Text = nf.filetypecb.Text + "  ";
                indexnum[tabpage.TabIndex] = nf.filetypecb.Text;
                textlength.Text = "0" + "         ";
            }
            else
            {

            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            subfrom sub = new subfrom();            

            //要是路径不是null，新建一个tabpage
            if (sub.info != null)
            {
                TabPage tabpage = new TabPage();
                tabpage.Name = "tpl";
                //tabpage.ContextMenuStrip = tabcontrolCMS;
                this.untitled.Controls.Add(tabpage);
                this.untitled.SelectTab(tabpage);

                tabpage.Text = sub.str;
                tabpage.ToolTipText = sub.str;

                RichTextBox rhb = new RichTextBox();
                rhb.ContextMenuStrip = tabcontrolCMS;
                tabpage.Controls.Add(rhb);
                rhb.Focus();
                rhb.Size = tabpage.Size;
                rhb.TextChanged += new System.EventHandler(this.rhb_TextChanged);
                rhb.Click += new System.EventHandler(this.rhb_Click);
                rhb.LoadFile(sub.info, RichTextBoxStreamType.PlainText);
                pathtext.Text = sub.info;
                pthtext[tabpage.TabIndex] = sub.info;
                name.Text = sub.strext + "  ";
                texttype.Text = sub.type + "  ";
                textlength.Text = Convert.ToString(sub.count) + "         ";
                startlength = sub.count;
            }
            else
            {

            }
        }

        private void cut_Click(object sender, EventArgs e)
        {
            var tabpage = untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            rhb.Cut();
        }

        private void copy_Click(object sender, EventArgs e)
        {
            var tabpage = untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            rhb.Copy();
        }

        private void paste_Click(object sender, EventArgs e)
        {
            var tabpage = untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            rhb.Paste();
        }

        private void selectall_Click(object sender, EventArgs e)
        {
            var tabpage = untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            rhb.SelectAll();
        }

        private void 已有项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subfrom sub = new subfrom();

            TabPage tabpage = new TabPage();
            tabpage.Name = "tpl";
            //tabpage.ContextMenuStrip = tabcontrolCMS;
            this.untitled.Controls.Add(tabpage);
            this.untitled.SelectTab(tabpage);

            tabpage.Text = sub.str;
            tabpage.ToolTipText = sub.str;

            RichTextBox rhb = new RichTextBox();
            rhb.ContextMenuStrip = tabcontrolCMS;
            tabpage.Controls.Add(rhb);
            rhb.Focus();
            rhb.Size = tabpage.Size;
            rhb.TextChanged += new System.EventHandler(this.rhb_TextChanged);
            rhb.Click += new System.EventHandler(this.rhb_Click);
            //rhb.TextChanged += new System.EventHandler(this.rhb_TextChanged);
            //rhb.Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
            if (sub.info != null)
            {
                rhb.LoadFile(sub.info, RichTextBoxStreamType.PlainText);
                pathtext.Text = sub.info;
                pthtext[tabpage.TabIndex] = sub.info;
                name.Text = sub.strext + "  ";
                texttype.Text = sub.type + "  ";
                textlength.Text = Convert.ToString(sub.count) + "         ";
                startlength = sub.count;
            }
            else
            {

            }           
        }

        private void close_Click(object sender, EventArgs e)
        {
            if(untitled.TabCount > 0)
            {
                untitled.TabPages.Remove(untitled.SelectedTab);
            }
        }

        private void saveas_Click(object sender, EventArgs e)
        {
            if(untitled.TabCount > 0)
            {
                var tabpage = untitled.SelectedTab as TabPage;
                var rhb = tabpage.Controls[0] as RichTextBox;
                string savetext = rhb.Text;
                int lgth = name.Text.Length;
                string subname = name.Text.Substring(0, lgth - 2);

                StreamWriter mystream;

                saveFileDialog1.FileName = subname + texttype.Text;
                saveFileDialog1.Filter = " All(*.*)| *.* | txt(*.txt)| *.txt | dos(*.dos)| *.dos | ppt(*.ppt)| *.ppt | xls(*.xls)| *.xls | c(*.c)| *.c | html(*.html)| *.html | py(*.py)| *.py | cs(*.cs)| *.cs | css(*.css)| *.css | cpp(*.cpp)| *.cpp | js(*.js)| *.js";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    saveinfo = saveFileDialog1.FileName;
                    pathtext.Text = saveinfo;
                    pthtext[tabpage.TabIndex] = saveinfo;
                    savetype = System.IO.Path.GetExtension(saveinfo);
                    savestr = System.IO.Path.GetFileNameWithoutExtension(saveinfo);
                    savestrext = System.IO.Path.GetFileName(saveinfo);
                    mystream = new StreamWriter(saveinfo);
                    mystream.Write(savetext);
                    mystream.Close();
                }
            }
        }

        private void untitled_Selected(object sender, TabControlEventArgs e)
        {
            if(untitled.TabCount > 0)
            {
                TabPage tabpage = (TabPage)untitled.SelectedTab;
                name.Text = tabpage.Text;
                texttype.Text = indexnum[tabpage.TabIndex];
                cursortext.Text = Cousor[tabpage.TabIndex, 0] + "  " + "rows" + "    " + Cousor[tabpage.TabIndex, 1] + "  " + "columns" + "    ";
                pathtext.Text = pthtext[tabpage.TabIndex];
            }
            else
            {
                name.Text = "    ";
                pathtext.Text = "    ";
                texttype.Text = "    ";
                cursortext.Text = "0" + "  " + "rows" + "    " + "0" + "  " + "columns" + "    ";
                textlength.Text = "    ";
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "PHP")
            {
                texttype.Text = ".php";
            }
            if (comboBox1.Text == "C")
            {
                texttype.Text = ".c";
            }
            if (comboBox1.Text == "C#")
            {
                texttype.Text = ".cs";
            }
            if (comboBox1.Text == "Python")
            {
                texttype.Text = ".py";
            }
            if (comboBox1.Text == "Java")
            {
                texttype.Text = ".java";
            }
            if (comboBox1.Text == "JavaScrip")
            {
                texttype.Text = ".jsp";
            }
            if (comboBox1.Text == "C++")
            {
                texttype.Text = ".cpp";
            }
            if (comboBox1.Text == "Html")
            {
                texttype.Text = ".html";
            }
            if(comboBox1.Text == "Text")
            {
                texttype.Text = ".txt";
            }
            if(comboBox1.Text == "JSON")
            {
                texttype.Text = ".json";
            }
            if(comboBox1.Text == "Css")
            {
                texttype.Text = ".css";
            }
            if(comboBox1.Text == "Visual Basic")
            {
                texttype.Text = ".vb";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString() + "         ";
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            if(untitled.TabCount > 0)
            {
                var tabpage = untitled.SelectedTab as TabPage;
                var rhb = tabpage.Controls[0] as RichTextBox;
                string savetext = rhb.Text;
                int lgth = name.Text.Length;
                string subname = name.Text.Substring(0, lgth - 2);

                StreamWriter mystream;

                saveFileDialog1.FileName = subname + texttype.Text;
                saveFileDialog1.Filter = " All(*.*)| *.* | txt(*.txt)| *.txt | dos(*.dos)| *.dos | ppt(*.ppt)| *.ppt | xls(*.xls)| *.xls | c(*.c)| *.c | html(*.html)| *.html | py(*.py)| *.py | cs(*.cs)| *.cs | css(*.css)| *.css | cpp(*.cpp)| *.cpp | js(*.js)| *.js";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    saveinfo = saveFileDialog1.FileName;
                    pathtext.Text = saveinfo;
                    pthtext[tabpage.TabIndex] = saveinfo;
                    savetype = System.IO.Path.GetExtension(saveinfo);
                    savestr = System.IO.Path.GetFileNameWithoutExtension(saveinfo);
                    savestrext = System.IO.Path.GetFileName(saveinfo);
                    //string savetext = richTextBox1.Text;
                    mystream = new StreamWriter(saveinfo);
                    mystream.Write(savetext);
                    mystream.Close();
                }
            }
        }

        private void htmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            texttype.Text = ".html";
        }

        private void pythonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            texttype.Text = ".py";
        }

        private void pHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            texttype.Text = ".php";
        }

        private void javaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            texttype.Text = ".java";
        }

        private void javaScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            texttype.Text = ".js";
        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            texttype.Text = ".json";
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            texttype.Text = ".c";
        }

        private void cToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            texttype.Text = ".cs";
        }

        private void cToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            texttype.Text = ".cpp";
        }

        private void cssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            texttype.Text = ".css";
        }

        private void vsualBasecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            texttype.Text = ".vb";
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            texttype.Text = ".txt";
        }

        private void 退出不清除账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 退出并清除账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string constr = "server=localhost; User Id = root; password = 2571834079; Database = csharp";
            MySqlConnection con = new MySqlConnection(constr);

            try
            {
                con.Open();
                Login login = new Login();
                //select * from csharp.stone where name = '" + account + "' and password = '" + password + "'
                string cmdstr = "delete from close where name = '" + login.usernameTB.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(cmdstr, con);
                if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                {
                    login.checkBox1.Checked = false;
                    login.checkBox2.Checked = false;
                    MessageBox.Show("清除成功", "删除信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else
                {
                    Application.Exit();
                }
            }
            catch (MySqlException)
            {

            }
        }

        private void calculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(untitled.TabCount != 0)
            {
                var tabpage = this.untitled.SelectedTab as TabPage;
                var rhb = tabpage.Controls[0] as RichTextBox;
                //subfrom sub = new subfrom();
                int endlength = rhb.Text.Length;
                if (endlength != startlength)
                {
                    //MessageBox.Show("是否保存修改内容", "退出", MessageBoxButtons.YesNo);
                    if (MessageBox.Show("是否保存修改内容", "退出", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.保存ToolStripMenuItem_Click(sender, e);
                        //this.Close();
                        textchangeflag = false;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                Application.Exit();
            }
            //Application.Exit();
        }

        private void nextbt_Click(object sender, EventArgs e)
        {
            var tabpage = this.untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            rhb.Focus();
        }

        #region
        int start = 0;
        int sun = 0;        //查找的和
        int count = 0;
        #endregion

        //查找下一个， 不区分大小写
        public void FindDown(RichTextBox rhb, string str)
        {
            int rhbl = rhb.Text.Length;

            if (start < rhbl)
            {
                start = rhb.Find(str, start, RichTextBoxFinds.None);       //start 是第一次出现的目标的位置
                int los = rhb.SelectionStart + str.Length;          //los 是目标结束的位置

                if ((start < 0) || (start > rhbl))
                {
                    if (count == 0)         //count 没有变化
                    {
                        this.seeks(str);
                        start = los;        //从当前位置查找
                        sun = 0;
                    }
                    else
                    {
                        this.seeks(str);
                        start = los;
                        sun = 0;
                    }
                }
                else if (start == rhbl || start < 0)
                {
                    this.seeks(str);
                    start = los;
                    sun = 0;
                }
                else
                {
                    sun++;
                    start = los;        // 从目标结束的地方继续寻找
                    //rhb.Focus();
                }
            }
            else if (start == rhbl || start == 0)
            {
                int los = rhb.SelectionStart + str.Length;
                this.seeks(str);
                start = los;
                sun = 0;
            }
            else
            {
                int los = rhb.SelectionStart + str.Length;
                this.seeks(str);
                start = los;
                sun = 0;
            }
        }//FindDown

        public void FindDownM(RichTextBox rhb, string str)
        {
            int rhbl = rhb.Text.Length;

            if (start < rhbl)
            {
                start = rhb.Find(str, start, RichTextBoxFinds.MatchCase);       //区分大小写
                int los = rhb.SelectionStart + str.Length;

                if ((start < 0) || (start > 0))
                {
                    if (count == 0)
                    {
                        this.seeks(str);
                        start = los;
                        sun = 0;
                    }
                    else
                    {
                        this.seeks(str);
                        start = los;
                        sun = 0;
                    }
                }
                else if (start == rhbl || start < 0)
                {
                    this.seeks(str);
                    start = los;
                    sun = 0;
                }
                else
                {
                    sun++;
                    start = los;
                    //rhb.Focus();
                }
            }
            else if (start == rhbl || start < 0)
            {
                int los = rhb.SelectionStart + str.Length;
                this.seeks(str);
                start = los;
                sun = 0;
            }
            else
            {
                int los = rhb.SelectionStart + str.Length;
                this.seeks(str);
                start = los;
                sun = 0;
            }
        }//FindDownM

        //消息提示,提示用户查找结果
        public void seeks(string str)
        {
            if (sun != 0)
            {
                MessageBox.Show(string.Format("已查找完毕,共〖{0}〗个 \"{1}\"！", sun, str), "查找 - 温馨提示");
            }
            else
                MessageBox.Show(string.Format("没有查找到 \"{0}\"！", str), "查找 - 温馨提示");
        }//seeks

        public void Replace(string str1, string str2)
        {
            var tabpage = this.untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            rhb.SelectionLength = str1.Length;
            rhb.SelectedText = str2;
        }//Replace

        public void FindUp(RichTextBox rhb, string str)
        {
            int rhbl = rhb.SelectionStart;
            int index = rhb.Find(str, 0, rhbl, RichTextBoxFinds.Reverse);

            if (index > -1)
            {
                rhb.SelectionStart = index;
                rhb.SelectionLength = str.Length;
                sun++;
                //rhb.Focus();
            }
            else if (index < 0)
            {
                this.seeks(str);
                sun = 0;
                //如果还想再找一遍,添加下面这句
                //rbox.SelectionStart = rbox.Text.Length;
            }
        }//FindUp

        private void searchbt_Click(object sender, EventArgs e)
        {
            var tabpage = untitled.SelectedTab as TabPage;
            var rhb = tabpage.Controls[0] as RichTextBox;
            string str = this.fathertb.Text;
            findresult = Convert.ToString(rhb.Find(fathertb.Text));
            rhb.SelectionColor = Color.FromName("Orange");
            if(this.AaCB.Checked)
            {
                this.FindDownM(rhb, str);
            }
            else
            {
                if(this.findlast.Checked)
                {
                    this.FindUp(rhb, str);
                }
                else
                {
                    this.FindDown(rhb,str);
                }
            }
            /*
            if(fathertb.Text == "")
            {
                rhb.SelectionColor = Color.FromName("Black");
            }
            //MessageBox.Show(findresult);        //返回的查找结果的位置*/
        }

        private void searchbt_MouseEnter(object sender, EventArgs e)
        {
            search.ShowAlways = true;
            search.SetToolTip(this.searchbt, "查找");
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

        private void fathertb_TextChanged(object sender, EventArgs e)
        {
            searchbt.Enabled = true;
            //searchbt_Click(sender, e);
        }

        private void Edit_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                if(findpanel.Visible == true)
                {
                    findpanel.Visible = false;
                    findpanelflag = 0;
                }
            }
        }

        private void exitfindpanel_Click(object sender, EventArgs e)
        {
            if(findpanel.Visible == true)
            {
                this.findpanel.Visible = false;
                findpanelflag = 0;
            }  
        }

        /*
       public Control Finditem()
       {
           int count = 1;
           RichTextBox rhb = new RichTextBox();
           foreach (Control c in this.Controls)
           {
               if(c is RichTextBox && c.Name != "")
               {
                   rhb = c as RichTextBox;
               }
           }
           return rhb;
       }*/

        private void ABbt_MouseEnter(object sender, EventArgs e)
        {
            /*
            AB.ShowAlways = true;
            AB.SetToolTip(this.ABbt, "全字匹配");*/
        }

        private void nextbt_MouseEnter(object sender, EventArgs e)
        {
            /*
            next.ShowAlways = true;
            next.SetToolTip(this.nextbt, "下一个");*/
        }


        //未执行
        private void tabpage_GotFocus(object sender, EventArgs e)
        {

        }

        private void textname_Click(object sender, EventArgs e)
        {

        }

        private void untitled_Click(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void replaceallbt_Click(object sender, EventArgs e)
        {

        }

        private void Aabt_MouseEnter(object sender, EventArgs e)
        {

        }
        
        private void fathertb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Edit_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void untitled_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void texttype_Click(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {

        }

        private void tabpage_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
}
