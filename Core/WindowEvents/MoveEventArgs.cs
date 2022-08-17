using NETCoreUI.Core.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core.WindowEvents
{
    public delegate void MoveHandler(object sender, IEnvironment environment, MoveEventArgs e);

    public class MoveEventArgs:EventArgs
    {
        public Point Position { get; private set; }

        public MoveEventArgs(Point position)
        {
            Position = position;
        }
    }
}
