using HtmlAgilityPack;
using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace PS3DiscordRPCApp
{
    public partial class MainForm : Form
    {
        bool connected = false;
        System.Threading.Timer updateTimer;

        private DiscordController DiscordController { get; set; } = new DiscordController();

        public MainForm()
        {
            InitializeComponent();
            DiscordController.Initialize();
            DiscordRPC.UpdatePresence(ref DiscordController.presence);
        }

        private void testConnectionButton_Click(object sender, EventArgs e)
        {
            Ping x = new Ping();
            PingReply reply = x.Send(IPAddress.Parse(ps3AddressTextBox.Text)); //enter ip of the machine
            if (reply.Status == IPStatus.Success) // here we check for the reply status if it is success it means the host is reachable
            {
                statusLabel.Text = $"Status: OK {reply.RoundtripTime.ToString()}ms";
            }
            else {
                //if host is not reachable.
                statusLabel.Text = "Status: ERROR";
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if(connected)
            {
                updateTimer.Dispose();
                connected = false;
                connectBtn.Text = "Connect";
                UpdateLabels(" ", " ", " ", " ");
            }
            else
            {
                updateTimer = new System.Threading.Timer((es) =>
                {
                    UpdateStats();
                }, null, TimeSpan.Zero, TimeSpan.FromMinutes(0.25));
                connected = true;
                connectBtn.Text = "Disconnect";
            }
            
        }

        private void RestartPS3Btn_Click(object sender, EventArgs e)
        {
            WebRequest wrGet = WebRequest.Create($"http://{ps3AddressTextBox.Text}/restart.ps3");
            var a = wrGet.GetResponse();
        }

        private void PowerOffBtn_Click(object sender, EventArgs e)
        {
            WebRequest wrGet = WebRequest.Create($"http://{ps3AddressTextBox.Text}/shutdown.ps3");
            var a = wrGet.GetResponse();
        }

        private void UpdateStats()
        {
            //Vars to update
            string cpuTemp = " ",
                   rsxTemp = " ",
                   gameCode = "",
                   gameName = " ",
                   gameIconPath = " ";
            //
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument htmlDoc = web.Load($"http://{ps3AddressTextBox.Text}/cpursx.ps3");

            //var node = htmlDoc.DocumentNode.SelectSingleNode("//body/font/b");
            var node2 = htmlDoc.DocumentNode.SelectSingleNode("//body/font/font/b/a[1]");   //1 para C e 2 para F
            var node3 = htmlDoc.DocumentNode.SelectNodes("//body/font/span/h2/a");

            //Console.WriteLine(node.InnerText);
            var b = node2.InnerText.Split(' ');
            cpuTemp = b[1];
            rsxTemp = b[4];
            //Console.WriteLine(node2.InnerText);

            if (node3 != null)
            {
                gameCode = node3[0].InnerText;
                gameName = node3[1].InnerText;
                gameIconPath = $"http://{ps3AddressTextBox.Text}{node3[2].GetAttributeValue("href", " ")}/ICON0.PNG";
                //Console.WriteLine(node3[1].InnerText);
            }
            UpdateLabels(cpuTemp, rsxTemp, gameName, gameIconPath);
            if (gameName != " ")
            {
                DiscordController.presence = new DiscordRPC.RichPresence()
                {
                    largeImageKey = gameCode.ToLower(),
                    largeImageText = $"{ gameName } [{ gameCode }]",
                    state = "In Game",
                    details = $"{gameName} [{gameCode}]",
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
            DiscordRPC.UpdatePresence(ref DiscordController.presence);
        }

        private void UpdateLabels(string cpu, string rsx, string game, string imagePath)
        {
            CPUTempLabel.Invoke(new Action(() => CPUTempLabel.Text = $"CPU: {cpu}"));
            RSXTempLabel.Invoke(new Action(() => RSXTempLabel.Text = $"RSX: {rsx}"));
            GameLabel.Invoke(new Action(() => GameLabel.Text = $"GAME: {game}"));
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
