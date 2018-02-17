using System;
using System.Drawing;
using System.Windows.Forms;

namespace PS3DiscordRPCApp
{
    public partial class ConfigurationForm : Form
    {
        internal Configuration Config = Program.Config;
        internal PS3 ps3 = Program.PS3;

        public ConfigurationForm()
        {
            InitializeComponent();
            LoadConfiguration();
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
            ps3.ConsoleIP = PS3AddressTextBox.Text;
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

        private void LoadOptionsToObject()
        {
            Config.PS3_IP = PS3AddressTextBox.Text;
            Config.TestConnectionOnStartup = StartupTestCB.Checked;
            Config.ConnectOnStartup = StartupConnectCB.Checked;
            Config.UseCelsiusForTemperature = CelsiusRB.Checked;
            Config.EnableRichPresenceOnConnect = ShareGameOnStartupCB.Checked;
            Config.DiscordApplicationID = DiscordAppIDTextBox.Text;
            Config.UseDefaultDiscordAppID = DiscordAppIDDefaultCB.Checked;
        }

        private void LoadConfiguration()
        {
            if (!Config.FirstLaunch)
            {
                PS3AddressTextBox.Text = Config.PS3_IP;
                StartupTestCB.Checked = Config.TestConnectionOnStartup;
                StartupConnectCB.Checked = Config.ConnectOnStartup;

                if (Config.UseCelsiusForTemperature)
                {
                    CelsiusRB.Checked = true;
                    FahrenheitRB.Checked = false;
                }
                else
                {
                    CelsiusRB.Checked = false;
                    FahrenheitRB.Checked = true;
                }
                ShareGameOnStartupCB.Checked = Config.EnableRichPresenceOnConnect;

                DiscordAppIDTextBox.Text = Config.DiscordApplicationID;
                DiscordAppIDDefaultCB.Checked = Config.UseDefaultDiscordAppID;
            }
            else
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
    }
}
