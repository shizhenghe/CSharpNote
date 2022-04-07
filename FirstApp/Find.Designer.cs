namespace FirstApp
{
    partial class Find
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Find));
            this.fathertb = new System.Windows.Forms.ComboBox();
            this.subtb = new System.Windows.Forms.ComboBox();
            this.Aabt = new System.Windows.Forms.Button();
            this.ABbt = new System.Windows.Forms.Button();
            this.nextbt = new System.Windows.Forms.Button();
            this.searchbt = new System.Windows.Forms.Button();
            this.Aa = new System.Windows.Forms.ToolTip(this.components);
            this.AB = new System.Windows.Forms.ToolTip(this.components);
            this.next = new System.Windows.Forms.ToolTip(this.components);
            this.search = new System.Windows.Forms.ToolTip(this.components);
            this.replacebt = new System.Windows.Forms.Button();
            this.replaceallbt = new System.Windows.Forms.Button();
            this.replace = new System.Windows.Forms.ToolTip(this.components);
            this.replaceall = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // fathertb
            // 
            this.fathertb.BackColor = System.Drawing.SystemColors.Control;
            this.fathertb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fathertb.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.fathertb.FormattingEnabled = true;
            this.fathertb.Location = new System.Drawing.Point(64, 15);
            this.fathertb.Margin = new System.Windows.Forms.Padding(4);
            this.fathertb.Name = "fathertb";
            this.fathertb.Size = new System.Drawing.Size(367, 29);
            this.fathertb.TabIndex = 0;
            this.fathertb.Text = "查找...";
            this.fathertb.Click += new System.EventHandler(this.fathertb_Click);
            // 
            // subtb
            // 
            this.subtb.BackColor = System.Drawing.SystemColors.Control;
            this.subtb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtb.FormattingEnabled = true;
            this.subtb.Location = new System.Drawing.Point(64, 61);
            this.subtb.Margin = new System.Windows.Forms.Padding(4);
            this.subtb.Name = "subtb";
            this.subtb.Size = new System.Drawing.Size(367, 28);
            this.subtb.TabIndex = 1;
            this.subtb.Click += new System.EventHandler(this.subtb_Click);
            // 
            // Aabt
            // 
            this.Aabt.FlatAppearance.BorderSize = 0;
            this.Aabt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aabt.Image = ((System.Drawing.Image)(resources.GetObject("Aabt.Image")));
            this.Aabt.Location = new System.Drawing.Point(9, 5);
            this.Aabt.Name = "Aabt";
            this.Aabt.Size = new System.Drawing.Size(48, 38);
            this.Aabt.TabIndex = 2;
            this.Aabt.UseVisualStyleBackColor = true;
            this.Aabt.Click += new System.EventHandler(this.Aabt_Click);
            this.Aabt.MouseEnter += new System.EventHandler(this.Aabt_MouseEnter);
            // 
            // ABbt
            // 
            this.ABbt.FlatAppearance.BorderSize = 0;
            this.ABbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ABbt.Image = ((System.Drawing.Image)(resources.GetObject("ABbt.Image")));
            this.ABbt.Location = new System.Drawing.Point(12, 51);
            this.ABbt.Name = "ABbt";
            this.ABbt.Size = new System.Drawing.Size(48, 38);
            this.ABbt.TabIndex = 3;
            this.ABbt.UseVisualStyleBackColor = true;
            this.ABbt.MouseEnter += new System.EventHandler(this.ABbt_MouseEnter);
            // 
            // nextbt
            // 
            this.nextbt.FlatAppearance.BorderSize = 0;
            this.nextbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextbt.Image = ((System.Drawing.Image)(resources.GetObject("nextbt.Image")));
            this.nextbt.Location = new System.Drawing.Point(478, 15);
            this.nextbt.Name = "nextbt";
            this.nextbt.Size = new System.Drawing.Size(34, 26);
            this.nextbt.TabIndex = 4;
            this.nextbt.UseVisualStyleBackColor = true;
            this.nextbt.MouseEnter += new System.EventHandler(this.nextbt_MouseEnter);
            // 
            // searchbt
            // 
            this.searchbt.BackColor = System.Drawing.SystemColors.Control;
            this.searchbt.FlatAppearance.BorderSize = 0;
            this.searchbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbt.Image = ((System.Drawing.Image)(resources.GetObject("searchbt.Image")));
            this.searchbt.Location = new System.Drawing.Point(438, 17);
            this.searchbt.Name = "searchbt";
            this.searchbt.Size = new System.Drawing.Size(39, 26);
            this.searchbt.TabIndex = 5;
            this.searchbt.UseVisualStyleBackColor = false;
            this.searchbt.Click += new System.EventHandler(this.searchbt_Click);
            this.searchbt.MouseEnter += new System.EventHandler(this.searchbt_MouseEnter);
            // 
            // replacebt
            // 
            this.replacebt.FlatAppearance.BorderSize = 0;
            this.replacebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replacebt.Image = ((System.Drawing.Image)(resources.GetObject("replacebt.Image")));
            this.replacebt.Location = new System.Drawing.Point(438, 61);
            this.replacebt.Name = "replacebt";
            this.replacebt.Size = new System.Drawing.Size(34, 28);
            this.replacebt.TabIndex = 6;
            this.replacebt.UseVisualStyleBackColor = true;
            this.replacebt.MouseEnter += new System.EventHandler(this.replacebt_MouseEnter);
            // 
            // replaceallbt
            // 
            this.replaceallbt.FlatAppearance.BorderSize = 0;
            this.replaceallbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replaceallbt.Image = ((System.Drawing.Image)(resources.GetObject("replaceallbt.Image")));
            this.replaceallbt.Location = new System.Drawing.Point(478, 61);
            this.replaceallbt.Name = "replaceallbt";
            this.replaceallbt.Size = new System.Drawing.Size(34, 28);
            this.replaceallbt.TabIndex = 7;
            this.replaceallbt.UseVisualStyleBackColor = true;
            this.replaceallbt.MouseEnter += new System.EventHandler(this.replaceallbt_MouseEnter);
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(532, 121);
            this.Controls.Add(this.replaceallbt);
            this.Controls.Add(this.replacebt);
            this.Controls.Add(this.searchbt);
            this.Controls.Add(this.nextbt);
            this.Controls.Add(this.ABbt);
            this.Controls.Add(this.Aabt);
            this.Controls.Add(this.subtb);
            this.Controls.Add(this.fathertb);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 11.5F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Find";
            this.Text = "Fisher-Find";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Find_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Aabt;
        private System.Windows.Forms.Button ABbt;
        private System.Windows.Forms.ToolTip Aa;
        private System.Windows.Forms.ToolTip AB;
        private System.Windows.Forms.ToolTip next;
        private System.Windows.Forms.ToolTip search;
        public System.Windows.Forms.Button replacebt;
        private System.Windows.Forms.Button replaceallbt;
        private System.Windows.Forms.ToolTip replace;
        private System.Windows.Forms.ToolTip replaceall;
        public System.Windows.Forms.ComboBox fathertb;
        public System.Windows.Forms.ComboBox subtb;
        public System.Windows.Forms.Button nextbt;
        public System.Windows.Forms.Button searchbt;
    }
}