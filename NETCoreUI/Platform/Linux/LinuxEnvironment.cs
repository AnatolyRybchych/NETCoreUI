using NETCoreUI.Core;
using NETCoreUI.Platform.Crossplatform;
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
            linuxUIThread = new LinuxUIThread();
            
        }

        protected override IWIndow CreateBaseWindow(string title)
        {
            throw new NotImplementedException();
        }

        protected override IWIndow CreateBaseWindow(string title, int width, int height)
        {
            throw new NotImplementedException();
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
