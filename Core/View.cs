using NETCoreUI.Core.WindowEvents;
using NETCoreUI.Core.Primitives;

namespace NETCoreUI.Core
{
    public abstract class View{
        public event LeftMouseDownEventHandler LeftMouseButtonDown;
        public event LeftMouseUpEventHandler LeftMouseButtonUp;
        public event RightMouseDownEventHandler RightMouseButtonDown;
        public event RightMouseUpEventHandler RightMouseButtonUp;
        public event MiddleMouseDownEventHandler MiddleMouseButtonDown;
        public event MiddleMouseUpEventHandler MiddleMouseButtonUp;
        public event Mouse4DownEventHandler Mouse4ButtonDown;
        public event Mouse4UpEventHandler Mouse4ButtonUp;
        public event Mouse5DownEventHandler Mouse5ButtonDown;
        public event Mouse5UpEventHandler Mouse5ButtonUp;
        public event MouseMoveEventHandler MouseMove;
        public event HorisontalScrollHandler? HorisontalScroll;
        public event VerticalScrollHandler? VericalScroll;
        public event KeyDownHandler? KeyDown;
        public event KeyUpHandler? KeyUp;
        public event RedrawHandler? Redraw;
        public event Resizehandler? Resize;
        public event MoveHandler? Move;
        public event Resizehandler? ChildResize;
        public event MoveHandler? ChildMove;
        public event MouseEnterHandler? MouseEnter;
        public event MouseLeaveHandler? MouseLeave;
        
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