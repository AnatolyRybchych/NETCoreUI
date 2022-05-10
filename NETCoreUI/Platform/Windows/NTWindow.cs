using NETCoreUI.Core;
using NETCoreUI.Platform.Crossplatform.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows
{
    public class NTWindow : Crossplatform.Window
    {
        public override IUIThread UIThread => throw new NotImplementedException();

        public override Point Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Size Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Rect Rect { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
