using NETCoreUI.Core;
using NETCoreUI.Platform.Crossplatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Linux
{
    public class LinuxEnvironamnt : Crossplatform.Environmant
    {
        private LinuxUIThread linuxUIThread;
        protected override UIThread uiThread => linuxUIThread;

        public LinuxEnvironamnt()
        {
            linuxUIThread = new LinuxUIThread();
        }

        public override IWIndow CreateWindow()
        {
            throw new NotImplementedException();
        }
    }
}
