using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X11;

namespace NETCoreUI.Platform.Linux
{
    public class LinuxUIThread : Crossplatform.UIThread
    {
        private XEvent @event;

        protected override void ReceiveMessages()
        {
        }
    }
}
