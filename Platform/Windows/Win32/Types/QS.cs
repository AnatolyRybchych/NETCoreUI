using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows.Win32.Types
{
    public enum QS : UInt32
    {
        ALLEVENTS = 0x04BF,
        ALLINPUT = 0x04FF,
        ALLPOSTMESSAGE = 0x0100,
        HOTKEY = 0x0080,
        INPUT = 0x407,
        KEY = 0x0001,
        MOUSE = 0x0006,
        MOUSEBUTTON = 0x0004,
        MOUSEMOVE = 0x0002,
        PAINT = 0x0020,
        POSTMESSAGE = 0x0008,
        RAWINPUT = 0x0400,
        SENDMESSAGE = 0x0040,
        TIMER = 0x0010,
    }
}
