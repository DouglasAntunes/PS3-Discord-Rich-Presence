using System;
using System.Windows.Forms;

namespace PS3DiscordRPCApp
{
    static class Program
    {
        public static String Version = "0.1";
        public static MainForm _mainForm;
        private static ConfigurationForm _configurationForm;
        private static AboutForm _aboutForm;

        public static ConfigurationForm ConfigurationForm
        {
            get
            {
                if(_configurationForm == null)
                {
                    return new ConfigurationForm();
                }
                else
                {
                    return _configurationForm;
                }
            }
            set => _configurationForm = value;
        }

        public static AboutForm AboutForm
        {
            get
            {
                if (_aboutForm == null)
                {
                    return new AboutForm();
                }
                else
                {
                    return _aboutForm;
                }
            }
            set => _aboutForm = value;
        }

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _mainForm = new MainForm();

            Application.Run(_mainForm);
        }
    }
}
