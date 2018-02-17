using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS3DiscordRPCApp
{
    class Configuration
    {
        public String FileVersion { get; set; }
        //Values
        public String PS3_IP { get; set; } = "";
        public bool UseCelsiusForTemperature { get; set; } = true;
        //
        public bool TestConnectionOnStartup { get; set; } = false;
        public bool ConnectOnStartup { get; set; } = false;
        public bool EnableRichPresenceOnConnect { get; set; } = true;
        //
        public string DiscordApplicationID { get; set; } = "";
        public bool UseDefaultDiscordAppID { get; set; } = true;
        

        //Flags
        public bool FirstLaunch { get; set; } = false;
        
        public Configuration()
        {
            Load();
            if (IsConfigurationExists() && isLowerVersion())
            {
                //Do Migration or Add new default values
            }
        }

        public void Load()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                if (!IsConfigurationExists())
                {
                    Console.WriteLine("AppSettings is empty.");
                    FirstLaunch = true;
                }
                else
                {
                    FirstLaunch = false;
                    FileVersion = appSettings["Config Version"];
                    PS3_IP = appSettings["PS3 IP"];
                    UseCelsiusForTemperature = GetBoolAppSettings("Use Celsius for Temperature");

                    TestConnectionOnStartup = GetBoolAppSettings("Test Connection on Startup");
                    ConnectOnStartup = GetBoolAppSettings("Connect on Startup");
                    EnableRichPresenceOnConnect = GetBoolAppSettings("Enable Rich Presence on Connect");

                    DiscordApplicationID = appSettings["Discord Application ID"];
                    UseDefaultDiscordAppID = GetBoolAppSettings("Use Default Discord Application ID");
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
                Environment.Exit(1);
            }
        }

        public void Save()
        {
            AddUpdateAppSettings("Config Version", FileVersion);
            AddUpdateAppSettings("PS3 IP", PS3_IP);
            AddUpdateAppSettings("Use Celsius for Temperature", UseCelsiusForTemperature);
            AddUpdateAppSettings("Test Connection on Startup", TestConnectionOnStartup);
            AddUpdateAppSettings("Connect on Startup", ConnectOnStartup);
            AddUpdateAppSettings("Enable Rich Presence on Connect", EnableRichPresenceOnConnect);
            AddUpdateAppSettings("Discord Application ID", DiscordApplicationID);
            AddUpdateAppSettings("Use Default Discord Application ID", UseDefaultDiscordAppID);
            if(FirstLaunch)
            {
                FirstLaunch = false;
            }
        }

        private static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
                Environment.Exit(1);
            }
        }

        private static void AddUpdateAppSettings(string key, bool value)
        {
            if (value)
            {
                AddUpdateAppSettings(key, "true");
            }
            else
            {
                AddUpdateAppSettings(key, "false");
            }
        }

        private static bool GetBoolAppSettings(string key)
        {
            return (ConfigurationManager.AppSettings[key] == "true");
        }

        private bool isLowerVersion()
        {
            return (FileVersion == Program.Version);
        }

        private bool IsConfigurationExists()
        {
            return (ConfigurationManager.AppSettings.Count > 0);
        }

        public static bool IsEmpty(string s)
        {
            return (s == "");
        }
    }
}
