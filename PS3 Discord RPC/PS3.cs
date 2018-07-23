using HtmlAgilityPack;
using System;
using System.Net;
using System.Net.NetworkInformation;
namespace PS3DiscordRPCApp
{
    class PS3
    {
        //Global Flags
        public enum TempScale
        {
            Celsius = 1,
            Fahrenheit = 2,
        }

        public enum Status
        {
            NotConnected = 0,
            Connected = 1,
            Tested = 2,
            NoWebMAN = 3,
            Refused = 4,
            NotReachable = 5,
            NoIp = 6,
        }

        //Global vars
        public String ConsoleIP { get; set; } = "";
        public long Ping { get; private set; } = 0;

        public String CurrentStatusString { get; private set; } = "Not Connected";
        public Status CurrentStatusFlag { get; private set; } = Status.NotConnected;

        public int CPUTemp { get; private set; } = 0;
        public int RSXTemp { get; private set; } = 0;
        public TempScale TemperatureScale { get; set; } = TempScale.Celsius;

        public String CurrentGameCode { get; private set; } = " ";
        public String CurrentGameName { get; private set; } = "none";
        public String CurrentGameIconURL { get; private set; } = " ";
        //
        public Double UpdateTimerSize { get; set; } = 0.25; //In Minutes
        System.Threading.Timer updateTimer;

        public event EventHandler Connected;
        public event EventHandler Updated;

        public PS3()
        {

        }

        public PS3(String IP) : this()
        {
            ConsoleIP = IP;
        }

        internal void Connect()
        {
            if(CurrentStatusFlag == Status.Tested)
            {
                updateTimer = new System.Threading.Timer((es) =>
                {
                    Update();
                }, null, TimeSpan.Zero, TimeSpan.FromMinutes(UpdateTimerSize));
                CurrentStatusFlag = Status.Connected;
                CurrentStatusString = "Connected";
                OnConnected(this, EventArgs.Empty);
            }
        }

        internal void Disconnect()
        {
            if(CurrentStatusFlag == Status.Connected)
            {
                updateTimer.Dispose();
                CurrentStatusFlag = Status.NotConnected;
                CurrentStatusString = "Not Connected";
            }
        }

        internal void Update()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument htmlDoc = web.Load($"http://{ConsoleIP}/cpursx.ps3");

            //var node = htmlDoc.DocumentNode.SelectSingleNode("//body/font/b");
            var tempNode = htmlDoc.DocumentNode.SelectSingleNode($"//body/font/font/b/a[{(int)TemperatureScale}]");   //1 for °C e 2 for °F
            var gameInfoNode = htmlDoc.DocumentNode.SelectNodes("//body/font/span/h2/a");

            //Console.WriteLine(node.InnerText);
            var b = tempNode.InnerText.Split(' ');
            var cpuTemp = b[1];
            var rsxTemp = b[4];
            var remScaleString = (TemperatureScale == TempScale.Celsius ? "°C" : "°F");
            //Console.WriteLine(node2.InnerText);
            CPUTemp = int.Parse(cpuTemp.Replace(remScaleString, ""));
            RSXTemp = int.Parse(rsxTemp.Replace(remScaleString, ""));

            if (gameInfoNode != null)
            {
                CurrentGameCode = gameInfoNode[0].InnerText;
                CurrentGameName = gameInfoNode[1].InnerText;
                CurrentGameIconURL = $"http://{ConsoleIP}{gameInfoNode[2].GetAttributeValue("href", " ")}/ICON0.PNG";
                //Console.WriteLine(node3[1].InnerText);
            }
            else
            {
                CurrentGameCode = " ";
                CurrentGameName = "none";
                CurrentGameIconURL = " ";
            }
            OnUpdate(this, EventArgs.Empty);
        }

        internal void TestConnection()
        {
            if(ConsoleIP != "")
            {
                Ping x = new Ping();
                PingReply reply = x.Send(IPAddress.Parse(ConsoleIP)); //enter ip of the machine
                if (reply.Status == IPStatus.Success) // here we check for the reply status if it is success it means the host is reachable
                {
                    HtmlWeb web = new HtmlWeb();
                    try
                    {
                        HtmlDocument htmlDoc = web.Load($"http://{ConsoleIP}/cpursx.ps3");
                        var node = htmlDoc.DocumentNode.SelectSingleNode("//body/font/b");
                        if (node != null && node.InnerText.Contains("webMAN"))
                        {
                            Ping = reply.RoundtripTime;
                            setCurrentStatus(Status.Tested, "OK");
                        }
                        else
                        {
                            setCurrentStatus(Status.NoWebMAN, "webMAN not detected");
                        }
                    }
                    catch (WebException) //Refused Connection
                    {
                        setCurrentStatus(Status.Refused, "Refused Connection");
                    }

                }
                else  //if host is not reachable.
                {
                    setCurrentStatus(Status.NotReachable, "Not Reachable. Wrong IP?");
                }
            }
            else  //if has no IP defined
            {
                setCurrentStatus(Status.NoIp, "No IP Defined");
            }
        }

        private void setCurrentStatus(Status statusFlag, String statusString)
        {
            CurrentStatusString = statusString;
            CurrentStatusFlag = statusFlag;
        }

        internal void Restart()
        {
            WebRequest wrGet = WebRequest.Create($"http://{ConsoleIP}/restart.ps3");
            var a = wrGet.GetResponse();
        }

        internal void PowerOff()
        {
            WebRequest wrGet = WebRequest.Create($"http://{ConsoleIP}/shutdown.ps3");
            var a = wrGet.GetResponse();
        }

        protected virtual void OnConnected(object source, EventArgs args)
        {
            Connected?.Invoke(this, args);
        }

        protected virtual void OnUpdate(object source, EventArgs args)
        {
            Updated?.Invoke(this, args);
        }
    }
}
