using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows.Win32.Types
{
    public enum SWP:uint
    {
        SWP_NOSIZE = 1,
        SWP_NOMOVE = 2,
        SWP_NOZORDER = 4,
        SWP_NOREDRAW = 8,
        SWP_NOACTIVATE = 10,
        SWP_FRAMECHANGED = 20,
        SWP_DRAWFRAME = 20,
        SWP_SHOWWINDOW = 40,
        SWP_HIDEWINDOW = 80,
        SWP_DEFERERASE = 2000,
        SWP_ASYNCWINDOWPOS = 4000,
    }
}
