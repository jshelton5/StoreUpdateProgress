using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreUpdateProgress
{
    public partial class Form_ChangeHOS : Form
    {
        public Form_ChangeHOS()
        {
            InitializeComponent();
        }

        public void SaveSettings()
        {
            Settings1 mySettings = new Settings1();

            if (textBox_ServerName.Text.Length > 0 &&
                textBox_InstanceName.Text.Length > 0 &&
                textBox_DatabaseName.Text.Length > 0 &&
                textBox_UserName.Text.Length > 0 &&
                textBox_Password.Text.Length > 0)
            {
                mySettings.CurrentServer = textBox_ServerName.Text;
                mySettings.CurrentInstance = textBox_InstanceName.Text;
                mySettings.CurrentDatabase = textBox_DatabaseName.Text;
                mySettings.CurrentUser = textBox_UserName.Text;
                mySettings.CurrentPassword = textBox_Password.Text;

                mySettings.Save();

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("You are missing some information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadSettings()
        {
            Settings1 mySettings = new Settings1();

            textBox_ServerName.Text = mySettings.CurrentServer;
            textBox_InstanceName.Text = mySettings.CurrentInstance;
            textBox_DatabaseName.Text = mySettings.CurrentDatabase;
            textBox_UserName.Text = mySettings.CurrentUser;
            textBox_Password.Text = mySettings.CurrentPassword;
        }

        private void Form_ChangeHOScs_Shown(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void Form_ChangeHOS_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }
    }
}
