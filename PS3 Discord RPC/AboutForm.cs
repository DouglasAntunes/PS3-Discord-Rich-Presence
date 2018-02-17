using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PS3DiscordRPCApp
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            VersionLabel.Text = $"Version: {Program.Version}";
        }

        private void ShowGitHubProjectPageBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/DouglasAntunes/PS3-Discord-Rich-Presence");
        }
    }
}
