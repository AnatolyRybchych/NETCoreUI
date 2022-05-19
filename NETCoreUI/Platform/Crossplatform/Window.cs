using NETCoreUI.Core;
using NETCoreUI.Core.WindowEvents;
using NETCoreUI.Platform.Crossplatform.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Crossplatform
{
    public abstract class Window : IWIndow
    {
        public abstract IUIThread UIThread { get; }

        public abstract string Title { get; set; }
        public abstract Point Position { get; set; }
        public abstract Size Size { get; set; }
        public abstract Rect Rect { get; set; }

        public event LeftMouseDownEventHandler? LeftMouseButtonDown;
        public event LeftMouseUpEventHandler? LeftMouseButtonUp;
        public event RightMouseDownEventHandler? RightMouseButtonDown;
        public event RightMouseUpEventHandler? RightMouseButtonUp;
        public event MouseMoveEventHandler? MouseMove;

        public abstract void Close();
        public abstract void Maximize();
        public abstract void Minimize();
        public abstract void Show();

        public virtual void OnLeftMouseButtonDown(MouseButtonEventArgs e) => LeftMouseButtonDown?.Invoke(this, e);

        public virtual void OnLeftMouseButtonUp(MouseButtonEventArgs e) => LeftMouseButtonUp?.Invoke(this, e);

        public virtual void OnRightMouseButtonDown(MouseButtonEventArgs e) => RightMouseButtonDown?.Invoke(this, e);

        public virtual void OnRigthMouseButtonUp(MouseButtonEventArgs e) => RightMouseButtonUp?.Invoke(this, e);

        public virtual void OnMouseMove(MouseMoveEventArgs e) => MouseMove?.Invoke(this, e);

        ~Window()
        {
            Close();
        }
    }
}
