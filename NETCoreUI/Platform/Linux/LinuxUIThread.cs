using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Linux
{
    public class LinuxUIThread : Crossplatform.UIThread
    {
        private void HandleMessages()
        {
        }

        protected override void ReceiveMessages()
        {
            throw new NotImplementedException();
        }
    }
}
