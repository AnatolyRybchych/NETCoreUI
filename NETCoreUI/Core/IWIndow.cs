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
        public event MouseMoveEventHandler MouseMove;


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
