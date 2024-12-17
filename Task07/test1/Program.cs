using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public static partial class Program
    {
        static Program() => DesignMode = true;
        public static bool DesignMode { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] cmd)
        {
            DesignMode = false;

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region Application.Run(new MainForm());

            mode = Selector(cmd);

            switch (mode)
            {
                case Mode.Run:
                    ShowSaver(); break;
                case Mode.Preview:
                    Application.Run(new MainForm());
                    break;
                case Mode.Settings:
                    Application.Run(new SettingsForm()); break;
                case Mode.ModalSettings:
                    ShowModalSetting(); break;
                default:
                    MessageBox.Show("Unknown command: " + cmd[0] + "." + Environment.NewLine + "Please use : /c, /s, /p", "Info"); break;
            }

            #endregion
        }
    }
}
