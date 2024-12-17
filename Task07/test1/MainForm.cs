using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using static test1.OpenGL;

namespace test1
{
    public partial class MainForm : Form
    {
        #region Win32 API functions

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        #endregion

        // В основном окне в режиме предпросмотра "/p" и работы "/s" : 
        //  - убрается рамка и заголовок окна (FormBorderStyle = FormBorderStyle.None;)
        //  - при открытии окна задается максимальный размер (WindowState = FormWindowState.Maximized;)
        //  - для корректной поддержки нескольких экранов отключается автоматическое расположение окна (StartPosition = FormStartPosition.Manual;)
        //
        // и в режиме работы "/s": 
        //  - отображается поверх всех окон в системе (TopMost = true;)

        Point mouse;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                // разрешаем родительскому окну управление дочерним
                if (Program.mode == Program.Mode.Preview)
                    cp.Style |= WS_CHILD;

                return cp;
            }
        }
        public MainForm()
        {
            InitializeComponent();

            if (Program.mode == Program.Mode.Preview)
            {
                // set parent window for ScreenSvaer preview 
                if (SetParent(Handle, Program.parentWnd).Equals(null))
                    Application.Exit();
            }
            else
            {
                TopMost = true;
                // Keyboard and mouse events reactions in "/s" work mode
                rc.KeyDown += (s, e) => Application.Exit();
                rc.MouseClick += (s, e) => Application.Exit();
                rc.MouseMove += OnMouseMove;
            }

            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;
            WindowState = FormWindowState.Maximized;

            // Idle event handler
            Application.Idle += (s, e) =>
            {
                Thread.Sleep(10);
                rc.Invalidate();
            };
        }

        /// <summary>
        /// Exit when moving the mouse more than 5 units on the X or Y axis
        /// </summary>
        private void OnMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (!mouse.IsEmpty)
                if (Math.Abs(mouse.X - e.X) > 5 || Math.Abs(mouse.Y - e.Y) > 5)
                    Application.Exit();

            mouse = e.Location;
        }
    }
}
