using NETCoreUI.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core.WindowEvents
{
    public delegate void KeyDownHandler(object sender, IEnvironment environment, KeyEventArgs e);
    public delegate void KeyUpHandler(object sender, IEnvironment environment, KeyEventArgs e);

    public class KeyEventArgs:EventArgs
    {
        public Key Key { get; private set; }

        public KeyEventArgs(Key key)
        {
            Key = key;
        }
    }
}
