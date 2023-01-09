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
            this.DarkMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBytesDropdown = new System.Windows.Forms.ToolStripMenuItem();
            this.attachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HexListBox = new System.Windows.Forms.ListBox();
            this.NodeContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DarkMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.generateCToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.generateCToolStripMenuItem.Text = "Generate C++";
            this.generateCToolStripMenuItem.Click += new System.EventHandler(this.generateCToolStripMenuItem_Click);
            // 
            // HexListBox
            // 
            this.HexListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.HexListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HexListBox.ContextMenuStrip = this.NodeContextStrip;
            this.HexListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HexListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.HexListBox.ForeColor = System.Drawing.SystemColors.Control;
            this.HexListBox.FormattingEnabled = true;
            this.HexListBox.ItemHeight = 20;
            this.HexListBox.Location = new System.Drawing.Point(119, 26);
            this.HexListBox.Name = "HexListBox";
            this.HexListBox.Size = new System.Drawing.Size(297, 281);
            this.HexListBox.TabIndex = 3;
            this.HexListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.HexListBox_DrawItem);
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
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, -4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(91, 280);
            this.listBox1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 281);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(416, 307);
            this.Controls.Add(this.HexListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DarkMenuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip = this.DarkMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(432, 346);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AppLoad);
            this.DarkMenuStrip.ResumeLayout(false);
            this.DarkMenuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip DarkMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attachToolStripMenuItem;
        private System.Windows.Forms.ListBox HexListBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem memoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddBytesDropdown;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateCToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip NodeContextStrip;
    }
}

