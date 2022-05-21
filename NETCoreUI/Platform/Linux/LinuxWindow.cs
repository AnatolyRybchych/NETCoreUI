using NETCoreUI.Core;
using NETCoreUI.Core.WindowEvents;
using NETCoreUI.Platform.Crossplatform.Primitives;
using NETCoreUI.Platform.Linux.X11.CSX;
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
    public class LinuxWindow : Crossplatform.Window
    {
        public delegate void NewEventHandler(object sender, LinuxEnvironment environmant, in XEvent xEvent);
        public NewEventHandler? NewEvent;

        public long XID { get; private set; }
        public LinuxEnvironment LinuxEnvironamnt => (LinuxEnvironment)Environment;

        public override IUIThread UIThread => throw new NotImplementedException();
        public override Point Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Size Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Rect Rect { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        private QueryPointer queryPointer;

        public virtual void NextEvent(in XEvent xEvent)
        {
            NewEvent?.Invoke(this, LinuxEnvironamnt, xEvent);

            switch (xEvent.type)
            {
                case EventType.MotionNotify:
                    queryPointer.Query();
                    OnMouseMove(new MouseMoveEventArgs(queryPointer.X, queryPointer.Y));
                    break;
                case EventType.ButtonPress:
                    if(xEvent.xbutton.state == 0)
                    {
                        if (xEvent.xbutton.button == 0)
                            OnRigthMouseButtonUp(new MouseButtonEventArgs(queryPointer.X, queryPointer.Y));
                        else if (xEvent.xbutton.button == 1)
                            OnLeftMouseButtonUp(new MouseButtonEventArgs(queryPointer.X, queryPointer.Y));
                    }
                    else if(xEvent.xbutton.state == 1)
                    {
                        if (xEvent.xbutton.button == 0)
                            OnRightMouseButtonDown(new MouseButtonEventArgs(queryPointer.X, queryPointer.Y));
                        else if (xEvent.xbutton.button == 1)
                            OnLeftMouseButtonDown(new MouseButtonEventArgs(queryPointer.X, queryPointer.Y));
                    }
                    break;
            }
        }

        public LinuxWindow(LinuxEnvironment environment, long parent, int x, int y, int width, int height, int borderWidth, long borderColor, long backgroundColor, EventMask inputMask) : base(environment)
        {
            XID = X.XCreateSimpleWindow(LinuxEnvironamnt.Display, parent, x, y, (uint)width, (uint)height, (uint)borderWidth, borderColor, backgroundColor);
            queryPointer = new QueryPointer(environment.Display, XID);
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


        


        private static List<LinuxWindow> windows = new List<LinuxWindow>();
        public static void __NextEvent(in XEvent xEvent)
        {
            foreach (var window in windows)
            {
                if (window.XID == xEvent.xany.window)
                {
                    window.NextEvent(in xEvent);
                }
            }
        }
    }
}
