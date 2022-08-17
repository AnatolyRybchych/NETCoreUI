using NETCoreUI.Core;
using NETCoreUI.Core.Primitives;
using NETCoreUI.Platform.Crossplatform;
using NETCoreUI.Platform.Linux.X11.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using X11;

namespace NETCoreUI.Platform.Linux
{
    public class LinuxEnvironment : Crossplatform.Environment
    {
        public IntPtr Display { get; private set; }
        public int DefaultScreen => X.XDefaultScreen(Display);

        private LinuxUIThread linuxUIThread;
        protected override UIThread uiThread => linuxUIThread;

        public LinuxEnvironment()
        {
            Display = X.XOpenDisplay(IntPtr.Zero);
            linuxUIThread = new LinuxUIThread(this);
            
        }

        protected override IWIndow CreateBaseWindow(string title)
        {
            return new LinuxWindow(this, X.XDefaultRootWindow(Display), 0, 0, 800, 600, 0, 0x00000000, 0x00000000
                , EventMask.Button1Motion
                | EventMask.Button2Motion
                | EventMask.Button3Motion
                | EventMask.Button4Motion
                | EventMask.Button5Motion
                | EventMask.KeyPress
                | EventMask.KeyRelease
                | EventMask.EnterWindow
                | EventMask.LeaveWindow
                | EventMask.ButtonPress
                | EventMask.ButtonRelease
                | EventMask.ButtonMotion
                | EventMask.PointerMotion
                | EventMask.VisibilityChange
                | EventMask.StructureNotify
                | EventMask.Exposure
                | EventMask.FocusChange
                , title);
        }
        

        protected override IWIndow CreateBaseWindow(string title, int width, int height)
        {
            return new LinuxWindow(this, X.XDefaultRootWindow(Display), 0, 0, width, height, 0, 0xff00ff00, 0xffffffff
                , EventMask.Button1Motion
                | EventMask.Button2Motion
                | EventMask.Button3Motion
                | EventMask.Button4Motion
                | EventMask.Button5Motion
                | EventMask.KeyPress
                | EventMask.KeyRelease
                | EventMask.EnterWindow
                | EventMask.LeaveWindow
                | EventMask.ButtonPress
                | EventMask.ButtonRelease
                | EventMask.ButtonMotion
                | EventMask.PointerMotion
                | EventMask.VisibilityChange
                | EventMask.StructureNotify
                | EventMask.Exposure
                | EventMask.FocusChange
                , title);
        }

        protected override IWIndow CreateBaseWindowWithoutTitleBar()
        {
            throw new NotImplementedException();
        }

        protected override IWIndow CreateBaseWindowWithoutTitleBar(int width, int height)
        {
            throw new NotImplementedException();
        }

        public override IGraphicsImage CreateGraphicsImage(int width, int height) => new LinuxGraphicsImage(Display ,width, height);

        public override IImage CreateImageArgsChecked(int width, int height) => new LinuxImage(Display, width, height);

        public override IImage CreateImage(Bitmap bitmap) => new LinuxImage(Display, bitmap.Width, bitmap.Height, bitmap.Bits);

        public override Size GetPrimaryDisplaySize()
        {
            IntPtr screenPtr = X.XDefaultScreenOfDisplay(Display);
            Screen screen = Marshal.PtrToStructure<Screen>(screenPtr);
            return new Size(screen.width, screen.height);
        }

        ~LinuxEnvironment()
        {
            X.XCloseDisplay(Display);
        }
    }
}
