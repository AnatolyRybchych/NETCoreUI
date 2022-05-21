using NETCoreUI.Core.WindowEvents;
using NETCoreUI.Platform.Crossplatform.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core
{
    public interface IWIndow
    { 
        public IEnvironment Environment { get; }

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

        IUIThread UIThread { get; }

        public string Title { get; set; }
        public Point Position { get; set; }
        public Size Size { get; set; }
        public Rect Rect { get; set; }

        void OnLeftMouseButtonDown(MouseButtonEventArgs e);
        void OnLeftMouseButtonUp(MouseButtonEventArgs e);
        void OnRightMouseButtonDown(MouseButtonEventArgs e);
        void OnRigthMouseButtonUp(MouseButtonEventArgs e);
        void OnMouseMove(MouseMoveEventArgs e);

        void Show();
        void Maximize();
        void Minimize();
        void Close();
    }
}
