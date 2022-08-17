using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core.WindowEvents
{
    public delegate void MouseLeaveHandler(object sender, IEnvironment environment, MouseLeaveEventArgs e);

    public class MouseLeaveEventArgs : EventArgs
    {
        public MouseLeaveEventArgs()
        {

        }
    }
}
