using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace NETCoreUI.Platform.Windows.Win32.Types
{

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WNDCLASSEXW
    {
        UInt32 cbSize;
        public UInt32 CbSize { get { return cbSize; } set { cbSize = value; } }

        UInt32 style;
        public UInt32 Style { get { return style; } set { style = value; } }

        IntPtr lpfnWndProc;
        public IntPtr LpfnWndProc { get { return lpfnWndProc; } set { lpfnWndProc = value; } }

        Int32 cbClsExtra;
        public Int32 CbClsExtra { get { return cbClsExtra; } set { cbClsExtra = value; } }

        Int32 cbWndExtra;
        public Int32 CbWndExtra { get { return cbWndExtra; } set { cbWndExtra = value; } }

        IntPtr hInstance;
        public IntPtr HInstance { get{ return hInstance; } set { hInstance = value; } }

        IntPtr hIcon;
        public IntPtr HIcond { get { return hIcon; } set { hIcon = value; } }

        IntPtr hCursor;
        public IntPtr HCursor { get { return hCursor; } set { hCursor = value; } }

        IntPtr hbrBackground;
        public IntPtr HBrBackground { get { return hbrBackground; } set { hbrBackground = value; } }

        [MarshalAs(UnmanagedType.LPWStr)]
        string? lpszMenuName;
        public string? LpszMenuName { get { return lpszMenuName; } set { lpszMenuName = value; } }

        [MarshalAs(UnmanagedType.LPWStr)]
        string lpszClassName;
        public string LpszClassName { get { return lpszClassName; } set { lpszClassName = value; } }

        IntPtr hIconSm;
        public IntPtr HIconSm { get { return hIconSm; } set { hIconSm = value; } }
    }
}
