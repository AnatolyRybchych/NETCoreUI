using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows.Win32.Types
{
    public enum WM : Int32
    {
        CREATE = 0x1,
        DESTROY = 0x2,
        MOVE = 0x3,
        SIZE = 0x5,
        ACTIVATE = 0x6,
        SETFOCUS = 0x7,
        KILLFOCUS = 0x8,
        ENABLE = 0x10,
        WM_PAINT = 0xf,
        WM_CLOSE = 0x10,
        QUIT = 0x12,

        MOUSEMOVE = 0x200,

        LBUTTONDOWN = 0x201,
        LBUTTONUP = 0x202,

        RBUTTONDOWN = 0x204,
        RBUTTONUP = 0x205,
    }
}
