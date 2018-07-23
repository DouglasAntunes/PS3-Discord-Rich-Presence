using System;
using System.Configuration;

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

        }

        public Configuration(bool load)
        {
            Load();
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
            
            if(FirstLaunch)
            {
                FirstLaunch = false;
            }
            AddUpdateAppSettings("Config Version", FileVersion);
        }

        public void UpdateInstance()
        {
            Load();
        }

        public void UpdateObject(Configuration newObject)
        {
            
            FirstLaunch = false;
            FileVersion = newObject.FileVersion;
            PS3_IP = newObject.PS3_IP;
            UseCelsiusForTemperature = newObject.UseCelsiusForTemperature;

            TestConnectionOnStartup = newObject.TestConnectionOnStartup;
            ConnectOnStartup = newObject.ConnectOnStartup;
            EnableRichPresenceOnConnect = newObject.EnableRichPresenceOnConnect;

            DiscordApplicationID = newObject.DiscordApplicationID;
            UseDefaultDiscordAppID = newObject.UseDefaultDiscordAppID;
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

        public static bool GetBoolAppSettings(string key)
        {
            return (ConfigurationManager.AppSettings[key] == "true");
        }

        private bool isLowerVersion()
        {
            return (FileVersion == Program.Version);
        }

        public static bool IsConfigurationExists()
        {
            return (ConfigurationManager.AppSettings.Count > 0);
        }
    }
}
