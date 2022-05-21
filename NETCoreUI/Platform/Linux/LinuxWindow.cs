using NETCoreUI.Core;
using NETCoreUI.Platform.Crossplatform.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X11;

namespace NETCoreUI.Platform.Linux
{
    public class LinuxWindow : Crossplatform.Window
    {
        private static List<LinuxWindow> windows = new List<LinuxWindow>();
        public static void __NextEvent(in XEvent xEvent)
        {
            foreach (var window in windows)
            {
                if(window.XID == xEvent.xany.window)
                {
                    window.NextEvent(in xEvent);
                }
            }
        }

        public long XID { get; private set; }
        public LinuxEnvironment LinuxEnvironamnt => (LinuxEnvironment)Environment;
        public override IUIThread UIThread => throw new NotImplementedException();

        public override Point Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Size Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Rect Rect { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual void NextEvent(in XEvent xEvent)
        {

        }

        public LinuxWindow(LinuxEnvironment environment, long parent, int x, int y, int width, int height, int borderWidth, long borderColor, long backgroundColor, long inputMask) : base(environment)
        {
            XID = X.XCreateSimpleWindow(LinuxEnvironamnt.Display, parent, x, y, (uint)width, (uint)height, (uint)borderWidth, borderColor, backgroundColor);
            X.XMapWindow(LinuxEnvironamnt.Display, XID);
            X.XSelectInput(LinuxEnvironamnt.Display, XID, inputMask);
            windows.Add(this);
        }

        public override void Close()
        {
            throw new NotImplementedException();
        }

        public override void Maximize()
        {
            throw new NotImplementedException();
        }

        public override void Minimize()
        {
            throw new NotImplementedException();
        }

        public override void Show()
        {
            throw new NotImplementedException();
        }
    }
}
