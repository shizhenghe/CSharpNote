namespace FirstApp
{
    partial class newfile
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
            this.entrybt = new System.Windows.Forms.Button();
            this.filenametb = new System.Windows.Forms.TextBox();
            this.filetypecb = new System.Windows.Forms.ComboBox();
            this.FileNamelb = new System.Windows.Forms.Label();
            this.filetypelb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // entrybt
            // 
            this.entrybt.Location = new System.Drawing.Point(229, 196);
            this.entrybt.Name = "entrybt";
            this.entrybt.Size = new System.Drawing.Size(110, 25);
            this.entrybt.TabIndex = 0;
            this.entrybt.Text = "Entry";
            this.entrybt.UseVisualStyleBackColor = true;
            this.entrybt.Click += new System.EventHandler(this.entrybt_Click);
            // 
            // filenametb
            // 
            this.filenametb.Location = new System.Drawing.Point(176, 71);
            this.filenametb.Name = "filenametb";
            this.filenametb.Size = new System.Drawing.Size(237, 25);
            this.filenametb.TabIndex = 1;
            // 
            // filetypecb
            // 
            this.filetypecb.FormattingEnabled = true;
            this.filetypecb.Items.AddRange(new object[] {
            ".c",
            ".cs",
            ".cpp",
            ".py",
            ".html",
            ".java",
            ".php",
            ".jsp"});
            this.filetypecb.Location = new System.Drawing.Point(176, 122);
            this.filetypecb.Name = "filetypecb";
            this.filetypecb.Size = new System.Drawing.Size(237, 24);
            this.filetypecb.TabIndex = 2;
            // 
            // FileNamelb
            // 
            this.FileNamelb.AutoSize = true;
            this.FileNamelb.Location = new System.Drawing.Point(102, 75);
            this.FileNamelb.Name = "FileNamelb";
            this.FileNamelb.Size = new System.Drawing.Size(68, 16);
            this.FileNamelb.TabIndex = 3;
            this.FileNamelb.Text = "FileName";
            // 
            // filetypelb
            // 
            this.filetypelb.AutoSize = true;
            this.filetypelb.Location = new System.Drawing.Point(102, 126);
            this.filetypelb.Name = "filetypelb";
            this.filetypelb.Size = new System.Drawing.Size(63, 16);
            this.filetypelb.TabIndex = 4;
            this.filetypelb.Text = "FileType";
            // 
            // newfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 269);
            this.Controls.Add(this.filetypelb);
            this.Controls.Add(this.FileNamelb);
            this.Controls.Add(this.filetypecb);
            this.Controls.Add(this.filenametb);
            this.Controls.Add(this.entrybt);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "newfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fisher-newfile";
            this.Load += new System.EventHandler(this.newfile_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newfile_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button entrybt;
        private System.Windows.Forms.Label FileNamelb;
        private System.Windows.Forms.Label filetypelb;
        public System.Windows.Forms.TextBox filenametb;
        public System.Windows.Forms.ComboBox filetypecb;
    }
}