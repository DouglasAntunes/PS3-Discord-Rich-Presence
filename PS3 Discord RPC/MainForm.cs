using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace PS3DiscordRPCApp
{
    public partial class MainForm : Form
    {
        internal bool _connected = false;
        private bool _rpcSwitch = false;

        bool RPCSwitch
        {
            get => _rpcSwitch;
            set
            {
                _rpcSwitch = value;
                OnShareSwitch();
            }
        }

        internal DiscordController DiscordController;
        internal PS3 ps3;
        
        public MainForm()
        {
            InitializeComponent();
            ps3 = new PS3();
            DiscordController = new DiscordController();
            ps3.Updated += Ps3_onUpdate;
            DiscordController.Initialize();
            RPCSwitch = Configuration.GetBoolAppSettings("ShareOnStartup");
            if (Configuration.GetBoolAppSettings("TestConnectionOnStartup"))
            {
                TestPS3Connection();
                if (Configuration.GetBoolAppSettings("ConnectOnStartup"))
                {
                    if(ps3.CurrentStatusFlag == PS3.Status.Tested)
                    {
                        ConnectToPS3();
                    }
                }
            }
        }

        private void Ps3_onUpdate(object sender, EventArgs e) => UpdateStats();

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (!Configuration.IsConfigurationExists())
            {
                ShowConfigurationForm();
            }
        }

        private void ShowConfigurationForm() => Program.ConfigurationForm.ShowDialog();

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            TestPS3Connection();
            if (ps3.CurrentStatusFlag == PS3.Status.Tested)
            {
                ConnectToPS3();
            }
        }

        private void RestartPS3Btn_Click(object sender, EventArgs e)
        {
            ps3.Restart();
        }

        private void PowerOffBtn_Click(object sender, EventArgs e)
        {
            if(_connected)
            {
                ConnectBtn_Click(this, EventArgs.Empty);
            }
            ps3.PowerOff();
        }

        private void ConfigBtn_Click(object sender, EventArgs e) => ShowConfigurationForm();

        private void AboutBtn_Click(object sender, EventArgs e) => Program.AboutForm.ShowDialog();

        private void ShareBtn_Click(object sender, EventArgs e) => RPCSwitch = !RPCSwitch;

        private void OnShareSwitch()
        {
            var shareBtnText = RPCSwitch ? "Unshare Current Game" : "Share Current Game";
            ShareBtn.Text = shareBtnText;
        }
        
        public void OnConfigUpdate()
        {
            var appSettings = ConfigurationManager.AppSettings;
            ps3.ConsoleIP = appSettings["PS3_IP"];
            ps3.TemperatureScale = (Configuration.GetBoolAppSettings("TempC") ? PS3.TempScale.Celsius : PS3.TempScale.Fahrenheit);
        }

        private void TestPS3Connection()
        {
            ps3.TestConnection();
            StatusLabel.Text = ps3.CurrentStatusString;
            StatusLabel.ForeColor = (
                (ps3.CurrentStatusFlag == PS3.Status.Tested || ps3.CurrentStatusFlag == PS3.Status.Connected) ? Color.DarkGreen : Color.DarkRed
            );
        }

        private void ConnectToPS3()
        {
            if (_connected)
            {
                ps3.Disconnect();
                _connected = false;
                ConnectBtn.Text = "Connect";
                UpdateLabels(" ", " ", " ", " ");
            }
            else
            {
                ps3.Connect();
                _connected = true;
                ConnectBtn.Text = "Disconnect";
            }
        }

        private void UpdateStats()
        {
            var scaleString = (ps3.TemperatureScale == PS3.TempScale.Celsius ? "°C" : "°F");
            var cpuTemp = ps3.CPUTemp.ToString() + scaleString;
            var rsxTemp = ps3.RSXTemp.ToString() + scaleString;

            UpdateLabels(cpuTemp, rsxTemp, ps3.CurrentGameName, ps3.CurrentGameIconURL);
            UpdateDiscordRP();
        }

        private void UpdateDiscordRP()
        {
            if(RPCSwitch)
            {
                if (ps3.CurrentGameName != "none")
                {
                    DiscordController.presence = new DiscordRPC.RichPresence()
                    {
                        largeImageKey = ps3.CurrentGameCode.ToLower(),
                        largeImageText = $"{ ps3.CurrentGameName } [{ ps3.CurrentGameCode }]",
                        state = "In Game",
                        details = $"{ps3.CurrentGameName} [{ps3.CurrentGameCode}]",
                    };
                }
                else
                {
                    DiscordController.presence = new DiscordRPC.RichPresence()
                    {
                        details = "In XMB",
                        largeImageKey = "xmb",
                        largeImageText = "XrossMediaBar (Menu)",
                    };
                }
            }
            else
            {
                DiscordController.presence = new DiscordRPC.RichPresence();
            }
            
            DiscordRPC.UpdatePresence(ref DiscordController.presence);
        }

        private void UpdateLabels(string cpu, string rsx, string game, string imagePath)
        {
            CPUTempLabel.Invoke(new Action(() => CPUTempLabel.Text = $"CPU: {cpu}"));
            RSXTempLabel.Invoke(new Action(() => RSXTempLabel.Text = $"RSX: {rsx}"));
            GameLabel.Invoke(new Action(() => GameLabel.Text = $"Current Game: {game}"));
            GameIconImageBox.Invoke(new Action(() =>
            {
                if (imagePath != " ")
                {
                    GameIconImageBox.ImageLocation = imagePath;
                    GameIconImageBox.Load();
                    GameIconImageBox.Visible = true;
                }
                else
                {
                    GameIconImageBox.Visible = false;
                }
            }));
        }
    }
}
