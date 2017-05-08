namespace StoreUpdateProgress
{
    partial class Form_AULog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AULog));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView_AULogs = new System.Windows.Forms.ListView();
            this.columnHeader_STID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DBVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_LogDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker_PullAULogs = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView_AULogs);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1326, 596);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto-Up Log Entries";
            // 
            // listView_AULogs
            // 
            this.listView_AULogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_STID,
            this.columnHeader_DBVersion,
            this.columnHeader_LogDateTime,
            this.columnHeader_Message});
            this.listView_AULogs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_AULogs.FullRowSelect = true;
            this.listView_AULogs.GridLines = true;
            this.listView_AULogs.Location = new System.Drawing.Point(17, 29);
            this.listView_AULogs.MultiSelect = false;
            this.listView_AULogs.Name = "listView_AULogs";
            this.listView_AULogs.Size = new System.Drawing.Size(1292, 544);
            this.listView_AULogs.TabIndex = 0;
            this.listView_AULogs.UseCompatibleStateImageBehavior = false;
            this.listView_AULogs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_STID
            // 
            this.columnHeader_STID.Text = "STID";
            // 
            // columnHeader_DBVersion
            // 
            this.columnHeader_DBVersion.Text = "Version";
            this.columnHeader_DBVersion.Width = 75;
            // 
            // columnHeader_LogDateTime
            // 
            this.columnHeader_LogDateTime.Text = "LogDateTime";
            this.columnHeader_LogDateTime.Width = 155;
            // 
            // columnHeader_Message
            // 
            this.columnHeader_Message.Text = "Details";
            this.columnHeader_Message.Width = 985;
            // 
            // backgroundWorker_PullAULogs
            // 
            this.backgroundWorker_PullAULogs.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_PullAULogs_DoWork);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 633);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1350, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // Form_AULog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 655);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 694);
            this.MinimumSize = new System.Drawing.Size(1366, 694);
            this.Name = "Form_AULog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoUp Logs for STID: XXXX";
            this.Shown += new System.EventHandler(this.Form_AULog_Shown);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView_AULogs;
        private System.Windows.Forms.ColumnHeader columnHeader_STID;
        private System.Windows.Forms.ColumnHeader columnHeader_DBVersion;
        private System.Windows.Forms.ColumnHeader columnHeader_LogDateTime;
        private System.Windows.Forms.ColumnHeader columnHeader_Message;
        private System.ComponentModel.BackgroundWorker backgroundWorker_PullAULogs;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}