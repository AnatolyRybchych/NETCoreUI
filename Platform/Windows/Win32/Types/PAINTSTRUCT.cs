using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows.Win32.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAINTSTRUCT
    {
        public IntPtr hdc;
        [MarshalAs(UnmanagedType.Bool)]
        public bool fErse;
        public RECT rcPaint;
        [MarshalAs(UnmanagedType.Bool)]
        public bool fRestore;
        [MarshalAs(UnmanagedType.Bool)]
        public bool fIncUpdate;

        private long rgbReserved0;
        private long rgbReserved1;
        private long rgbReserved2;
        private long rgbReserved3;
    }
}
