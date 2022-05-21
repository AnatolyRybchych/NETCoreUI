using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows.CSWindows
{
    public static class Win32Macro
    {
        public static ushort LOWORD(int dword) => (ushort)((uint)dword & 0x0000ffff);
        public static ushort HIWORD(int dword) => (ushort)(((uint)dword & 0xffff0000) >> 16);
        public static short GET_X_LPARAM(int dword) => (short)((uint)dword & 0x0000ffff);
        public static short GET_Y_LPARAM(int dword) => (short)(((uint)dword & 0xffff0000) >> 16);
    }
}
