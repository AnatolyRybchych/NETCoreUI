using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core.WindowEvents
{
    public delegate void HorisontalScrollHandler(object sender, IEnvironment environment, MouseScrollEventArgs e);
    public delegate void VerticalScrollHandler(object sender, IEnvironment environment, MouseScrollEventArgs e);

    public class MouseScrollEventArgs:EventArgs
    {
        public int Delta { get; private set; }

        public MouseScrollEventArgs(int delta)
        {
            Delta = delta;
        }
    }
}
