using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace test1
{
    internal class WindowHandleWrapper : IWin32Window
    {
        public HandleRef hRef;

        public IntPtr Handle { get => hRef.Handle; }

        public WindowHandleWrapper(IntPtr handle)
        {
            hRef = new HandleRef(this, handle);
        }
    }
}
