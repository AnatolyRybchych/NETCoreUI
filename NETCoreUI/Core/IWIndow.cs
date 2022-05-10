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
        public IUIThread UIThread { get; }

        public Point Position { get; set; }
        public Size Size { get; set; }
        public Rect Rect { get; set; }
        
        

        //protected void OnCreate();
        //protected void OnResize();
    }
}
