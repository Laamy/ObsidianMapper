namespace ObsidianMapper
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DarkMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBytesDropdown = new System.Windows.Forms.ToolStripMenuItem();
            this.attachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NodeContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DarkMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DarkMenuStrip
            // 
            this.DarkMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.DarkMenuStrip.Font = new System.Drawing.Font("Arial", 9.75F);
            this.DarkMenuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.DarkMenuStrip.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.DarkMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.memoryToolStripMenuItem,
            this.attachToolStripMenuItem,
            this.codeToolStripMenuItem});
            this.DarkMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.DarkMenuStrip.Name = "DarkMenuStrip";
            this.DarkMenuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.DarkMenuStrip.Size = new System.Drawing.Size(416, 26);
            this.DarkMenuStrip.TabIndex = 2;
            this.DarkMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.exitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitApplication);
            // 
            // memoryToolStripMenuItem
            // 
            this.memoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBytesDropdown});
            this.memoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.memoryToolStripMenuItem.Name = "memoryToolStripMenuItem";
            this.memoryToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.memoryToolStripMenuItem.Text = "Memory";
            // 
            // AddBytesDropdown
            // 
            this.AddBytesDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.AddBytesDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddBytesDropdown.ForeColor = System.Drawing.SystemColors.Control;
            this.AddBytesDropdown.Name = "AddBytesDropdown";
            this.AddBytesDropdown.Size = new System.Drawing.Size(135, 22);
            this.AddBytesDropdown.Text = "Add Bytes";
            // 
            // attachToolStripMenuItem
            // 
            this.attachToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.attachToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.attachToolStripMenuItem.Name = "attachToolStripMenuItem";
            this.attachToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.attachToolStripMenuItem.Text = "Attach";
            this.attachToolStripMenuItem.Click += new System.EventHandler(this.AttachToGame);
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateCToolStripMenuItem});
            this.codeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.codeToolStripMenuItem.Text = "Code";
            // 
            // generateCToolStripMenuItem
            // 
            this.generateCToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.generateCToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.generateCToolStripMenuItem.Name = "generateCToolStripMenuItem";
            this.generateCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generateCToolStripMenuItem.Text = "Generate C++";
            this.generateCToolStripMenuItem.Click += new System.EventHandler(this.generateCToolStripMenuItem_Click);
            // 
            // NodeContextStrip
            // 
            this.NodeContextStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.NodeContextStrip.Name = "NodeContextStrip";
            this.NodeContextStrip.ShowImageMargin = false;
            this.NodeContextStrip.Size = new System.Drawing.Size(36, 4);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(416, 307);
            this.Controls.Add(this.DarkMenuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.DarkMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(432, 346);
            this.Name = "Form1";
            this.Text = "ObsidianMapper";
            this.Load += new System.EventHandler(this.AppLoad);
            this.DarkMenuStrip.ResumeLayout(false);
            this.DarkMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip DarkMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attachToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem memoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddBytesDropdown;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateCToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip NodeContextStrip;
    }
}

