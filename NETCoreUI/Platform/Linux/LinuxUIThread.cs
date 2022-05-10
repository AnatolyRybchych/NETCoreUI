using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Linux
{
    public class LinuxUIThread : Crossplatform.UIThread
    {
        protected override bool HandleMessages()
        {
            throw new NotImplementedException();
        }

        protected override bool ReceiveMessages()
        {
            throw new NotImplementedException();
        }
    }
}
