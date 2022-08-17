using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core.WindowEvents
{
    public delegate void FocusEventHandler(object sender, IEnvironment environment, FocusEventArgs e);

    public class FocusEventArgs : EventArgs
    {
        public FocusEventArgs()
        {

        }
    }
}
