using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows.Win32.Types
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct MSG
    {
        IntPtr hwnd;
        WM message;
        IntPtr wParam;
        IntPtr lParam;
        UInt32 time;
        POINT pt;
        UInt32 lPrivate;

        public IntPtr Hwnd { get { return hwnd; } set { hwnd = value; } }
        public WM Message { get { return message; } set { message = value; } }
        public IntPtr WParam { get { return wParam; } set { wParam = value; } }
        public IntPtr LParam { get { return lParam; } set { lParam = value; } }
        public UInt32 Time { get { return time; } set { time = value; } }  
        public POINT Pt { get { return pt; } set { pt = value; } }
        public UInt32 LPrivate { get { return lPrivate; } set { lPrivate = value; } }
    }
}
