using NETCoreUI.Platform.Windows.Win32.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows.Win32
{
    public static class WinApi
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekMessageW(out MSG lpMsg, IntPtr hwnd, UInt32 msgFilterMin = 0, uint msgFiletMax = 0, PM removeMsg = PM.REMOVE);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMessageW(out MSG lpMsg, IntPtr hwnd, UInt32 msgFilterMin = 0, uint msgFiletMax = 0);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TranslateMessage(in MSG lpMsg);

        [DllImport("user32.dll")]
        public static extern IntPtr DispatchMessageW(in MSG lpMsg);

        [DllImport("user32.dll")]
        public static extern UInt16 RegisterClassExW(in WNDCLASSEXW wc);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateWindowExW(WS_EX dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName,
            [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, WS dwStyle, Int32 X, Int32 Y, Int32 nWidth, Int32 nHeight,
            IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lpParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr GetModuleHandleW([MarshalAs(UnmanagedType.LPWStr)] string? moduleName);

        [DllImport("user32.dll")]
        public static extern UInt16 ShowWindow(IntPtr hwnd, SW show);

        [DllImport("user32.dll")]
        public static extern UInt16 UpdateWindow(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern IntPtr DefWindowProcW(IntPtr hwnd, WM msg, IntPtr wparam, IntPtr lparam);

        [DllImport("user32.dll")]
        public static extern WAIT MsgWaitForMultipleObjectsEx(UInt32 count, in IntPtr handles, UInt32 miliseconds, QS wakeMask, UInt32 Flags);


    }
}
