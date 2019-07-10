namespace M3U_Editor
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importM3UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportM3UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.CBGroups = new System.Windows.Forms.ComboBox();
            this.lbChannels = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(306, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importM3UToolStripMenuItem,
            this.exportM3UToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importM3UToolStripMenuItem
            // 
            this.importM3UToolStripMenuItem.Enabled = false;
            this.importM3UToolStripMenuItem.Name = "importM3UToolStripMenuItem";
            this.importM3UToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importM3UToolStripMenuItem.Text = "Import M3U";
            this.importM3UToolStripMenuItem.Click += new System.EventHandler(this.ImportM3UToolStripMenuItem_Click);
            // 
            // exportM3UToolStripMenuItem
            // 
            this.exportM3UToolStripMenuItem.Enabled = false;
            this.exportM3UToolStripMenuItem.Name = "exportM3UToolStripMenuItem";
            this.exportM3UToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportM3UToolStripMenuItem.Text = "Export M3U";
            this.exportM3UToolStripMenuItem.Click += new System.EventHandler(this.ExportM3UToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(12, 27);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(280, 23);
            this.BtnBrowse.TabIndex = 1;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBGroups
            // 
            this.CBGroups.FormattingEnabled = true;
            this.CBGroups.Location = new System.Drawing.Point(12, 56);
            this.CBGroups.Name = "CBGroups";
            this.CBGroups.Size = new System.Drawing.Size(280, 21);
            this.CBGroups.TabIndex = 5;
            this.CBGroups.SelectedIndexChanged += new System.EventHandler(this.CBGroups_SelectedIndexChanged);
            // 
            // lbChannels
            // 
            this.lbChannels.FormattingEnabled = true;
            this.lbChannels.Location = new System.Drawing.Point(12, 83);
            this.lbChannels.Name = "lbChannels";
            this.lbChannels.Size = new System.Drawing.Size(280, 355);
            this.lbChannels.TabIndex = 6;
            this.lbChannels.SelectedIndexChanged += new System.EventHandler(this.lbChannels_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 450);
            this.Controls.Add(this.lbChannels);
            this.Controls.Add(this.CBGroups);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importM3UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportM3UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.ComboBox CBGroups;
        private System.Windows.Forms.ListBox lbChannels;
    }
}

