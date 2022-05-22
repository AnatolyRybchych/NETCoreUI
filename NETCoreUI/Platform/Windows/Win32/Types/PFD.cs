﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows.Win32.Types
{
    public enum PFD:uint
    {
        PFD_DRAW_TO_WINDOW = 0x00000004,
        PFD_DRAW_TO_BITMAP = 0x00000008,
        PFD_SUPPORT_GDI = 0x00000010,
        PFD_SUPPORT_OPENGL = 0x00000020,
        PFD_GENERIC_ACCELERATED = 0x00001000,
        PFD_GENERIC_FORMAT = 0x00000040,
        PFD_NEED_PALETTE = 0x00000080,
        PFD_NEED_SYSTEM_PALETTE = 0x00000100,
        PFD_DOUBLEBUFFER = 0x00000001,
        PFD_STEREO = 0x00000002,
        PFD_SWAP_LAYER_BUFFERS = 0x00000800,
        PFD_DEPTH_DONTCARE = 0x20000000,
        PFD_DOUBLEBUFFER_DONTCARE = 0x40000000,
        PFD_STEREO_DONTCARE = 0x80000000,
        PFD_SWAP_COPY = 0x00000400,
        PFD_SWAP_EXCHANGE = 0x00000200,

    }
}
