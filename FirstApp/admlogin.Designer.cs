namespace FirstApp
{
    partial class admlogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admlogin));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.eye = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.usernameTB = new System.Windows.Forms.ComboBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.sign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(109, 226);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 42);
            this.button2.TabIndex = 57;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(109, 149);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 32);
            this.button1.TabIndex = 56;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // eye
            // 
            this.eye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eye.Image = ((System.Drawing.Image)(resources.GetObject("eye.Image")));
            this.eye.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.eye.Location = new System.Drawing.Point(468, 231);
            this.eye.Margin = new System.Windows.Forms.Padding(4);
            this.eye.Name = "eye";
            this.eye.Size = new System.Drawing.Size(33, 25);
            this.eye.TabIndex = 55;
            this.eye.UseVisualStyleBackColor = true;
            this.eye.Click += new System.EventHandler(this.eye_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Mongolian Baiti", 16F);
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.title.Location = new System.Drawing.Point(160, 66);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(257, 29);
            this.title.TabIndex = 54;
            this.title.Text = "Welcome login Fisher";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.linkLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.Lime;
            this.linkLabel2.Location = new System.Drawing.Point(432, 304);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(58, 16);
            this.linkLabel2.TabIndex = 53;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "FindPW";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.checkBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox2.Location = new System.Drawing.Point(264, 303);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 20);
            this.checkBox2.TabIndex = 52;
            this.checkBox2.Text = "HoldPW";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.checkBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox1.Location = new System.Drawing.Point(109, 303);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 20);
            this.checkBox1.TabIndex = 51;
            this.checkBox1.Text = "Autologin";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // usernameTB
            // 
            this.usernameTB.ForeColor = System.Drawing.Color.Gray;
            this.usernameTB.FormattingEnabled = true;
            this.usernameTB.Location = new System.Drawing.Point(165, 149);
            this.usernameTB.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(336, 28);
            this.usernameTB.TabIndex = 50;
            this.usernameTB.Text = "Account";
            this.usernameTB.Click += new System.EventHandler(this.usernameTB_Click);
            this.usernameTB.LostFocus += new System.EventHandler(this.usernameTB_LostFocus);
            // 
            // passwordTB
            // 
            this.passwordTB.ForeColor = System.Drawing.Color.Gray;
            this.passwordTB.Location = new System.Drawing.Point(165, 231);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(336, 30);
            this.passwordTB.TabIndex = 49;
            this.passwordTB.Text = "Password";
            this.passwordTB.Click += new System.EventHandler(this.passwordTB_Click);
            this.passwordTB.TextChanged += new System.EventHandler(this.passwordTB_TextChanged);
            this.passwordTB.LostFocus += new System.EventHandler(this.passwordTB_LostFocus);
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.Color.AliceBlue;
            this.sign.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sign.Location = new System.Drawing.Point(109, 357);
            this.sign.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(393, 42);
            this.sign.TabIndex = 48;
            this.sign.Text = "login";
            this.sign.UseVisualStyleBackColor = false;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // admlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 454);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eye);
            this.Controls.Add(this.title);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.sign);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 11.5F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "admlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fisher-admlogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.admlogin_FormClosing);
            this.Load += new System.EventHandler(this.admlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button eye;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.ComboBox usernameTB;
        public System.Windows.Forms.TextBox passwordTB;
        public System.Windows.Forms.Button sign;
    }
}