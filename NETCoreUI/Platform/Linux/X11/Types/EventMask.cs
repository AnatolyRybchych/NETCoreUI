using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Linux.X11.Types
{
    [Flags]
    public enum EventMask: long
    {
        NoEvent = 0L,
        KeyPress = (1L << 0),
        KeyRelease = (1L << 1),
        ButtonPress = (1L << 2),
        ButtonRelease = (1L << 3),
        EnterWindow = (1L << 4),
        LeaveWindow = (1L << 5),
        PointerMotion = (1L << 6),
        PointerMotionHint = (1L << 7),
        Button1Motion = (1L << 8),
        Button2Motion = (1L << 9),
        Button3Motion = (1L << 10),
        Button4Motion = (1L << 11),
        Button5Motion = (1L << 12),
        ButtonMotion = (1L << 13),
        KeymapState = (1L << 14),
        Exposure = (1L << 15),
        VisibilityChange = (1L << 16),
        StructureNotify = (1L << 17),
        ResizeRedirect = (1L << 18),
        SubstructureNotify = (1L << 19),
        SubstructureRedirect = (1L << 20),
        FocusChange = (1L << 21),
        PropertyChange = (1L << 22),
        ColormapChange = (1L << 23),
        OwnerGrabButton = (1L << 24),

        All = 0b1111111111111111111111111L,
    }
}
