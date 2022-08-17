using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows.Win32.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        private Int32 x;
        private Int32 y;

        public Int32 X
        {
            get { return x; }
            set { x = value; }
        }

        public Int32 Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
