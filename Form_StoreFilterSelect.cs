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

namespace StoreUpdateProgress
{
    public partial class Form_StoreFilterSelect : Form
    {
        public Form_StoreFilterSelect()
        {
            InitializeComponent();
        }

        public void RemoveItemsFromDestinationList()
        {
            if (listView_DestinationStoreList.Items.Count > 0)
            {
                if (listView_DestinationStoreList.SelectedItems.Count > 0)
                {
                    listView_DestinationStoreList.BeginUpdate();

                    while (listView_DestinationStoreList.SelectedItems.Count > 0)
                    {
                        listView_DestinationStoreList.Items.Remove(listView_DestinationStoreList.SelectedItems[0]);
                    }

                    listView_DestinationStoreList.EndUpdate();
                    listView_DestinationStoreList.Refresh();
                }
            }
        }

        public void InsertItemIntoDestList(string sqlUserName, string sqlPassword, string sqlHostname, string sqlInstance, string sqlDatabase, int sqlTimeout, string sqlTrusted)
        {
            string level = comboBox_LevelName.Text + "s";
            string SConnectionString = "user=" + sqlUserName + "; password=" + sqlPassword + "; server=" + sqlHostname + @"\" + sqlInstance + "; database=" + sqlDatabase + "; connection timeout=" + sqlTimeout.ToString() + "; Trusted_Connection=" + sqlTrusted + ";";
            string SQLQueryText = "";
            string SQLQueryInClause = "";

            SqlConnection myConnection = new SqlConnection(SConnectionString);

            int xRecordCount = 0;
            int xLvlRecordCount = 0;
            string[] ResponseRecords = new string[50000];
            string[] levelSelections = new string[checkedListBox_LevelItems.CheckedItems.Count + 1];

            foreach (object o in checkedListBox_LevelItems.CheckedItems)
            {
                levelSelections[xLvlRecordCount] += o.ToString();

                xLvlRecordCount++;
            }
            Array.Resize<String>(ref levelSelections, xLvlRecordCount);
            StringBuilder sb = new StringBuilder();
            for (int a = 0; a < levelSelections.Length; a++)
            {
                sb.Append("'" + levelSelections[a].Trim().Split(':')[0].Trim() + "',");
            }
            SQLQueryInClause = sb.ToString().Remove(sb.ToString().LastIndexOf(@","));

            switch (level.ToLower())
            {
                case "corporations":
                    {
                        SQLQueryText = @"SELECT Stores.STID
                                             FROM Stores
                                             JOIN Districts ON Stores.DistrictID = Districts.DistrictID
                                             JOIN Regions ON Regions.RegionID = Districts.RegionID
                                             JOIN Corporations ON Corporations.CorpID=Regions.CorpID
                                             WHERE Corporations.CorpID in (" + SQLQueryInClause + @") AND Stores.Inactive!=1
                                             ORDER BY Stores.STID ASC";

                    }
                    break;
                case "regions":
                    {
                        SQLQueryText = @"SELECT Stores.STID
                                             FROM Stores
                                             JOIN Districts ON Stores.DistrictID = Districts.DistrictID
                                             JOIN Regions ON Regions.RegionID = Districts.RegionID
                                             JOIN Corporations ON Corporations.CorpID=Regions.CorpID
                                             WHERE Regions.RegionID in (" + SQLQueryInClause + @") AND Stores.Inactive!=1
                                             ORDER BY Stores.STID ASC";
                    }
                    break;
                case "districts":
                    {
                        SQLQueryText = @"SELECT Stores.STID
                                             FROM Stores
                                             JOIN Districts ON Stores.DistrictID = Districts.DistrictID
                                             JOIN Regions ON Regions.RegionID = Districts.RegionID
                                             JOIN Corporations ON Corporations.CorpID=Regions.CorpID
                                             WHERE Districts.DistrictID in (" + SQLQueryInClause + @") AND Stores.Inactive!=1
                                             ORDER BY Stores.STID ASC";
                    }
                    break;
                case "stores":
                    {
                        SQLQueryText = @"SELECT Stores.STID
                                             FROM Stores
                                             JOIN Districts ON Stores.DistrictID = Districts.DistrictID
                                             JOIN Regions ON Regions.RegionID = Districts.RegionID
                                             JOIN Corporations ON Corporations.CorpID=Regions.CorpID
                                             WHERE Stores.STID in (" + SQLQueryInClause + @") AND Stores.Inactive!=1
                                             ORDER BY Stores.STID ASC";
                    }
                    break;
                case "states":
                    {


                        SQLQueryText = @"SELECT Stores.STID
                                             FROM Stores
                                             JOIN Local ON Local.ZipID=Stores.ZipID
                                             WHERE Local.State in (" + SQLQueryInClause + @") AND Stores.Inactive!=1 AND Stores.STID!=9999
                                             ORDER BY Stores.STID ASC";
                    }
                    break;
                default:
                    break;
            }

            SqlCommand myCommand = new SqlCommand(SQLQueryText, myConnection);
            SqlDataReader myReader = null;

            myConnection.Open();
            if (myConnection.State == ConnectionState.Open)
            {
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

            if (ResponseRecords.Length > 0)
            {
                listView_DestinationStoreList.BeginUpdate();

                for (int y = 0; y < ResponseRecords.Length; y++)
                {
                    listView_DestinationStoreList.Items.Add(new ListViewItem(new string[] { ResponseRecords[y].Split('|')[0].Trim() }));
                }

                listView_DestinationStoreList.EndUpdate();
                listView_DestinationStoreList.Refresh();
            }
        }

        public void CleanupListsAfterInsert()
        {
            checkedListBox_LevelItems.BeginUpdate();
            for (int x = 0; x < listView_DestinationStoreList.Items.Count; x++)
            {
                for (int y = 0; y < checkedListBox_LevelItems.Items.Count; y++)
                {
                    foreach (object o in checkedListBox_LevelItems.Items)
                    {
                        if (listView_DestinationStoreList.Items[x].Text.Trim() == o.ToString().Split(':')[0].Trim())
                        {
                            checkedListBox_LevelItems.Items.RemoveAt(y);
                        }
                    }
                }
            }
            checkedListBox_LevelItems.EndUpdate();
            checkedListBox_LevelItems.Refresh();
        }

        public void GetSourceStoresList(string sqlUserName, string sqlPassword, string sqlHostname, string sqlInstance, string sqlDatabase, int sqlTimeout, string sqlTrusted)
        {

            string level = comboBox_LevelName.Text + "s";
            string SConnectionString = "user=" + sqlUserName + "; password=" + sqlPassword + "; server=" + sqlHostname + @"\" + sqlInstance + "; database=" + sqlDatabase + "; connection timeout=" + sqlTimeout.ToString() + "; Trusted_Connection=" + sqlTrusted + ";";
            string SQLQueryText = "";

            SqlConnection myConnection = new SqlConnection(SConnectionString);

            int xRecordCount = 0;
            string[] ResponseRecords = new string[50000];
            string[] levelSelections = new string[checkedListBox_LevelItems.CheckedItems.Count + 1];

            switch (level.ToLower())
            {
                case "corporations":
                    {
                        SQLQueryText = @"SELECT DISTINCT Corporations.CorpID, 
                                                         Corporations.CorporationName
                                                FROM Corporations                                             
                                                WHERE CorpID!=9999
                                                AND Corporations.InActive!=1";

                        SqlCommand myCommand = new SqlCommand(SQLQueryText, myConnection);
                        SqlDataReader myReader = null;

                        myConnection.Open();
                        if (myConnection.State == ConnectionState.Open)
                        {


                            myReader = myCommand.ExecuteReader();
                            while (myReader.Read())
                            {
                                Object[] values = new Object[myReader.FieldCount];
                                int fieldCount = myReader.GetValues(values);

                                for (int x = 0; x < fieldCount; x++)
                                {
                                    ResponseRecords[xRecordCount] += values[x] + "|";
                                }
                                xRecordCount++;
                            }
                            myReader.Close();
                            myConnection.Close();

                            Array.Resize<String>(ref ResponseRecords, xRecordCount);

                            if (ResponseRecords.Length > 0)
                            {
                                checkedListBox_LevelItems.Items.Clear();
                                checkedListBox_LevelItems.BeginUpdate();

                                for (int x = 0; x < ResponseRecords.Length; x++)
                                {
                                    checkedListBox_LevelItems.Items.Add(ResponseRecords[x].Split('|')[0].Trim() + " : " + ResponseRecords[x].Split('|')[1].Trim());
                                }

                                checkedListBox_LevelItems.EndUpdate();
                                checkedListBox_LevelItems.Refresh();
                            }
                        }
                    }
                    break;
                case "regions":
                    {
                        SQLQueryText = @"SELECT DISTINCT Regions.RegionID,
                                               	             Regions.RegionName
                                            FROM Regions
                                            WHERE RegionID NOT IN (8998, 8999, 9999)
                                            AND Regions.InActive!=1";

                        SqlCommand myCommand = new SqlCommand(SQLQueryText, myConnection);
                        SqlDataReader myReader = null;

                        myConnection.Open();
                        if (myConnection.State == ConnectionState.Open)
                        {


                            myReader = myCommand.ExecuteReader();
                            while (myReader.Read())
                            {
                                Object[] values = new Object[myReader.FieldCount];
                                int fieldCount = myReader.GetValues(values);

                                for (int x = 0; x < fieldCount; x++)
                                {
                                    ResponseRecords[xRecordCount] += values[x] + "|";
                                }
                                xRecordCount++;
                            }
                            myReader.Close();
                            myConnection.Close();


                            Array.Resize<String>(ref ResponseRecords, xRecordCount);


                            if (ResponseRecords.Length > 0)
                            {
                                checkedListBox_LevelItems.Items.Clear();
                                checkedListBox_LevelItems.BeginUpdate();

                                for (int x = 0; x < ResponseRecords.Length; x++)
                                {
                                    checkedListBox_LevelItems.Items.Add(ResponseRecords[x].Split('|')[0].Trim() + " : " + ResponseRecords[x].Split('|')[1].Trim());
                                }

                                checkedListBox_LevelItems.EndUpdate();
                                checkedListBox_LevelItems.Refresh();
                            }
                        }
                    }
                    break;
                case "districts":
                    {
                        SQLQueryText = @"SELECT DISTINCT Districts.DistrictID,
	                                                     Districts.DistrictName
                                            FROM Districts
                                            WHERE DistrictID NOT IN (9998, 9999)
                                            AND Districts.InActive!=1";

                        SqlCommand myCommand = new SqlCommand(SQLQueryText, myConnection);
                        SqlDataReader myReader = null;

                        myConnection.Open();
                        if (myConnection.State == ConnectionState.Open)
                        {


                            myReader = myCommand.ExecuteReader();
                            while (myReader.Read())
                            {
                                Object[] values = new Object[myReader.FieldCount];
                                int fieldCount = myReader.GetValues(values);

                                for (int x = 0; x < fieldCount; x++)
                                {
                                    ResponseRecords[xRecordCount] += values[x] + "|";
                                }
                                xRecordCount++;
                            }
                            myReader.Close();
                            myConnection.Close();


                            Array.Resize<String>(ref ResponseRecords, xRecordCount);


                            if (ResponseRecords.Length > 0)
                            {
                                checkedListBox_LevelItems.Items.Clear();
                                checkedListBox_LevelItems.BeginUpdate();

                                for (int x = 0; x < ResponseRecords.Length; x++)
                                {
                                    checkedListBox_LevelItems.Items.Add(ResponseRecords[x].Split('|')[0].Trim() + " : " + ResponseRecords[x].Split('|')[1].Trim());
                                }

                                checkedListBox_LevelItems.EndUpdate();
                                checkedListBox_LevelItems.Refresh();
                            }
                        }
                    }
                    break;
                case "stores":
                    {
                        SQLQueryText = @"SELECT Stores.STID,
                                                Stores.StoreName
                                             FROM Stores
                                             WHERE Stores.STID NOT IN (9999)
                                             AND Stores.InActive!=1
                                             ORDER BY Stores.STID ASC";

                        SqlCommand myCommand = new SqlCommand(SQLQueryText, myConnection);
                        SqlDataReader myReader = null;

                        myConnection.Open();
                        if (myConnection.State == ConnectionState.Open)
                        {


                            myReader = myCommand.ExecuteReader();
                            while (myReader.Read())
                            {
                                Object[] values = new Object[myReader.FieldCount];
                                int fieldCount = myReader.GetValues(values);

                                for (int x = 0; x < fieldCount; x++)
                                {
                                    ResponseRecords[xRecordCount] += values[x] + "|";
                                }
                                xRecordCount++;
                            }
                            myReader.Close();
                            myConnection.Close();


                            Array.Resize<String>(ref ResponseRecords, xRecordCount);


                            if (ResponseRecords.Length > 0)
                            {
                                checkedListBox_LevelItems.Items.Clear();
                                checkedListBox_LevelItems.BeginUpdate();

                                for (int x = 0; x < ResponseRecords.Length; x++)
                                {
                                    checkedListBox_LevelItems.Items.Add(ResponseRecords[x].Split('|')[0].Trim() + " : " + ResponseRecords[x].Split('|')[1].Trim());
                                }

                                checkedListBox_LevelItems.EndUpdate();
                                checkedListBox_LevelItems.Refresh();
                            }
                        }
                    }
                    break;
                case "states":
                    {
                        SQLQueryText = @"SELECT Local.State, COUNT(*) as Cnt
                                                 FROM Local
                                                 JOIN Stores ON Stores.ZipID=Local.ZipID
                                                 WHERE Stores.ZipID=Local.ZipID
                                                 AND Stores.InActive!=1
                                                 AND Stores.STID NOT IN (9999)
                                                 GROUP BY Local.State";

                        SqlCommand myCommand = new SqlCommand(SQLQueryText, myConnection);
                        SqlDataReader myReader = null;

                        myConnection.Open();
                        if (myConnection.State == ConnectionState.Open)
                        {


                            myReader = myCommand.ExecuteReader();
                            while (myReader.Read())
                            {
                                Object[] values = new Object[myReader.FieldCount];
                                int fieldCount = myReader.GetValues(values);

                                for (int x = 0; x < fieldCount; x++)
                                {
                                    ResponseRecords[xRecordCount] += values[x] + "|";
                                }
                                xRecordCount++;
                            }
                            myReader.Close();
                            myConnection.Close();


                            Array.Resize<String>(ref ResponseRecords, xRecordCount);


                            if (ResponseRecords.Length > 0)
                            {
                                checkedListBox_LevelItems.Items.Clear();
                                checkedListBox_LevelItems.BeginUpdate();

                                for (int x = 0; x < ResponseRecords.Length; x++)
                                {
                                    checkedListBox_LevelItems.Items.Add(ResponseRecords[x].Split('|')[0].Trim() + " : " + ResponseRecords[x].Split('|')[1].Trim());
                                }

                                checkedListBox_LevelItems.EndUpdate();
                                checkedListBox_LevelItems.Refresh();
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void comboBox_LevelName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!backgroundWorker_RefreshLevelList.IsBusy)
            {
                backgroundWorker_RefreshLevelList.RunWorkerAsync();
            }
        }

        private void backgroundWorker_RefreshLevelList_DoWork(object sender, DoWorkEventArgs e)
        {
            Settings1 mySettings = new Settings1();
            GetSourceStoresList(mySettings.CurrentUser, mySettings.CurrentPassword, mySettings.CurrentServer, mySettings.CurrentInstance, mySettings.CurrentDatabase, 120, "No");
        }

        private void linkLabel_SelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            checkedListBox_LevelItems.BeginUpdate();
            for (int x = 0; x < checkedListBox_LevelItems.Items.Count; x++)
            {
                checkedListBox_LevelItems.SetItemChecked(x, true);
            }
            checkedListBox_LevelItems.EndUpdate();
            checkedListBox_LevelItems.Refresh();
        }

        private void linkLabel_Deselect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            checkedListBox_LevelItems.BeginUpdate();
            for (int x = 0; x < checkedListBox_LevelItems.Items.Count; x++)
            {
                checkedListBox_LevelItems.SetItemChecked(x, false);
            }
            checkedListBox_LevelItems.EndUpdate();
            checkedListBox_LevelItems.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings1 mySettings = new Settings1();
            InsertItemIntoDestList(mySettings.CurrentUser, mySettings.CurrentPassword, mySettings.CurrentServer, mySettings.CurrentInstance, mySettings.CurrentDatabase, 120, "No");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView_DestinationStoreList.Items.Count > 0)
            {
                Settings1 mySettings = new Settings1();
                StringBuilder sb = new StringBuilder();

                int sbWorkCount = 0;

                for (int x = 0; x < listView_DestinationStoreList.Items.Count; x++)
                {
                    sb.Append(listView_DestinationStoreList.Items[x].Text.Trim() + ",");
                    sbWorkCount++;
                }

                mySettings.FilteredStoresList = sb.ToString().Remove(sb.ToString().LastIndexOf(","));
                mySettings.FilteredQuery = true;

                mySettings.Save();

                this.DialogResult = DialogResult.OK;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView_DestinationStoreList.SelectedItems.Count > 0)
            {
                RemoveItemsFromDestinationList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings1 mySettings = new Settings1();
            mySettings.FilteredQuery = false;
            mySettings.Save();

            this.DialogResult = DialogResult.Cancel;
        }
    }
}
