using NETCoreUI.Core;
using NETCoreUI.Platform.Crossplatform;
using NETCoreUI.Platform.Linux.X11.Types;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return new LinuxWindow(this, X.XDefaultRootWindow(Display), 0, 0, 800, 600, 0, 0xff00ff00, 0xffffffff, EventMask.All);
        }
        

        protected override IWIndow CreateBaseWindow(string title, int width, int height)
        {
            return new LinuxWindow(this, X.XDefaultRootWindow(Display), 0, 0, width, height, 0, 0xff00ff00, 0xffffffff, 0x0);
        }

        protected override IWIndow CreateBaseWindowWithoutTitleBar()
        {
            throw new NotImplementedException();
        }

        protected override IWIndow CreateBaseWindowWithoutTitleBar(int width, int height)
        {
            throw new NotImplementedException();
        }

        ~LinuxEnvironment()
        {
            X.XCloseDisplay(Display);
        }
    }
}
