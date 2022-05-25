using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core.WindowEvents
{
    public delegate void RedrawHandler(object sender, IEnvironment environment, RedrawEventArgs e);

    public class RedrawEventArgs:EventArgs
    {
        public GraphicsContext Graphics { get; private set; }

        public RedrawEventArgs(GraphicsContext graphics)
        {
            Graphics = graphics;
        }
    }
}
