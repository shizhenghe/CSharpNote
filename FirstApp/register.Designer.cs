namespace FirstApp
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.areanum = new System.Windows.Forms.ComboBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.telTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Signupnow = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.message = new System.Windows.Forms.Label();
            this.regeye = new System.Windows.Forms.Button();
            this.people = new System.Windows.Forms.Button();
            this.clock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to MyAPP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Everday, enjoy your life";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // usernameTB
            // 
            this.usernameTB.Font = new System.Drawing.Font("Mongolian Baiti", 14F);
            this.usernameTB.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.usernameTB.Location = new System.Drawing.Point(232, 139);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(244, 34);
            this.usernameTB.TabIndex = 2;
            this.usernameTB.Text = "Nickname";
            this.usernameTB.Click += new System.EventHandler(this.usernameTB_Click);
            this.usernameTB.TextChanged += new System.EventHandler(this.usernameTB_TextChanged);
            this.usernameTB.LostFocus += new System.EventHandler(this.Username_LostFocus);
            // 
            // areanum
            // 
            this.areanum.Font = new System.Drawing.Font("Mongolian Baiti", 15F);
            this.areanum.FormattingEnabled = true;
            this.areanum.Items.AddRange(new object[] {
            "+86",
            "+55",
            "+435",
            "+4543",
            "+54",
            "+553"});
            this.areanum.Location = new System.Drawing.Point(187, 258);
            this.areanum.Name = "areanum";
            this.areanum.Size = new System.Drawing.Size(63, 34);
            this.areanum.TabIndex = 3;
            this.areanum.Text = "+86";
            this.areanum.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Mongolian Baiti", 14F);
            this.passwordTB.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordTB.Location = new System.Drawing.Point(232, 194);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(244, 34);
            this.passwordTB.TabIndex = 4;
            this.passwordTB.Text = "Password";
            this.passwordTB.Click += new System.EventHandler(this.passwordTB_Click);
            this.passwordTB.TextChanged += new System.EventHandler(this.passwordTB_TextChanged);
            this.passwordTB.LostFocus += new System.EventHandler(this.PasswordTB_LostFocus);
            // 
            // telTB
            // 
            this.telTB.Font = new System.Drawing.Font("Mongolian Baiti", 15F);
            this.telTB.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.telTB.Location = new System.Drawing.Point(258, 258);
            this.telTB.Name = "telTB";
            this.telTB.Size = new System.Drawing.Size(217, 36);
            this.telTB.TabIndex = 5;
            this.telTB.Text = "tel";
            this.telTB.Click += new System.EventHandler(this.telTB_Click);
            this.telTB.LostFocus += new System.EventHandler(this.telTB_LostFocus);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.label3.Location = new System.Drawing.Point(183, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "You can find your password by the phone number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Signupnow
            // 
            this.Signupnow.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Signupnow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Signupnow.Font = new System.Drawing.Font("Mongolian Baiti", 15F);
            this.Signupnow.Location = new System.Drawing.Point(187, 352);
            this.Signupnow.Name = "Signupnow";
            this.Signupnow.Size = new System.Drawing.Size(283, 47);
            this.Signupnow.TabIndex = 7;
            this.Signupnow.Text = "Sign up now";
            this.Signupnow.UseVisualStyleBackColor = false;
            this.Signupnow.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FloralWhite;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Mongolian Baiti", 15F);
            this.linkLabel1.ForeColor = System.Drawing.Color.Lime;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Lime;
            this.linkLabel1.Location = new System.Drawing.Point(302, 418);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 26);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<<<";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(277, 107);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 16);
            this.message.TabIndex = 9;
            // 
            // regeye
            // 
            this.regeye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regeye.ForeColor = System.Drawing.Color.Transparent;
            this.regeye.Image = ((System.Drawing.Image)(resources.GetObject("regeye.Image")));
            this.regeye.Location = new System.Drawing.Point(445, 195);
            this.regeye.Name = "regeye";
            this.regeye.Size = new System.Drawing.Size(30, 25);
            this.regeye.TabIndex = 10;
            this.regeye.UseVisualStyleBackColor = true;
            this.regeye.Click += new System.EventHandler(this.regeye_Click);
            // 
            // people
            // 
            this.people.FlatAppearance.BorderSize = 0;
            this.people.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.people.Image = ((System.Drawing.Image)(resources.GetObject("people.Image")));
            this.people.Location = new System.Drawing.Point(187, 139);
            this.people.Name = "people";
            this.people.Size = new System.Drawing.Size(39, 31);
            this.people.TabIndex = 11;
            this.people.UseVisualStyleBackColor = true;
            // 
            // clock
            // 
            this.clock.FlatAppearance.BorderSize = 0;
            this.clock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clock.Image = ((System.Drawing.Image)(resources.GetObject("clock.Image")));
            this.clock.Location = new System.Drawing.Point(187, 192);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(39, 31);
            this.clock.TabIndex = 12;
            this.clock.UseVisualStyleBackColor = true;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 488);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.people);
            this.Controls.Add(this.regeye);
            this.Controls.Add(this.message);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Signupnow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.telTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.areanum);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "register";
            this.Text = "Fisher-register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.register_FormClosing);
            this.Load += new System.EventHandler(this.register_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.register_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox areanum;
        private System.Windows.Forms.TextBox telTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.Button Signupnow;
        public System.Windows.Forms.TextBox usernameTB;
        public System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button regeye;
        private System.Windows.Forms.Button people;
        private System.Windows.Forms.Button clock;
    }
}