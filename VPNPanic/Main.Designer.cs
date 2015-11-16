namespace VPNPanic
{
    partial class Main
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
            this.tbIPRange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBoxActions = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbActivate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCurrentPublicIP = new System.Windows.Forms.TextBox();
            this.timerRedAlert = new System.Windows.Forms.Timer(this.components);
            this.timerPoll = new System.Windows.Forms.Timer(this.components);
            this.cbDeactivate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disableNetworkConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbIPRange
            // 
            this.tbIPRange.Location = new System.Drawing.Point(12, 82);
            this.tbIPRange.Name = "tbIPRange";
            this.tbIPRange.Size = new System.Drawing.Size(187, 26);
            this.tbIPRange.TabIndex = 0;
            this.tbIPRange.Text = "208.167.*.*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Good public IP range";
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 20;
            this.lbLog.Location = new System.Drawing.Point(12, 139);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(403, 104);
            this.lbLog.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Log";
            // 
            // checkedListBoxActions
            // 
            this.checkedListBoxActions.FormattingEnabled = true;
            this.checkedListBoxActions.Items.AddRange(new object[] {
            "Visual red alert",
            "Sound alarm",
            "Disable network connections",
            "Shutdown computer"});
            this.checkedListBoxActions.Location = new System.Drawing.Point(452, 78);
            this.checkedListBoxActions.Name = "checkedListBoxActions";
            this.checkedListBoxActions.Size = new System.Drawing.Size(244, 109);
            this.checkedListBoxActions.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Panic actions";
            // 
            // cbActivate
            // 
            this.cbActivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cbActivate.Enabled = false;
            this.cbActivate.Location = new System.Drawing.Point(452, 205);
            this.cbActivate.Name = "cbActivate";
            this.cbActivate.Size = new System.Drawing.Size(227, 38);
            this.cbActivate.TabIndex = 6;
            this.cbActivate.Text = "Activate";
            this.cbActivate.UseVisualStyleBackColor = false;
            this.cbActivate.Click += new System.EventHandler(this.cbActivate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current public IP address";
            // 
            // tbCurrentPublicIP
            // 
            this.tbCurrentPublicIP.BackColor = System.Drawing.Color.White;
            this.tbCurrentPublicIP.Location = new System.Drawing.Point(228, 82);
            this.tbCurrentPublicIP.Name = "tbCurrentPublicIP";
            this.tbCurrentPublicIP.ReadOnly = true;
            this.tbCurrentPublicIP.Size = new System.Drawing.Size(187, 26);
            this.tbCurrentPublicIP.TabIndex = 7;
            // 
            // timerRedAlert
            // 
            this.timerRedAlert.Interval = 500;
            this.timerRedAlert.Tick += new System.EventHandler(this.timerRedAlert_Tick);
            // 
            // timerPoll
            // 
            this.timerPoll.Interval = 5000;
            this.timerPoll.Tick += new System.EventHandler(this.timerPoll_Tick);
            // 
            // cbDeactivate
            // 
            this.cbDeactivate.BackColor = System.Drawing.Color.Red;
            this.cbDeactivate.Location = new System.Drawing.Point(452, 205);
            this.cbDeactivate.Name = "cbDeactivate";
            this.cbDeactivate.Size = new System.Drawing.Size(244, 38);
            this.cbDeactivate.TabIndex = 9;
            this.cbDeactivate.Text = "Deactivate";
            this.cbDeactivate.UseVisualStyleBackColor = false;
            this.cbDeactivate.Visible = false;
            this.cbDeactivate.Click += new System.EventHandler(this.cbDeactivate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disableNetworkConnectionsToolStripMenuItem,
            this.shutdownComputerToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 29);
            this.toolStripMenuItem1.Text = "Test";
            // 
            // disableNetworkConnectionsToolStripMenuItem
            // 
            this.disableNetworkConnectionsToolStripMenuItem.Name = "disableNetworkConnectionsToolStripMenuItem";
            this.disableNetworkConnectionsToolStripMenuItem.Size = new System.Drawing.Size(324, 30);
            this.disableNetworkConnectionsToolStripMenuItem.Text = "Disable network connections";
            this.disableNetworkConnectionsToolStripMenuItem.Click += new System.EventHandler(this.disableNetworkConnectionsToolStripMenuItem_Click);
            // 
            // shutdownComputerToolStripMenuItem
            // 
            this.shutdownComputerToolStripMenuItem.Name = "shutdownComputerToolStripMenuItem";
            this.shutdownComputerToolStripMenuItem.Size = new System.Drawing.Size(324, 30);
            this.shutdownComputerToolStripMenuItem.Text = "Shutdown computer";
            this.shutdownComputerToolStripMenuItem.Click += new System.EventHandler(this.shutdownComputerToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 273);
            this.Controls.Add(this.cbDeactivate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCurrentPublicIP);
            this.Controls.Add(this.cbActivate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBoxActions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIPRange);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPN Panic";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIPRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBoxActions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cbActivate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCurrentPublicIP;
        private System.Windows.Forms.Timer timerRedAlert;
        private System.Windows.Forms.Timer timerPoll;
        private System.Windows.Forms.Button cbDeactivate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disableNetworkConnectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownComputerToolStripMenuItem;
    }
}

