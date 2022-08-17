using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core.WindowEvents
{
    public delegate void UnFocusEventHandler(object sender, IEnvironment environment, UnFocusEventArgs e);

    public class UnFocusEventArgs : EventArgs
    {
        public UnFocusEventArgs()
        {

        }
    }
}
