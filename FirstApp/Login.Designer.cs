namespace FirstApp
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
 
        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.eye = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.QR = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.usernameTB = new System.Windows.Forms.ComboBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.sign = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.LinkLabel();
            this.admin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // eye
            // 
            resources.ApplyResources(this.eye, "eye");
            this.eye.Name = "eye";
            this.eye.UseVisualStyleBackColor = true;
            this.eye.Click += new System.EventHandler(this.eye_Click_1);
            // 
            // title
            // 
            resources.ApplyResources(this.title, "title");
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Name = "title";
            // 
            // QR
            // 
            this.QR.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.QR, "QR");
            this.QR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.QR.Name = "QR";
            this.QR.UseVisualStyleBackColor = false;
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.Register, "Register");
            this.Register.Name = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click_1);
            // 
            // linkLabel2
            // 
            resources.ApplyResources(this.linkLabel2, "linkLabel2");
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.TabStop = true;
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // usernameTB
            // 
            this.usernameTB.ForeColor = System.Drawing.Color.Gray;
            this.usernameTB.FormattingEnabled = true;
            resources.ApplyResources(this.usernameTB, "usernameTB");
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.SelectedIndexChanged += new System.EventHandler(this.usernameTB_SelectedIndexChanged_1);
            this.usernameTB.Click += new System.EventHandler(this.usernameTB_Click_1);
            this.usernameTB.LostFocus += new System.EventHandler(this.usernameTB_LostFocus1);
            // 
            // passwordTB
            // 
            this.passwordTB.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.passwordTB, "passwordTB");
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Click += new System.EventHandler(this.passwordTB_Click_1);
            this.passwordTB.TextChanged += new System.EventHandler(this.passwordTB_TextChanged_1);
            this.passwordTB.LostFocus += new System.EventHandler(this.passwordTB_LostFocus1);
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.sign, "sign");
            this.sign.Name = "sign";
            this.sign.UseVisualStyleBackColor = false;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            this.sign.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sign_KeyDown);
            // 
            // search
            // 
            this.search.ActiveLinkColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.search, "search");
            this.search.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.search.LinkColor = System.Drawing.Color.Gray;
            this.search.Name = "search";
            this.search.TabStop = true;
            this.search.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_2);
            // 
            // admin
            // 
            this.admin.ActiveLinkColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.admin, "admin");
            this.admin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.admin.LinkColor = System.Drawing.Color.Gray;
            this.admin.Name = "admin";
            this.admin.TabStop = true;
            this.admin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.admin_LinkClicked);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.admin);
            this.Controls.Add(this.search);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eye);
            this.Controls.Add(this.title);
            this.Controls.Add(this.QR);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.sign);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button eye;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button QR;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.LinkLabel linkLabel2;
        public System.Windows.Forms.ComboBox usernameTB;
        public System.Windows.Forms.TextBox passwordTB;
        public System.Windows.Forms.Button sign;
        private System.Windows.Forms.LinkLabel search;
        private System.Windows.Forms.LinkLabel admin;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.CheckBox checkBox1;
    }
}

