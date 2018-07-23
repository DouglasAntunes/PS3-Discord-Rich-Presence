using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace PS3DiscordRPCApp
{
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void StartupConnectCB_CheckedChanged(object sender, EventArgs e)
        {
            if (StartupConnectCB.Checked)
            {
                StartupTestCB.Checked = true;
            }
        }

        private void SaveAndCloseBtn_Click(object sender, EventArgs e) => Dispose(true);

        private void DiscordAppIDDefaultCB_CheckedChanged(object sender, EventArgs e)
        {
            DiscordAppIDTextBox.Enabled = !DiscordAppIDDefaultCB.Checked;
        }
        
        private void DiscordAppIdLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DouglasAntunes/PS3-Discord-Rich-Presence/blob/master/Docs/Create a custom Discord appid.md");
        }

        private void TestConnectionButton_Click(object sender, EventArgs e)
        {
            PS3 ps3 = new PS3
            {
                ConsoleIP = PS3AddressTextBox.Text
            };
            ps3.TestConnection();
            ps3Status.Text = ps3.CurrentStatusString;
            if (ps3.CurrentStatusFlag == PS3.Status.Tested || ps3.CurrentStatusFlag == PS3.Status.Connected)
            {
                ps3Status.ForeColor = Color.DarkGreen;
            }
            else
            {
                ps3Status.ForeColor = Color.DarkRed;
            }
        }

        private void LoadConfiguration()
        {
            if (!Configuration.IsConfigurationExists())
            {
                CelsiusRB.Checked = true;
                ShareGameOnStartupCB.Checked = true;
                DiscordAppIDDefaultCB.Checked = true;
                DiscordAppIDTextBox.Enabled = false;
            }
        }

        private void ConfigurationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program._mainForm.OnConfigUpdate();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            LoadConfiguration();
        }
    }
}
