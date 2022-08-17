using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows.Win32.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct TRACKMOUSEEVENT
    {
        public uint cbSize;
        public uint dwFlags;
        public IntPtr hwndTrack;
        public uint dwHowerTime;

        public TRACKMOUSEEVENT(IntPtr hwnd, int howerTime)
        {
            cbSize = unchecked((uint)Marshal.SizeOf<TRACKMOUSEEVENT>());
            hwndTrack = hwnd;
            dwHowerTime = unchecked((uint)howerTime);
            dwFlags = 3;
        }
    }
}
