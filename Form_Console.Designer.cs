namespace StoreUpdateProgress
{
    partial class Form_Console
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Console));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView_SUP = new System.Windows.Forms.ListView();
            this.columnHeader_STID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_StoreName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DBVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_TimeStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_TimeComplete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_BusinessDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Error = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Paused = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_PendingMsgCnt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip_ListViewSUP = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pauseThisStoreXXXXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unpauseThisStoreXXXXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pauseEveryStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unpauseEveryStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox_EnableAutoRefreshInterval = new System.Windows.Forms.CheckBox();
            this.comboBox_RefreshInterval = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar_Progress = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker_GetStoreUpdateProgress = new System.ComponentModel.BackgroundWorker();
            this.linkLabel_Start = new System.Windows.Forms.LinkLabel();
            this.timer_RefreshInterval = new System.Windows.Forms.Timer(this.components);
            this.checkBox_EnableColumClick = new System.Windows.Forms.CheckBox();
            this.label_CurrentHOS = new System.Windows.Forms.Label();
            this.linkLabel_ChangeHOS = new System.Windows.Forms.LinkLabel();
            this.checkbox_FilterStores = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip_ListViewSUP.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView_SUP);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1072, 522);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Store Autoup Progress";
            // 
            // listView_SUP
            // 
            this.listView_SUP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_STID,
            this.columnHeader_StoreName,
            this.columnHeader_DBVersion,
            this.columnHeader_TimeStart,
            this.columnHeader_TimeComplete,
            this.columnHeader_BusinessDate,
            this.columnHeader_Error,
            this.columnHeader_Paused,
            this.columnHeader_PendingMsgCnt});
            this.listView_SUP.ContextMenuStrip = this.contextMenuStrip_ListViewSUP;
            this.listView_SUP.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_SUP.FullRowSelect = true;
            this.listView_SUP.GridLines = true;
            this.listView_SUP.Location = new System.Drawing.Point(22, 31);
            this.listView_SUP.MultiSelect = false;
            this.listView_SUP.Name = "listView_SUP";
            this.listView_SUP.Size = new System.Drawing.Size(1029, 474);
            this.listView_SUP.TabIndex = 0;
            this.listView_SUP.UseCompatibleStateImageBehavior = false;
            this.listView_SUP.View = System.Windows.Forms.View.Details;
            this.listView_SUP.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_SUP_ColumnClick);
            this.listView_SUP.DoubleClick += new System.EventHandler(this.listView_SUP_DoubleClick);
            // 
            // columnHeader_STID
            // 
            this.columnHeader_STID.Text = "STID";
            // 
            // columnHeader_StoreName
            // 
            this.columnHeader_StoreName.Text = "Store Name";
            this.columnHeader_StoreName.Width = 110;
            // 
            // columnHeader_DBVersion
            // 
            this.columnHeader_DBVersion.Text = "Version";
            this.columnHeader_DBVersion.Width = 100;
            // 
            // columnHeader_TimeStart
            // 
            this.columnHeader_TimeStart.Text = "Time Last Started";
            this.columnHeader_TimeStart.Width = 175;
            // 
            // columnHeader_TimeComplete
            // 
            this.columnHeader_TimeComplete.Text = "Time Last Completed";
            this.columnHeader_TimeComplete.Width = 175;
            // 
            // columnHeader_BusinessDate
            // 
            this.columnHeader_BusinessDate.Text = "Business Date";
            this.columnHeader_BusinessDate.Width = 175;
            // 
            // columnHeader_Error
            // 
            this.columnHeader_Error.Text = "Error";
            this.columnHeader_Error.Width = 50;
            // 
            // columnHeader_Paused
            // 
            this.columnHeader_Paused.Text = "Is Paused";
            this.columnHeader_Paused.Width = 75;
            // 
            // columnHeader_PendingMsgCnt
            // 
            this.columnHeader_PendingMsgCnt.Text = "# Msgs.";
            this.columnHeader_PendingMsgCnt.Width = 71;
            // 
            // contextMenuStrip_ListViewSUP
            // 
            this.contextMenuStrip_ListViewSUP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseThisStoreXXXXToolStripMenuItem,
            this.unpauseThisStoreXXXXToolStripMenuItem,
            this.toolStripSeparator1,
            this.pauseEveryStoreToolStripMenuItem,
            this.unpauseEveryStoreToolStripMenuItem});
            this.contextMenuStrip_ListViewSUP.Name = "contextMenuStrip_ListViewSUP";
            this.contextMenuStrip_ListViewSUP.Size = new System.Drawing.Size(181, 98);
            // 
            // pauseThisStoreXXXXToolStripMenuItem
            // 
            this.pauseThisStoreXXXXToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pauseThisStoreXXXXToolStripMenuItem.Image")));
            this.pauseThisStoreXXXXToolStripMenuItem.Name = "pauseThisStoreXXXXToolStripMenuItem";
            this.pauseThisStoreXXXXToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pauseThisStoreXXXXToolStripMenuItem.Text = "Pause store";
            this.pauseThisStoreXXXXToolStripMenuItem.Click += new System.EventHandler(this.pauseThisStoreXXXXToolStripMenuItem_Click);
            // 
            // unpauseThisStoreXXXXToolStripMenuItem
            // 
            this.unpauseThisStoreXXXXToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("unpauseThisStoreXXXXToolStripMenuItem.Image")));
            this.unpauseThisStoreXXXXToolStripMenuItem.Name = "unpauseThisStoreXXXXToolStripMenuItem";
            this.unpauseThisStoreXXXXToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unpauseThisStoreXXXXToolStripMenuItem.Text = "Unpause store";
            this.unpauseThisStoreXXXXToolStripMenuItem.Click += new System.EventHandler(this.unpauseThisStoreXXXXToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // pauseEveryStoreToolStripMenuItem
            // 
            this.pauseEveryStoreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pauseEveryStoreToolStripMenuItem.Image")));
            this.pauseEveryStoreToolStripMenuItem.Name = "pauseEveryStoreToolStripMenuItem";
            this.pauseEveryStoreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pauseEveryStoreToolStripMenuItem.Text = "Pause every store";
            this.pauseEveryStoreToolStripMenuItem.Click += new System.EventHandler(this.pauseEveryStoreToolStripMenuItem_Click);
            // 
            // unpauseEveryStoreToolStripMenuItem
            // 
            this.unpauseEveryStoreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("unpauseEveryStoreToolStripMenuItem.Image")));
            this.unpauseEveryStoreToolStripMenuItem.Name = "unpauseEveryStoreToolStripMenuItem";
            this.unpauseEveryStoreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unpauseEveryStoreToolStripMenuItem.Text = "Unpause every store";
            this.unpauseEveryStoreToolStripMenuItem.Click += new System.EventHandler(this.unpauseEveryStoreToolStripMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(1025, 564);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Refresh";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkBox_EnableAutoRefreshInterval
            // 
            this.checkBox_EnableAutoRefreshInterval.AutoSize = true;
            this.checkBox_EnableAutoRefreshInterval.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_EnableAutoRefreshInterval.Location = new System.Drawing.Point(917, 15);
            this.checkBox_EnableAutoRefreshInterval.Name = "checkBox_EnableAutoRefreshInterval";
            this.checkBox_EnableAutoRefreshInterval.Size = new System.Drawing.Size(100, 17);
            this.checkBox_EnableAutoRefreshInterval.TabIndex = 3;
            this.checkBox_EnableAutoRefreshInterval.Text = "Auto Refresh";
            this.checkBox_EnableAutoRefreshInterval.UseVisualStyleBackColor = true;
            this.checkBox_EnableAutoRefreshInterval.CheckedChanged += new System.EventHandler(this.checkBox_EnableAutoRefreshInterval_CheckedChanged);
            // 
            // comboBox_RefreshInterval
            // 
            this.comboBox_RefreshInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_RefreshInterval.Enabled = false;
            this.comboBox_RefreshInterval.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_RefreshInterval.FormattingEnabled = true;
            this.comboBox_RefreshInterval.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "15",
            "20",
            "60"});
            this.comboBox_RefreshInterval.Location = new System.Drawing.Point(1023, 13);
            this.comboBox_RefreshInterval.Name = "comboBox_RefreshInterval";
            this.comboBox_RefreshInterval.Size = new System.Drawing.Size(61, 21);
            this.comboBox_RefreshInterval.TabIndex = 4;
            this.comboBox_RefreshInterval.SelectedIndexChanged += new System.EventHandler(this.comboBox_RefreshInterval_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 599);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1096, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // progressBar_Progress
            // 
            this.progressBar_Progress.Location = new System.Drawing.Point(700, 567);
            this.progressBar_Progress.Name = "progressBar_Progress";
            this.progressBar_Progress.Size = new System.Drawing.Size(51, 17);
            this.progressBar_Progress.TabIndex = 0;
            this.progressBar_Progress.Visible = false;
            // 
            // backgroundWorker_GetStoreUpdateProgress
            // 
            this.backgroundWorker_GetStoreUpdateProgress.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_GetStoreUpdateProgress_DoWork);
            // 
            // linkLabel_Start
            // 
            this.linkLabel_Start.AutoSize = true;
            this.linkLabel_Start.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_Start.Location = new System.Drawing.Point(984, 564);
            this.linkLabel_Start.Name = "linkLabel_Start";
            this.linkLabel_Start.Size = new System.Drawing.Size(35, 13);
            this.linkLabel_Start.TabIndex = 6;
            this.linkLabel_Start.TabStop = true;
            this.linkLabel_Start.Text = "Start";
            this.linkLabel_Start.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // timer_RefreshInterval
            // 
            this.timer_RefreshInterval.Tick += new System.EventHandler(this.timer_RefreshInterval_Tick);
            // 
            // checkBox_EnableColumClick
            // 
            this.checkBox_EnableColumClick.AutoSize = true;
            this.checkBox_EnableColumClick.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_EnableColumClick.Location = new System.Drawing.Point(767, 15);
            this.checkBox_EnableColumClick.Name = "checkBox_EnableColumClick";
            this.checkBox_EnableColumClick.Size = new System.Drawing.Size(144, 17);
            this.checkBox_EnableColumClick.TabIndex = 7;
            this.checkBox_EnableColumClick.Text = "Allow column sorting";
            this.checkBox_EnableColumClick.UseVisualStyleBackColor = true;
            this.checkBox_EnableColumClick.CheckedChanged += new System.EventHandler(this.checkBox_AllowSort_CheckedChanged);
            // 
            // label_CurrentHOS
            // 
            this.label_CurrentHOS.AutoSize = true;
            this.label_CurrentHOS.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurrentHOS.Location = new System.Drawing.Point(26, 16);
            this.label_CurrentHOS.Name = "label_CurrentHOS";
            this.label_CurrentHOS.Size = new System.Drawing.Size(85, 13);
            this.label_CurrentHOS.TabIndex = 8;
            this.label_CurrentHOS.Text = "Current HOS:";
            // 
            // linkLabel_ChangeHOS
            // 
            this.linkLabel_ChangeHOS.AutoSize = true;
            this.linkLabel_ChangeHOS.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_ChangeHOS.Location = new System.Drawing.Point(26, 564);
            this.linkLabel_ChangeHOS.Name = "linkLabel_ChangeHOS";
            this.linkLabel_ChangeHOS.Size = new System.Drawing.Size(123, 13);
            this.linkLabel_ChangeHOS.TabIndex = 9;
            this.linkLabel_ChangeHOS.TabStop = true;
            this.linkLabel_ChangeHOS.Text = "Change HOS Server";
            this.linkLabel_ChangeHOS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ChangeHOS_LinkClicked);
            // 
            // checkbox_FilterStores
            // 
            this.checkbox_FilterStores.AutoSize = true;
            this.checkbox_FilterStores.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_FilterStores.Location = new System.Drawing.Point(666, 15);
            this.checkbox_FilterStores.Name = "checkbox_FilterStores";
            this.checkbox_FilterStores.Size = new System.Drawing.Size(95, 17);
            this.checkbox_FilterStores.TabIndex = 10;
            this.checkbox_FilterStores.Text = "Filter Stores";
            this.checkbox_FilterStores.UseVisualStyleBackColor = true;
            this.checkbox_FilterStores.CheckedChanged += new System.EventHandler(this.checkbox_FilterStores_CheckedChanged);
            // 
            // Form_Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 621);
            this.Controls.Add(this.checkbox_FilterStores);
            this.Controls.Add(this.linkLabel_ChangeHOS);
            this.Controls.Add(this.label_CurrentHOS);
            this.Controls.Add(this.checkBox_EnableColumClick);
            this.Controls.Add(this.linkLabel_Start);
            this.Controls.Add(this.progressBar_Progress);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.comboBox_RefreshInterval);
            this.Controls.Add(this.checkBox_EnableAutoRefreshInterval);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1112, 660);
            this.MinimumSize = new System.Drawing.Size(1112, 660);
            this.Name = "Form_Console";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Update Progress";
            this.Load += new System.EventHandler(this.Form_Console_Load);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip_ListViewSUP.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView_SUP;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBox_EnableAutoRefreshInterval;
        private System.Windows.Forms.ComboBox comboBox_RefreshInterval;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ProgressBar progressBar_Progress;
        private System.Windows.Forms.ColumnHeader columnHeader_STID;
        private System.Windows.Forms.ColumnHeader columnHeader_StoreName;
        private System.Windows.Forms.ColumnHeader columnHeader_DBVersion;
        private System.Windows.Forms.ColumnHeader columnHeader_TimeStart;
        private System.Windows.Forms.ColumnHeader columnHeader_TimeComplete;
        private System.Windows.Forms.ColumnHeader columnHeader_BusinessDate;
        private System.Windows.Forms.ColumnHeader columnHeader_Error;
        private System.Windows.Forms.ColumnHeader columnHeader_Paused;
        private System.ComponentModel.BackgroundWorker backgroundWorker_GetStoreUpdateProgress;
        private System.Windows.Forms.LinkLabel linkLabel_Start;
        private System.Windows.Forms.Timer timer_RefreshInterval;
        private System.Windows.Forms.CheckBox checkBox_EnableColumClick;
        private System.Windows.Forms.Label label_CurrentHOS;
        private System.Windows.Forms.LinkLabel linkLabel_ChangeHOS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_ListViewSUP;
        private System.Windows.Forms.ToolStripMenuItem pauseThisStoreXXXXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unpauseThisStoreXXXXToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pauseEveryStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unpauseEveryStoreToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader_PendingMsgCnt;
        private System.Windows.Forms.CheckBox checkbox_FilterStores;
    }
}

