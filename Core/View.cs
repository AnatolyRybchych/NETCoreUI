using NETCoreUI.Core.WindowEvents;
using NETCoreUI.Core.Primitives;

namespace NETCoreUI.Core
{
    public abstract class View{
        public IEnvironment Environment { get; }
        public IWIndow Window { get; }
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

        public View(IEnvironment environment, IWIndow window)
        {
            Environment = environment;
            Window = window;
            childs = new List<View>();
        }

        protected virtual void OnLeftMouseButtonDown(MouseButtonEventArgs e){
            LeftMouseButtonDown?.Invoke(this, Environment, e);
            foreach (var child in Childs)
            {
                MouseButtonEventArgs childArgs = new MouseButtonEventArgs(e.X + position.X, e.Y + position.Y);
                if(childArgs.X < size.Width && childArgs.X > 0 
                && childArgs.Y < size.Height && childArgs.Y > 0){
                    child.OnLeftMouseButtonDown(childArgs);
                }
            }
        }
        protected virtual void OnLeftMouseButtonUp(MouseButtonEventArgs e){
            LeftMouseButtonUp?.Invoke(this, Environment, e);
            foreach (var child in Childs)
            {
                MouseButtonEventArgs childArgs = new MouseButtonEventArgs(e.X + position.X, e.Y + position.Y);
                if(childArgs.X < size.Width && childArgs.X > 0 
                && childArgs.Y < size.Height && childArgs.Y > 0){
                    child.OnLeftMouseButtonUp(childArgs);
                }
            }
        }
        protected virtual void OnRightMouseButtonDown(MouseButtonEventArgs e){
            RightMouseButtonDown?.Invoke(this, Environment, e);
            foreach (var child in Childs)
            {
                MouseButtonEventArgs childArgs = new MouseButtonEventArgs(e.X + position.X, e.Y + position.Y);
                if(childArgs.X < size.Width && childArgs.X > 0 
                && childArgs.Y < size.Height && childArgs.Y > 0){
                    child.OnRightMouseButtonDown(childArgs);
                }
            }
        }
        protected virtual void OnRightMouseButtonUp(MouseButtonEventArgs e){
            RightMouseButtonUp?.Invoke(this, Environment, e);
            foreach (var child in Childs)
            {
                MouseButtonEventArgs childArgs = new MouseButtonEventArgs(e.X + position.X, e.Y + position.Y);
                if(childArgs.X < size.Width && childArgs.X > 0 
                && childArgs.Y < size.Height && childArgs.Y > 0){
                    child.OnRightMouseButtonUp(childArgs);
                }
            }
        }
        protected virtual void OnMiddleMouseButtonDown(MouseButtonEventArgs e){
            MiddleMouseButtonDown?.Invoke(this, Environment, e);
            foreach (var child in Childs)
            {
                MouseButtonEventArgs childArgs = new MouseButtonEventArgs(e.X + position.X, e.Y + position.Y);
                if(childArgs.X < size.Width && childArgs.X > 0 
                && childArgs.Y < size.Height && childArgs.Y > 0){
                    child.OnMiddleMouseButtonDown(childArgs);
                }
            }
        }
        protected virtual void OnMiddleMouseButtonUp(MouseButtonEventArgs e){
            MiddleMouseButtonUp?.Invoke(this, Environment, e);
            foreach (var child in Childs)
            {
                MouseButtonEventArgs childArgs = new MouseButtonEventArgs(e.X + position.X, e.Y + position.Y);
                if(childArgs.X < size.Width && childArgs.X > 0 
                && childArgs.Y < size.Height && childArgs.Y > 0){
                    child.OnMiddleMouseButtonUp(childArgs);
                }
            }
        }
        protected virtual void OnMouse4ButtonDown(MouseButtonEventArgs e){
            Mouse4ButtonDown?.Invoke(this, Environment, e);
            foreach (var child in Childs)
            {
                MouseButtonEventArgs childArgs = new MouseButtonEventArgs(e.X + position.X, e.Y + position.Y);
                if(childArgs.X < size.Width && childArgs.X > 0 
                && childArgs.Y < size.Height && childArgs.Y > 0){
                    child.OnMouse4ButtonDown(childArgs);
                }
            }
        }
        protected virtual void OnMouse4ButtonUp(MouseButtonEventArgs e){
            Mouse4ButtonUp?.Invoke(this, Environment, e);
            foreach (var child in Childs)
            {
                MouseButtonEventArgs childArgs = new MouseButtonEventArgs(e.X + position.X, e.Y + position.Y);
                if(childArgs.X < size.Width && childArgs.X > 0 
                && childArgs.Y < size.Height && childArgs.Y > 0){
                    child.OnMouse4ButtonUp(childArgs);
                }
            }
        }
        protected virtual void OnMouse5ButtonDown(MouseButtonEventArgs e){
            Mouse5ButtonDown?.Invoke(this, Environment, e);
            foreach (var child in Childs)
            {
                MouseButtonEventArgs childArgs = new MouseButtonEventArgs(e.X + position.X, e.Y + position.Y);
                if(childArgs.X < size.Width && childArgs.X > 0 
                && childArgs.Y < size.Height && childArgs.Y > 0){
                    child.OnMouse5ButtonDown(childArgs);
                }
            }
        }
        protected virtual void OnMouse5ButtonUp(MouseButtonEventArgs e){
            Mouse5ButtonUp?.Invoke(this, Environment, e);
            foreach (var child in Childs)
            {
                MouseButtonEventArgs childArgs = new MouseButtonEventArgs(e.X + position.X, e.Y + position.Y);
                if(childArgs.X < size.Width && childArgs.X > 0 
                && childArgs.Y < size.Height && childArgs.Y > 0){
                    child.OnMouse5ButtonUp(childArgs);
                }
            }
        }
        protected virtual void OnMouseMove(MouseMoveEventArgs e){
            MouseMove?.Invoke(this, Environment, e);
            foreach (var child in Childs)
            {
                MouseMoveEventArgs childArgs = new MouseMoveEventArgs(e.X + position.X, e.Y + position.Y);
                if(childArgs.X < size.Width && childArgs.X > 0 
                && childArgs.Y < size.Height && childArgs.Y > 0){
                    child.OnMouseMove(childArgs);
                }
                
            }
        }
        protected virtual void OnHorisontalScroll(MouseScrollEventArgs e){
            HorisontalScroll?.Invoke(this, Environment, e);
            foreach (var child in Childs)
            {
                child.OnHorisontalScroll(e);
            }
        }
        protected virtual void OnVericalScroll(MouseScrollEventArgs e){
            VericalScroll?.Invoke(this, Environment, e);
            foreach (var child in Childs)
            {
                child.OnVericalScroll(e);
            }
        }
        protected virtual void OnKeyDown(KeyEventArgs e){
            KeyDown?.Invoke(this, Environment, e);
            foreach (var child in Childs)
            {
                child.OnKeyDown(e);
            }
        }
        protected virtual void OnKeyUp(KeyEventArgs e){
            KeyUp?.Invoke(this, Environment, e);
            foreach (var child in Childs)
            {
                child.OnKeyUp(e);
            }
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
        public void RedrawView(){
            OnRedraw();
            Window.ForceRedraw();
        }
        
        public virtual void AddChild(View child){
            childs.Add(child);
            child.RedrawView();
        }
        public virtual void RemoveChild(View child){
            childs.Remove(child);
            RedrawView();
        }

        private List<View> childs;
        public IEnumerable<View> Childs => childs;


        private Point position;
        public Point Position {
            get => position;
            set{
                value = position;
                OnMove(new MoveEventArgs(position));
                RedrawView();
            }
        }

        private Size size;
        public Size Size {
            get => size;
            set{
                size = value;
                OnResize(new ResizeEventArgs(size));
                OnRedraw();
            }
        }
        public Rect Rect {
            get => new Rect(position, size);
            set{
                size = value.Size;
                position = value.Position;
                OnMove(new MoveEventArgs(position));
                OnResize(new ResizeEventArgs(size));
                OnRedraw();
            }
        }

        public abstract void Show();
        public abstract void Hide();
    }
}