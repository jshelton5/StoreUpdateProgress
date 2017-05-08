using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

namespace StoreUpdateProgress
{
    public partial class Form_Console : Form
    {
        public Form_Console()
        {
            InitializeComponent();

            lvwColumnSorter = new ListViewColumnSorter();
        }

        private ListViewColumnSorter lvwColumnSorter;

        public void PauseAllStores(string SQLHostName, string SQLInstanceName, string SQLDatabase, string ConnectionTimeout, string user, string pwd, string stid)
        {
            string SQLQuery_PauseStore = "UPDATE Stores SET DisallowAutoUp=1;";

            SqlConnection myConnection = new SqlConnection("user=" + user + ";" + "password=" + pwd + ";server=" + SQLHostName + @"\" + SQLInstanceName + ";" + "Trusted_Connection=no;"
                                                                    + "database=" + SQLDatabase + ";" + "connection timeout=" + ConnectionTimeout);

            SqlCommand myCommand = new SqlCommand(SQLQuery_PauseStore, myConnection);
            myCommand.CommandType = CommandType.Text;

            try
            {
                myConnection.Open();
                if (myConnection.State == ConnectionState.Open)
                {
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }

                if (!backgroundWorker_GetStoreUpdateProgress.IsBusy)
                {
                    backgroundWorker_GetStoreUpdateProgress.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UnPauseAllStores(string SQLHostName, string SQLInstanceName, string SQLDatabase, string ConnectionTimeout, string user, string pwd, string stid)
        {
            string SQLQuery_PauseStore = "UPDATE Stores SET DisallowAutoUp=0;";

            SqlConnection myConnection = new SqlConnection("user=" + user + ";" + "password=" + pwd + ";server=" + SQLHostName + @"\" + SQLInstanceName + ";" + "Trusted_Connection=no;"
                                                                    + "database=" + SQLDatabase + ";" + "connection timeout=" + ConnectionTimeout);

            SqlCommand myCommand = new SqlCommand(SQLQuery_PauseStore, myConnection);
            myCommand.CommandType = CommandType.Text;

            try
            {
                myConnection.Open();
                if (myConnection.State == ConnectionState.Open)
                {
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }

                if (!backgroundWorker_GetStoreUpdateProgress.IsBusy)
                {
                    backgroundWorker_GetStoreUpdateProgress.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PauseSingleStore(string SQLHostName, string SQLInstanceName, string SQLDatabase, string ConnectionTimeout, string user, string pwd, string stid)
        {
            string SQLQuery_PauseStore = "UPDATE Stores SET DisallowAutoUp=1 WHERE STID=" + stid + ";";

            SqlConnection myConnection = new SqlConnection("user=" + user + ";" + "password=" + pwd + ";server=" + SQLHostName + @"\" + SQLInstanceName + ";" + "Trusted_Connection=no;"
                                                                    + "database=" + SQLDatabase + ";" + "connection timeout=" + ConnectionTimeout);

            SqlCommand myCommand = new SqlCommand(SQLQuery_PauseStore, myConnection);
            myCommand.CommandType = CommandType.Text;

            try
            {
                myConnection.Open();
                if (myConnection.State == ConnectionState.Open)
                {
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }

                if (!backgroundWorker_GetStoreUpdateProgress.IsBusy)
                {
                    backgroundWorker_GetStoreUpdateProgress.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UnPauseSingleStore(string SQLHostName, string SQLInstanceName, string SQLDatabase, string ConnectionTimeout, string user, string pwd, string stid)
        {
            string SQLQuery_PauseStore = "UPDATE Stores SET DisallowAutoUp=0 WHERE STID=" + stid + ";";

            SqlConnection myConnection = new SqlConnection("user=" + user + ";" + "password=" + pwd + ";server=" + SQLHostName + @"\" + SQLInstanceName + ";" + "Trusted_Connection=no;"
                                                                    + "database=" + SQLDatabase + ";" + "connection timeout=" + ConnectionTimeout);

            SqlCommand myCommand = new SqlCommand(SQLQuery_PauseStore, myConnection);
            myCommand.CommandType = CommandType.Text;

            try
            {
                myConnection.Open();
                if (myConnection.State == ConnectionState.Open)
                {
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }

                if (!backgroundWorker_GetStoreUpdateProgress.IsBusy)
                {
                    backgroundWorker_GetStoreUpdateProgress.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetStoreUpdateProgress(string SQLHostName, string SQLInstanceName, string SQLDatabase, string ConnectionTimeout, string user, string pwd)
        {
            SqlConnection myConnection = new SqlConnection("user=" + user + ";" + "password=" + pwd + ";server=" + SQLHostName + @"\" + SQLInstanceName + ";" + "Trusted_Connection=no;"
                                                                    + "database=" + SQLDatabase + ";" + "connection timeout=" + ConnectionTimeout);
            /*string SQLQuery_SUP = @"SELECT dbo.vw_StoreProgress.STID,
                                      dbo.vw_StoreProgress.StoreName,
	                                  dbo.vw_StoreProgress.Version,
	                                  dbo.vw_StoreProgress.LastStarted,
	                                  dbo.vw_StoreProgress.LastCompleted,
	                                  dbo.vw_StoreProgress.BusinessDate,
	                                  dbo.vw_StoreProgress.ErrorOccurred,
	                                  dbo.vw_StoreProgress.DisallowAutoUp,
                                      (SELECT COUNT(MessageID)
                                       FROM MessageOutQueue
                                       WHERE DestSTID=dbo.vw_StoreProgress.STID
                                       AND MStatusID IN (1,3)) AS MsgCount
                                       FROM dbo.vw_StoreProgress
                                      JOIN Stores ON Stores.STID=vw_StoreProgress.STID
                                      WHERE Stores.InActive<>1 AND Stores.IsHOS<>1"; */

            string SQLQuery_SUP = "";

            Settings1 mySettings = new Settings1();
            if (mySettings.FilteredQuery == true)
            {
                SQLQuery_SUP=@"SELECT dbo.vw_StoreProgress.STID,
                                      dbo.vw_StoreProgress.StoreName,
	                                  dbo.vw_StoreProgress.Version,
	                                  dbo.vw_StoreProgress.LastStarted,
	                                  dbo.vw_StoreProgress.LastCompleted,
	                                  dbo.vw_StoreProgress.BusinessDate,
	                                  dbo.vw_StoreProgress.ErrorOccurred,
	                                  dbo.vw_StoreProgress.DisallowAutoUp,
                                      (SELECT COUNT(MessageID)
                                       FROM MessageOutQueue
                                       WHERE DestSTID=dbo.vw_StoreProgress.STID
                                       AND MStatusID IN (1,3)) AS MsgCount
                                       FROM dbo.vw_StoreProgress
                                      JOIN Stores ON Stores.STID=vw_StoreProgress.STID
                                      WHERE Stores.InActive<>1 AND Stores.IsHOS<>1
                                      AND Stores.STID IN (" + mySettings.FilteredStoresList + ")";
            }
            else
            {
                SQLQuery_SUP = @"SELECT dbo.vw_StoreProgress.STID,
                                      dbo.vw_StoreProgress.StoreName,
	                                  dbo.vw_StoreProgress.Version,
	                                  dbo.vw_StoreProgress.LastStarted,
	                                  dbo.vw_StoreProgress.LastCompleted,
	                                  dbo.vw_StoreProgress.BusinessDate,
	                                  dbo.vw_StoreProgress.ErrorOccurred,
	                                  dbo.vw_StoreProgress.DisallowAutoUp,
                                      (SELECT COUNT(MessageID)
                                       FROM MessageOutQueue
                                       WHERE DestSTID=dbo.vw_StoreProgress.STID
                                       AND MStatusID IN (1,3)) AS MsgCount
                                       FROM dbo.vw_StoreProgress
                                      JOIN Stores ON Stores.STID=vw_StoreProgress.STID
                                      WHERE Stores.InActive<>1 AND Stores.IsHOS<>1";
            }


            SqlCommand myCommand = new SqlCommand(SQLQuery_SUP, myConnection);
            SqlDataReader myReader = null;

            string[] ResponseRecords = new string[500000];

            int xRecordCount = 0;

            try
            {
                myConnection.Open();
                if (myConnection.State == ConnectionState.Open)
                {
                    //indicate we are connected
                    toolStripStatusLabel1.Text = "Connected to: " + SQLDatabase + " on " + SQLHostName + @"\" + SQLInstanceName;

                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        Object[] values = new Object[myReader.FieldCount];
                        int fieldCount = myReader.GetValues(values);

                        for (int z = 0; z < fieldCount; z++)
                        {
                            ResponseRecords[xRecordCount] += values[z]+ "|";
                        }
                        xRecordCount++;
                    }
                    myReader.Close();
                    myConnection.Close(); 
                }
                Array.Resize<String>(ref ResponseRecords, xRecordCount);

                progressBar_Progress.Step = 1;
                progressBar_Progress.Maximum = xRecordCount;
                
                if (ResponseRecords.Length > 0)
                {
                    listView_SUP.Items.Clear();
                    listView_SUP.BeginUpdate();

                    for (int x = 0; x < ResponseRecords.Length; x++)
                    {

                        listView_SUP.Items.Add(new ListViewItem(new string[] { ResponseRecords[x].Split('|')[0] + " ",
                                                                               ResponseRecords[x].Split('|')[1] + " ",
                                                                               ResponseRecords[x].Split('|')[2] + " ",
                                                                               ResponseRecords[x].Split('|')[3] + " ",
                                                                               ResponseRecords[x].Split('|')[4] + " ",
                                                                               ResponseRecords[x].Split('|')[5] + " ",
                                                                               ResponseRecords[x].Split('|')[6] + " ",
                                                                               ResponseRecords[x].Split('|')[7] + " ",
                                                                               ResponseRecords[x].Split('|')[8]}));
                        progressBar_Progress.PerformStep();
                    }

                    Array.Clear(ResponseRecords, 0, ResponseRecords.Length);

                    progressBar_Progress.Value = 0;
                    toolStripStatusLabel1.Text = "Last update: " + DateTime.Now.ToString();

                    AnalyzeStoreUpdateProgress();

                    listView_SUP.EndUpdate();
                    listView_SUP.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AnalyzeStoreUpdateProgress()
        {
             if (listView_SUP.Items.Count > 0)
            {
                int xErrorCount = 0;
                int xPauseCount = 0;
                for (int x = 0; x < listView_SUP.Items.Count; x++)
                {
                    //check last start and complete time
                    DateTime LastComplete = DateTime.Parse(listView_SUP.Items[x].SubItems[4].Text);
                    DateTime LastStart = DateTime.Parse(listView_SUP.Items[x].SubItems[3].Text);
                    bool IsPaused = false;

                    int StartCompMinDiff = (LastComplete - LastStart).Minutes;

                    //check to see if store is paused
                    if (listView_SUP.Items[x].SubItems[7].Text.ToLower().Trim() == "true")
                    {
                        IsPaused = true;
                        xPauseCount++;
                    }
                    else
                    {
                        IsPaused = false;
                    }

                    if (StartCompMinDiff < -2|
                        IsPaused|
                        listView_SUP.Items[x].SubItems[6].Text.ToLower().Trim() == "*")
                    {
                        listView_SUP.Items[x].ForeColor = Color.Red;                               
                        listView_SUP.Refresh();

                        xErrorCount++;
                    }
                    else
                    {
                        listView_SUP.Items[x].ForeColor = Color.Black;
                        listView_SUP.Refresh();
                    }
                }
                toolStripStatusLabel1.Text = (toolStripStatusLabel1.Text + " | Stores in Error: " + xErrorCount.ToString() + " | Stores paused: " + xPauseCount.ToString());
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!backgroundWorker_GetStoreUpdateProgress.IsBusy)
            {
                backgroundWorker_GetStoreUpdateProgress.RunWorkerAsync();
            }
        }

        private void backgroundWorker_GetStoreUpdateProgress_DoWork(object sender, DoWorkEventArgs e)
        {
            Settings1 mySettings = new Settings1();

            GetStoreUpdateProgress(mySettings.CurrentServer, mySettings.CurrentInstance, mySettings.CurrentDatabase, "60", mySettings.CurrentUser, mySettings.CurrentPassword);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!backgroundWorker_GetStoreUpdateProgress.IsBusy)
            {
                backgroundWorker_GetStoreUpdateProgress.RunWorkerAsync();
            }
        }

        private void checkBox_EnableAutoRefreshInterval_CheckedChanged(object sender, EventArgs e)
        {
            if (listView_SUP.Items.Count > 0)
            {
                if (checkBox_EnableAutoRefreshInterval.Checked)
                {
                    comboBox_RefreshInterval.Enabled = true;

                    if (comboBox_RefreshInterval.Text.Length < 1)
                    {
                        comboBox_RefreshInterval.SelectedIndex = 0;
                    }

                    timer_RefreshInterval.Enabled = true;
                }
                else
                {
                    comboBox_RefreshInterval.Enabled = false;
                    timer_RefreshInterval.Enabled = false;
                }
            }
        }

        private void comboBox_RefreshInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer_RefreshInterval.Interval = Int32.Parse(comboBox_RefreshInterval.Text) * 60000;
            timer_RefreshInterval.Enabled = false;
            timer_RefreshInterval.Enabled = true;
        }

        private void timer_RefreshInterval_Tick(object sender, EventArgs e)
        {
            timer_RefreshInterval.Enabled = false;

            if (!backgroundWorker_GetStoreUpdateProgress.IsBusy)
            {
                backgroundWorker_GetStoreUpdateProgress.RunWorkerAsync();
            }

            timer_RefreshInterval.Enabled = true;
        }

        private void listView_SUP_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (listView_SUP.Items.Count > 0)
            {
                ListView myListView = (ListView)sender;
                // Determine if clicked column is already the column that is being sorted.
                if (e.Column == lvwColumnSorter.SortColumn)
                {
                    // Reverse the current sort direction for this column.
                    if (lvwColumnSorter.Order == System.Windows.Forms.SortOrder.Ascending)
                    {
                        lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Descending;
                    }
                    else
                    {
                        lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
                    }
                }
                else
                {
                    // Set the column number that is to be sorted; default to ascending.
                    lvwColumnSorter.SortColumn = e.Column;
                    lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
                }

                // Perform the sort with these new sort options.
                myListView.Sort();
            }
        }

        private void checkBox_AllowSort_CheckedChanged(object sender, EventArgs e)
        {
            if (listView_SUP.Items.Count > 0)
            {
                if (checkBox_EnableColumClick.Checked == true)
                {
                    this.listView_SUP.ListViewItemSorter = lvwColumnSorter;
                }
                else
                {
                    this.listView_SUP.ListViewItemSorter = null;
                    GC.Collect();
                }
            }
        }

        private void listView_SUP_DoubleClick(object sender, EventArgs e)
        {
            if (listView_SUP.Items.Count > 0)
            {
                Settings1 mySettings = new Settings1();
                for (int x = 0; x < listView_SUP.Items.Count; x++)
                {
                    if (listView_SUP.SelectedItems[x].Text.Length > 0)
                    {
                        mySettings.vMySTID = listView_SUP.SelectedItems[x].Text;

                        mySettings.Save();
                        break;
                    }
                }
                if (mySettings.vMySTID.Length > 0)
                {
                    Form_AULog f = new Form_AULog();
                    if (DialogResult.OK == f.ShowDialog())
                    {
                        //do nothing
                    }
                }
            }
        }

        private void Form_Console_Load(object sender, EventArgs e)
        {
            Settings1 mySettings = new Settings1();
            label_CurrentHOS.Text = "Current HOS: " + mySettings.CurrentServer + @"\" + mySettings.CurrentInstance;

            if (mySettings.CurrentUser.Length > 0)
            {
                if (mySettings.CurrentUser == "ittoolsuser")
                {
                    contextMenuStrip_ListViewSUP.Enabled = false;
                }
                else
                {
                    contextMenuStrip_ListViewSUP.Enabled = true;
                }
            }
        }

        private void linkLabel_ChangeHOS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ChangeHOS f = new Form_ChangeHOS();

            Settings1 mySettings = new Settings1();
            if (DialogResult.OK == f.ShowDialog())
            {
                if (mySettings.CurrentUser.Length > 0)
                {
                    if (mySettings.CurrentUser == "ittoolsuser")
                    {
                        contextMenuStrip_ListViewSUP.Enabled = false;
                    }
                    else
                    {
                        contextMenuStrip_ListViewSUP.Enabled = true;
                    }
                }

                MessageBox.Show("Settings applied successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                label_CurrentHOS.Text = "Current HOS: " + mySettings.CurrentServer + @"\" + mySettings.CurrentInstance;

                if (!backgroundWorker_GetStoreUpdateProgress.IsBusy)
                {
                    backgroundWorker_GetStoreUpdateProgress.RunWorkerAsync();
                }
            }
        }

        private void pauseThisStoreXXXXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView_SUP.SelectedItems.Count > 0)
            {
                Settings1 mySettings = new Settings1();
                string sn = "";
                for (int x = 0; x < listView_SUP.SelectedItems.Count; x++)
                {
                    if (listView_SUP.SelectedItems[x].Text.Length > 0)
                    {
                        sn = listView_SUP.SelectedItems[x].Text;

                        PauseSingleStore(mySettings.CurrentServer, mySettings.CurrentInstance, mySettings.CurrentDatabase, "120", mySettings.CurrentUser, mySettings.CurrentPassword, sn);

                        MessageBox.Show("Store: " + sn + " has been paused at the HOS!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                    
                }
            }
        }

        private void unpauseThisStoreXXXXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView_SUP.SelectedItems.Count > 0)
            {
                Settings1 mySettings = new Settings1();
                string sn = "";
                for (int x = 0; x < listView_SUP.SelectedItems.Count; x++)
                {
                    if (listView_SUP.SelectedItems[x].Text.Length > 0)
                    {
                        sn = listView_SUP.SelectedItems[x].Text;

                        UnPauseSingleStore(mySettings.CurrentServer, mySettings.CurrentInstance, mySettings.CurrentDatabase, "120", mySettings.CurrentUser, mySettings.CurrentPassword, sn);

                        MessageBox.Show("Store: " + sn + " has been unpaused at the HOS!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void pauseEveryStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DANGER WILL ROBINSON!  This may awaken the angry DBA!\n\nThis will halt all commnunications between all stores and HOS!\n\nContinue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (listView_SUP.SelectedItems.Count > 0)
                {
                    Settings1 mySettings = new Settings1();
                    string sn = "";
                    for (int x = 0; x < listView_SUP.SelectedItems.Count; x++)
                    {
                        if (listView_SUP.SelectedItems[x].Text.Length > 0)
                        {
                            sn = listView_SUP.SelectedItems[x].Text;

                            PauseAllStores(mySettings.CurrentServer, mySettings.CurrentInstance, mySettings.CurrentDatabase, "120", mySettings.CurrentUser, mySettings.CurrentPassword, sn);

                            MessageBox.Show("All stores have been paused at the HOS!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void unpauseEveryStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("IS THE TROUBLE REALLY OVER?\n\nThis will allow all commnunications between all stores and HOS again!\n\nContinue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (listView_SUP.SelectedItems.Count > 0)
                {
                    Settings1 mySettings = new Settings1();
                    string sn = "";
                    for (int x = 0; x < listView_SUP.SelectedItems.Count; x++)
                    {
                        if (listView_SUP.SelectedItems[x].Text.Length > 0)
                        {
                            sn = listView_SUP.SelectedItems[x].Text;

                            UnPauseAllStores(mySettings.CurrentServer, mySettings.CurrentInstance, mySettings.CurrentDatabase, "120", mySettings.CurrentUser, mySettings.CurrentPassword, sn);

                            MessageBox.Show("All stores have been unpaused at the HOS!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void checkbox_FilterStores_CheckedChanged(object sender, EventArgs e)
        {
            Settings1 mySettings = new Settings1();
            if (checkbox_FilterStores.Checked)
            {
                Form_StoreFilterSelect f = new Form_StoreFilterSelect();
                if (DialogResult.OK == f.ShowDialog())
                {
                    if (!backgroundWorker_GetStoreUpdateProgress.IsBusy)
                    {
                        backgroundWorker_GetStoreUpdateProgress.RunWorkerAsync();
                    }
                }                
            }
            else
            {
                mySettings.FilteredQuery = false;
                mySettings.FilteredStoresList = "";
                mySettings.Save();
                if (!backgroundWorker_GetStoreUpdateProgress.IsBusy)
                {
                    backgroundWorker_GetStoreUpdateProgress.RunWorkerAsync();
                }
            }
        }
    }
}
