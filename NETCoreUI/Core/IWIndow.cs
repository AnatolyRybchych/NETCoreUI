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
        IUIThread UIThread { get; }

        public string Title { get; set; }
        public Point Position { get; set; }
        public Size Size { get; set; }
        public Rect Rect { get; set; }

        void Show();
        void Maximize();
        void Minimize();
        void Close();
    }
}
