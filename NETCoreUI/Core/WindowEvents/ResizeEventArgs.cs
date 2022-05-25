using NETCoreUI.Core.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core.WindowEvents
{
    public delegate void Resizehandler(object sender, IEnvironment environment, ResizeEventArgs e);

    public class ResizeEventArgs:EventArgs
    {
        public Size Size { get; private set; }
        public ResizeEventArgs(Size size)
        {
            Size = size;
        }
    }
}
