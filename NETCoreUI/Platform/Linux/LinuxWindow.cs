﻿using NETCoreUI.Core;
using NETCoreUI.Core.WindowEvents;
using NETCoreUI.Core.Primitives;
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
        public static readonly LinuxKeymap Keymap = new LinuxKeymap();
        public delegate void NewEventHandler(object sender, LinuxEnvironment environmant, in XEvent xEvent);
        public NewEventHandler? NewEvent;

        public long XID { get; private set; }
        public LinuxEnvironment LinuxEnvironamnt => (LinuxEnvironment)Environment;

        public override IUIThread UIThread => throw new NotImplementedException();
        public override Point Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Size Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Rect Rect { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public LinuxGraphicsContext LinuxGraphics { get; private set; }
        public override GraphicsContext Graphics => LinuxGraphics;

        private QueryPointer queryPointer;
        private WindowGeometry windowGeometry;

        private int prevX = 0;
        private int prevY = 0;
        private int prevWidth = 0;
        private int prevHeigth = 0;

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
                    //mb1, mb2, mb3
                    if (xEvent.xbutton.button == 3)
                        OnRightMouseButtonDown(new MouseButtonEventArgs(queryPointer.X, queryPointer.Y));
                    else if (xEvent.xbutton.button == 1)
                        OnLeftMouseButtonDown(new MouseButtonEventArgs(queryPointer.X, queryPointer.Y));
                    else if (xEvent.xbutton.button == 2)
                        OnMiddleMouseButtonDown(new MouseButtonEventArgs(queryPointer.X, queryPointer.Y));
                    //scrolls
                    else if (xEvent.xbutton.button == 4)
                        OnVerticalScroll(new MouseScrollEventArgs(1));
                    else if (xEvent.xbutton.button == 5)
                        OnVerticalScroll(new MouseScrollEventArgs(-1));
                    else if (xEvent.xbutton.button == 6)
                        OnHorisontalScroll(new MouseScrollEventArgs(1));
                    else if (xEvent.xbutton.button == 7)
                        OnHorisontalScroll(new MouseScrollEventArgs(-1));
                    //mb4, mb5
                    else if (xEvent.xbutton.button == 8)
                        OnMouse4ButtonDown(new MouseButtonEventArgs(queryPointer.X, queryPointer.Y));
                    else if (xEvent.xbutton.button == 9)
                        OnMouse5ButtonDown(new MouseButtonEventArgs(queryPointer.X, queryPointer.Y));
                    break;
                case EventType.ButtonRelease:
                    //mb1, mb2, mb3
                    if (xEvent.xbutton.button == 3)
                        OnRigthMouseButtonUp(new MouseButtonEventArgs(queryPointer.X, queryPointer.Y));
                    else if (xEvent.xbutton.button == 1)
                        OnLeftMouseButtonUp(new MouseButtonEventArgs(queryPointer.X, queryPointer.Y));
                    else if (xEvent.xbutton.button == 2)
                        OnMiddleMouseButtonUp(new MouseButtonEventArgs(queryPointer.X, queryPointer.Y));
                    //mb4, mb5
                    else if (xEvent.xbutton.button == 8)
                        OnMouse4ButtonUp(new MouseButtonEventArgs(queryPointer.X, queryPointer.Y));
                    else if (xEvent.xbutton.button == 9)
                        OnMouse5ButtonUp(new MouseButtonEventArgs(queryPointer.X, queryPointer.Y));
                    break;
                case EventType.KeyPress:
                    OnKeyDown(new KeyEventArgs(Keymap.Convert(xEvent.xkey.keycode)));
                    break;
                case EventType.KeyRelease:
                    OnKeyUp(new KeyEventArgs(Keymap.Convert(xEvent.xkey.keycode)));
                    break;
                case EventType.Expose:
                    
                    OnRedraw(new RedrawEventArgs(Graphics));
                    break;
                case EventType.ConfigureNotify:
                    if (prevX != xEvent.xconfigure.x || prevY != xEvent.xconfigure.y)
                    {
                        OnMove(new MoveEventArgs(new Point(xEvent.xconfigure.x, xEvent.xconfigure.y)));
                        prevX = xEvent.xconfigure.x;
                        prevY = xEvent.xconfigure.y;
                    }
                    if(prevWidth != xEvent.xconfigure.width || prevHeigth != xEvent.xconfigure.height)
                    {
                        OnResize(new ResizeEventArgs(new Size(xEvent.xconfigure.width, xEvent.xconfigure.height)));
                        prevWidth = xEvent.xconfigure.width;
                        prevHeigth = xEvent.xconfigure.height;
                    }
                    break;
                case EventType.EnterNotify:
                    OnMouseEnter(new MouseEnterEventArgs());
                    break;
                case EventType.LeaveNotify:
                    OnMouseLeave(new MouseLeaveEventArgs());
                    break;
            }
        }

        public LinuxWindow(LinuxEnvironment environment, long parent, int x, int y, int width, int height, int borderWidth, long borderColor, long backgroundColor, EventMask inputMask, string title) : base(environment)
        {
            XID = X.XCreateSimpleWindow(LinuxEnvironamnt.Display, parent, x, y, (uint)width, (uint)height, (uint)borderWidth, borderColor, backgroundColor);
            X.XStoreName(LinuxEnvironamnt.Display, XID, title);
            LinuxGraphics = new LinuxGraphicsContext(LinuxEnvironamnt.Display, XID);
            queryPointer = new QueryPointer(environment.Display, XID);
            windowGeometry = new WindowGeometry(environment.Display, XID);
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
