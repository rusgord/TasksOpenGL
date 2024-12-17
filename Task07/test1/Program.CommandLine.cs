// -- ScreenSaver command line arguments ------------------------------------------------------
// ScreenSaver           - Show the Settings dialog box.
// ScreenSaver /c        - Show the Settings dialog box.
// ScreenSaver /c:<HWND> - Show the Settings dialog box, modal to the foreground window <HWND>.
// ScreenSaver /p <HWND> - Preview Screen Saver as child of window <HWND>.
// ScreenSaver /s        - Run the Screen Saver.
// 
// -- In addition, Windows 95 Screen Savers must handle [obsolete]: ---------------------------
// ScreenSaver /a<HWND>  - change password, modal to window <HWND>
//
using System;
using System.Windows.Forms;

namespace test1
{
    public static partial class Program
    {
        /// <summary>
        /// Screen Saver work mode
        /// </summary>
        public enum Mode { Unknown, Settings, ModalSettings, Preview, Run }

        public static Mode mode = Mode.Unknown;
        public static IntPtr parentWnd = IntPtr.Zero;
        public static IntPtr ownerWnd = IntPtr.Zero;

        internal static void ShowModalSetting()
        {
            WindowHandleWrapper wnd = new WindowHandleWrapper(ownerWnd);
            var d = (new SettingsForm());
            if (d is Form)
                d.ShowDialog(wnd);
        }

        /// <summary>
        /// Command line parsing and work mode selection
        /// </summary>
        /// <param name="cmd">Command line from system</param>
        /// <returns>Screen Saver work mode</returns>
        internal static Mode Selector(string[] cmd)
        {
            if (cmd.Length == 0) return Mode.Settings;

            switch (cmd[0].Trim().Substring(0, 2).ToLower())
            {
                case "/s": return Mode.Run;
                case "/c": return ModeSetting(cmd);
                case "/p": return ModePreview(cmd);
                default: return Mode.Unknown;
            }
        }

        /// <summary>
        /// Parsing a command line to get the parent window handle in preview mode
        /// </summary>
        /// <param name="cmd">Command line from Windows</param>
        /// <returns>Work mode</returns>
        private static Mode ModePreview(string[] cmd)
        {
            if (cmd.Length < 2) return Mode.Unknown;
            parentWnd = new IntPtr(long.Parse(cmd[1]));
            return Mode.Preview;
        }

        /// <summary>
        /// Parsing a command line to get the owner window handle for settings in modal mode.
        /// </summary>
        /// <param name="cmd">Command line from Windows</param>
        /// <returns>Settings mode</returns>
        private static Mode ModeSetting(string[] cmd)
        {
            var c = cmd[0].Split(':');
            if (c.Length == 1) return Mode.Settings;

            ownerWnd = new IntPtr(long.Parse(c[1]));

            return Mode.ModalSettings;
        }

        /// <summary>
        /// Start show "/s" mode for each screen.
        /// </summary>
        internal static void ShowSaver()
        {
            Cursor.Hide();
            foreach (Screen screen in Screen.AllScreens)
            {
                var screensaver = new MainForm();
                screensaver.Bounds = screen.Bounds;
                screensaver.Show();
            }
            Application.Run();
        }

    }
}