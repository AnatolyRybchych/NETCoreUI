using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows.Win32.Types
{
    public enum WAIT : UInt32
    {
        ABANDONED = 0x00000080,
        OBJECT_0 = 0x00000000,
        TIMEOUT = 0x00000102,
        FAILED = 0xFFFFFFFF,
    }
}
