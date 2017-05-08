namespace StoreUpdateProgress
{
    partial class Form_StoreFilterSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_StoreFilterSelect));
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView_DestinationStoreList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_LevelName = new System.Windows.Forms.ComboBox();
            this.checkedListBox_LevelItems = new System.Windows.Forms.CheckedListBox();
            this.linkLabel_Deselect = new System.Windows.Forms.LinkLabel();
            this.linkLabel_SelectAll = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker_RefreshLevelList = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_InsertOperation = new System.ComponentModel.BackgroundWorker();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(288, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(290, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 64);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(290, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 64);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(552, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView_DestinationStoreList);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(372, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 546);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination List";
            // 
            // listView_DestinationStoreList
            // 
            this.listView_DestinationStoreList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_DestinationStoreList.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_DestinationStoreList.ForeColor = System.Drawing.Color.Black;
            this.listView_DestinationStoreList.Location = new System.Drawing.Point(15, 33);
            this.listView_DestinationStoreList.Name = "listView_DestinationStoreList";
            this.listView_DestinationStoreList.Size = new System.Drawing.Size(225, 497);
            this.listView_DestinationStoreList.TabIndex = 0;
            this.listView_DestinationStoreList.UseCompatibleStateImageBehavior = false;
            this.listView_DestinationStoreList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STID";
            this.columnHeader1.Width = 190;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_LevelName);
            this.groupBox1.Controls.Add(this.checkedListBox_LevelItems);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 546);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Level:";
            // 
            // comboBox_LevelName
            // 
            this.comboBox_LevelName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_LevelName.ForeColor = System.Drawing.Color.Black;
            this.comboBox_LevelName.FormattingEnabled = true;
            this.comboBox_LevelName.Items.AddRange(new object[] {
            "Corporation",
            "Region",
            "District",
            "Store",
            "State"});
            this.comboBox_LevelName.Location = new System.Drawing.Point(55, 33);
            this.comboBox_LevelName.Name = "comboBox_LevelName";
            this.comboBox_LevelName.Size = new System.Drawing.Size(184, 21);
            this.comboBox_LevelName.TabIndex = 3;
            this.comboBox_LevelName.SelectedIndexChanged += new System.EventHandler(this.comboBox_LevelName_SelectedIndexChanged);
            // 
            // checkedListBox_LevelItems
            // 
            this.checkedListBox_LevelItems.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_LevelItems.ForeColor = System.Drawing.Color.Black;
            this.checkedListBox_LevelItems.FormattingEnabled = true;
            this.checkedListBox_LevelItems.Location = new System.Drawing.Point(16, 60);
            this.checkedListBox_LevelItems.Name = "checkedListBox_LevelItems";
            this.checkedListBox_LevelItems.Size = new System.Drawing.Size(223, 468);
            this.checkedListBox_LevelItems.TabIndex = 0;
            // 
            // linkLabel_Deselect
            // 
            this.linkLabel_Deselect.AutoSize = true;
            this.linkLabel_Deselect.Location = new System.Drawing.Point(209, 561);
            this.linkLabel_Deselect.Name = "linkLabel_Deselect";
            this.linkLabel_Deselect.Size = new System.Drawing.Size(63, 13);
            this.linkLabel_Deselect.TabIndex = 11;
            this.linkLabel_Deselect.TabStop = true;
            this.linkLabel_Deselect.Text = "Deselect All";
            this.linkLabel_Deselect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Deselect_LinkClicked);
            // 
            // linkLabel_SelectAll
            // 
            this.linkLabel_SelectAll.AutoSize = true;
            this.linkLabel_SelectAll.Location = new System.Drawing.Point(152, 561);
            this.linkLabel_SelectAll.Name = "linkLabel_SelectAll";
            this.linkLabel_SelectAll.Size = new System.Drawing.Size(51, 13);
            this.linkLabel_SelectAll.TabIndex = 10;
            this.linkLabel_SelectAll.TabStop = true;
            this.linkLabel_SelectAll.Text = "Select All";
            this.linkLabel_SelectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_SelectAll_LinkClicked);
            // 
            // backgroundWorker_RefreshLevelList
            // 
            this.backgroundWorker_RefreshLevelList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_RefreshLevelList_DoWork);
            // 
            // Form_StoreFilterSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 607);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel_Deselect);
            this.Controls.Add(this.linkLabel_SelectAll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_StoreFilterSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter stores";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView_DestinationStoreList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_LevelName;
        private System.Windows.Forms.CheckedListBox checkedListBox_LevelItems;
        private System.Windows.Forms.LinkLabel linkLabel_Deselect;
        private System.Windows.Forms.LinkLabel linkLabel_SelectAll;
        private System.ComponentModel.BackgroundWorker backgroundWorker_RefreshLevelList;
        private System.ComponentModel.BackgroundWorker backgroundWorker_InsertOperation;
    }
}