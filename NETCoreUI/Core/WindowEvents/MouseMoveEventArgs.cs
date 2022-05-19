using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core.WindowEvents
{
    public delegate void MouseMoveEventHandler(object sender, MouseMoveEventArgs e);
    public class MouseMoveEventArgs:EventArgs
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public MouseMoveEventArgs(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
