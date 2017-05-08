using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace StoreUpdateProgress
{
    public partial class Form_AULog : Form
    {
        public Form_AULog()
        {
            InitializeComponent();
        }

        public void PullAULogsForSTID(string STID, string SQLHostName, string SQLInstanceName, string SQLDatabase, string ConnectionTimeout, string user, string pwd)
        {
            SqlConnection myConnection = new SqlConnection("user=" + user + ";" + "password=" + pwd + ";server=" + SQLHostName + @"\" + SQLInstanceName + ";" + "Trusted_Connection=no;"
                                                                    + "database=" + SQLDatabase + ";" + "connection timeout=" + ConnectionTimeout);

            string SQLQuery_GetAULogsForSTID = @"SELECT STID, Version,LogDateTime, Message
                                                 FROM AutoUpLogs
                                                 WHERE STID=" + STID + @"
                                                 ORDER BY LogDateTime DESC";

            SqlCommand myCommand = new SqlCommand(SQLQuery_GetAULogsForSTID, myConnection);
            SqlDataReader myReader = null;

            string[] ResponseRecords = new string[500000];

            int xRecordCount = 0;

            try
            {
                myConnection.Open();
                if (myConnection.State == ConnectionState.Open)
                {
                    toolStripStatusLabel1.Text = "Connected to " + SQLDatabase + " on " + SQLHostName + @"\" + SQLInstanceName;

                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        Object[] values = new Object[myReader.FieldCount];
                        int fieldCount = myReader.GetValues(values);

                        for (int z = 0; z < fieldCount; z++)
                        {
                            ResponseRecords[xRecordCount] += values[z] + "|";
                        }
                        xRecordCount++;
                    }
                    myReader.Close();
                    myConnection.Close();
                }
                Array.Resize<String>(ref ResponseRecords, xRecordCount);

               if (xRecordCount > 0)
                {
                    listView_AULogs.Items.Clear();
                    listView_AULogs.BeginUpdate();

                    for (int x = 0; x < ResponseRecords.Length; x++)
                    {
                        listView_AULogs.Items.Add(new ListViewItem(new string[] { ResponseRecords[x].Split('|')[0],
                                                                                  ResponseRecords[x].Split('|')[1],
                                                                                  ResponseRecords[x].Split('|')[2],
                                                                                  ResponseRecords[x].Split('|')[3]}));

                        //toolStripStatusLabel1.Text = "Adding record " + x.ToString() + " of " + ResponseRecords.Length.ToString();
                    }
                    listView_AULogs.EndUpdate();
                    listView_AULogs.Refresh();

                    toolStripStatusLabel1.Text = "Ready";
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_AULog_Shown(object sender, EventArgs e)
        {
            if (!backgroundWorker_PullAULogs.IsBusy)
            {
                backgroundWorker_PullAULogs.RunWorkerAsync();
            }
        }

        private void backgroundWorker_PullAULogs_DoWork(object sender, DoWorkEventArgs e)
        {
            Settings1 mySettings = new Settings1();

            if (mySettings.vMySTID.Length > 0)
            {
                this.Text = "AutoUp Logs for STID: " + mySettings.vMySTID;
                PullAULogsForSTID(mySettings.vMySTID, mySettings.CurrentServer, mySettings.CurrentInstance, mySettings.CurrentDatabase, "120", mySettings.CurrentUser, mySettings.CurrentPassword);
            }
        }
    }
}
