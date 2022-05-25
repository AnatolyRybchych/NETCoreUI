using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows.CSWindows
{
    public static class Win32Macro
    {
        public static ushort LOWORD(uint dword) => unchecked((ushort)(dword & 0x0000ffff));
        public static ushort HIWORD(uint dword) => unchecked((ushort)((dword & 0xffff0000) >> 16));
        public static short GET_X_LPARAM(uint dword) => unchecked((short)(dword & 0x0000ffff));
        public static short GET_Y_LPARAM(uint dword) => unchecked((short)((dword & 0xffff0000) >> 16));
        public static short GET_WHEEL_DELTA_WPARAM(uint dword) => unchecked((short)((dword & 0xffff0000) >> 16));
    }
}
