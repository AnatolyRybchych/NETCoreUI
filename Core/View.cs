using NETCoreUI.Core.WindowEvents;
using NETCoreUI.Core.Primitives;

namespace NETCoreUI.Core
{
    public abstract class View{
        public IEnvironment Environment { get; }
        public event LeftMouseDownEventHandler? LeftMouseButtonDown;
        public event LeftMouseUpEventHandler? LeftMouseButtonUp;
        public event RightMouseDownEventHandler? RightMouseButtonDown;
        public event RightMouseUpEventHandler? RightMouseButtonUp;
        public event MiddleMouseDownEventHandler? MiddleMouseButtonDown;
        public event MiddleMouseUpEventHandler? MiddleMouseButtonUp;
        public event Mouse4DownEventHandler? Mouse4ButtonDown;
        public event Mouse4UpEventHandler? Mouse4ButtonUp;
        public event Mouse5DownEventHandler? Mouse5ButtonDown;
        public event Mouse5UpEventHandler? Mouse5ButtonUp;
        public event MouseMoveEventHandler? MouseMove;
        public event HorisontalScrollHandler? HorisontalScroll;
        public event VerticalScrollHandler? VericalScroll;
        public event KeyDownHandler? KeyDown;
        public event KeyUpHandler? KeyUp;

        public delegate void ViewRedrawHandler(object sender, IEnvironment environment);
        public event ViewRedrawHandler? Redraw;
        public event Resizehandler? Resize;
        public event MoveHandler? Move;
        public event MouseEnterHandler? MouseEnter;
        public event MouseLeaveHandler? MouseLeave;

        public View(IEnvironment environment)
        {
            Environment = environment;
        }

        protected virtual void OnLeftMouseButtonDown(MouseButtonEventArgs e){
            LeftMouseButtonDown?.Invoke(this, Environment, e);
        }
        protected virtual void OnLeftMouseButtonUp(MouseButtonEventArgs e){
            LeftMouseButtonUp?.Invoke(this, Environment, e);
        }
        protected virtual void OnRightMouseButtonDown(MouseButtonEventArgs e){
            RightMouseButtonDown?.Invoke(this, Environment, e);
        }
        protected virtual void OnRightMouseButtonUp(MouseButtonEventArgs e){
            RightMouseButtonUp?.Invoke(this, Environment, e);
        }
        protected virtual void OnMiddleMouseButtonDown(MouseButtonEventArgs e){
            MiddleMouseButtonDown?.Invoke(this, Environment, e);
        }
        protected virtual void OnMiddleMouseButtonUp(MouseButtonEventArgs e){
            MiddleMouseButtonUp?.Invoke(this, Environment, e);
        }
        protected virtual void OnMouse4ButtonDown(MouseButtonEventArgs e){
            Mouse4ButtonDown?.Invoke(this, Environment, e);
        }
        protected virtual void OnMouse4ButtonUp(MouseButtonEventArgs e){
            Mouse4ButtonUp?.Invoke(this, Environment, e);
        }
        protected virtual void OnMouse5ButtonDown(MouseButtonEventArgs e){
            Mouse5ButtonDown?.Invoke(this, Environment, e);
        }
        protected virtual void OnMouse5ButtonUp(MouseButtonEventArgs e){
            Mouse5ButtonUp?.Invoke(this, Environment, e);
        }
        protected virtual void OnMouseMove(MouseMoveEventArgs e){
            MouseMove?.Invoke(this, Environment, e);
        }
        protected virtual void OnHorisontalScroll(MouseScrollEventArgs e){
            HorisontalScroll?.Invoke(this, Environment, e);
        }
        protected virtual void OnVericalScroll(MouseScrollEventArgs e){
            VericalScroll?.Invoke(this, Environment, e);
        }
        protected virtual void OnKeyDown(KeyEventArgs e){
            KeyDown?.Invoke(this, Environment, e);
        }
        protected virtual void OnKeyUp(KeyEventArgs e){
            KeyUp?.Invoke(this, Environment, e);
        }
        protected virtual void OnRedraw(){
            Redraw?.Invoke(this, Environment);
        }
        protected virtual void OnResize(ResizeEventArgs e){
            Resize?.Invoke(this, Environment, e);
        }
        protected virtual void OnMove(MoveEventArgs e){
            Move?.Invoke(this, Environment, e);
        }
        protected virtual void OnMouseEnter(MouseEnterEventArgs e){
            MouseEnter?.Invoke(this, Environment, e);
        }
        protected virtual void OnMouseLeave(MouseLeaveEventArgs e){
            MouseLeave?.Invoke(this, Environment, e);
        }
        
        public abstract void AddChild(View child);
        public abstract void RemoveChild(View child);

        public abstract IEnumerable<View> Childs { get; }


        public Point Position { get; set; }
        public Size Size { get; set; }
        public Rect Rect { get; set; }

        public abstract void Show();
        public abstract void Hide();
    }
}