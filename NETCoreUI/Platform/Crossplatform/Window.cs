using NETCoreUI.Core;
using NETCoreUI.Core.WindowEvents;
using NETCoreUI.Core.Primitives;
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

        public IEnvironment Environment { get; private set; }
        public abstract GraphicsContext Graphics { get; }

        public event LeftMouseDownEventHandler? LeftMouseButtonDown;
        public event LeftMouseUpEventHandler? LeftMouseButtonUp;
        public event RightMouseDownEventHandler? RightMouseButtonDown;
        public event RightMouseUpEventHandler? RightMouseButtonUp;
        public event MouseMoveEventHandler? MouseMove;
        public event MiddleMouseDownEventHandler? MiddleMouseButtonDown;
        public event MiddleMouseUpEventHandler? MiddleMouseButtonUp;
        public event Mouse4DownEventHandler? Mouse4ButtonDown;
        public event Mouse4UpEventHandler? Mouse4ButtonUp;
        public event Mouse5DownEventHandler? Mouse5ButtonDown;
        public event Mouse5UpEventHandler? Mouse5ButtonUp;
        public event HorisontalScrollHandler? HorisontalScroll;
        public event VerticalScrollHandler? VericalScroll;
        public event KeyDownHandler? KeyDown;
        public event KeyUpHandler? KeyUp;
        public event RedrawHandler? Redraw;

        public Window(IEnvironment environment)
        {
            Environment = environment;
        }

        public abstract void Close();
        public abstract void Maximize();
        public abstract void Minimize();
        public abstract void Show();

        public virtual void OnLeftMouseButtonDown(MouseButtonEventArgs e) => LeftMouseButtonDown?.Invoke(this, Environment, e);
        public virtual void OnLeftMouseButtonUp(MouseButtonEventArgs e) => LeftMouseButtonUp?.Invoke(this, Environment, e);
        public virtual void OnRightMouseButtonDown(MouseButtonEventArgs e) => RightMouseButtonDown?.Invoke(this, Environment, e);
        public virtual void OnRigthMouseButtonUp(MouseButtonEventArgs e) => RightMouseButtonUp?.Invoke(this, Environment, e);
        public virtual void OnMiddleMouseButtonDown(MouseButtonEventArgs e) => MiddleMouseButtonDown?.Invoke(this, Environment, e);
        public virtual void OnMiddleMouseButtonUp(MouseButtonEventArgs e) => MiddleMouseButtonUp?.Invoke(this, Environment, e);
        public virtual void OnMouse4ButtonDown(MouseButtonEventArgs e) => Mouse4ButtonDown?.Invoke(this, Environment, e);
        public virtual void OnMouse4ButtonUp(MouseButtonEventArgs e) => Mouse4ButtonUp?.Invoke(this, Environment, e);
        public virtual void OnMouse5ButtonDown(MouseButtonEventArgs e) => Mouse5ButtonDown?.Invoke(this, Environment, e);
        public virtual void OnMouse5ButtonUp(MouseButtonEventArgs e) => Mouse5ButtonUp?.Invoke(this, Environment, e);
        public virtual void OnMouseMove(MouseMoveEventArgs e) => MouseMove?.Invoke(this, Environment, e);
        public virtual void OnHorisontalScroll(MouseScrollEventArgs e) => HorisontalScroll?.Invoke(this, Environment, e);
        public virtual void OnVerticalScroll(MouseScrollEventArgs e) => VericalScroll?.Invoke(this, Environment, e);
        public virtual void OnKeyDown(KeyEventArgs e) => KeyDown?.Invoke(this, Environment, e);
        public virtual void OnKeyUp(KeyEventArgs e) => KeyUp?.Invoke(this, Environment, e);
        public virtual void OnRedraw(RedrawEventArgs e) => Redraw?.Invoke(this, Environment, e);

        ~Window() => Close();
    }
}
