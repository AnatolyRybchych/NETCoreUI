using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows.Win32.Types
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct BLENDFUNCTION
    {
        public const byte AC_SRC_OVER = 0;
        public const byte AC_SRC_ALPHA = 1;

        public byte BlendOp;
        public byte BlendFlags;
        public byte SourceConstantAlpha;
        public byte AlphaFormat;

        public BLENDFUNCTION(byte constAlpha)
        {
            BlendFlags = 0;
            BlendOp = AC_SRC_OVER;
            AlphaFormat = AC_SRC_ALPHA;
            SourceConstantAlpha = constAlpha;
        }
    }
}
