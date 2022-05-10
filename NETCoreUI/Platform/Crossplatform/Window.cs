using NETCoreUI.Core;
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
        public abstract Point Position { get; set; }
        public abstract Size Size { get; set; }
        public abstract Rect Rect { get; set; }
    }
}
