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

        protected override IWIndow CreateBaseWindow(string title)
        {
            throw new NotImplementedException();
        }

        protected override IWIndow CreateBaseWindow(string title, int width, int height)
        {
            throw new NotImplementedException();
        }

        protected override IWIndow CreateBaseWindowWithoutTitleBar()
        {
            throw new NotImplementedException();
        }

        protected override IWIndow CreateBaseWindowWithoutTitleBar(int width, int height)
        {
            throw new NotImplementedException();
        }
    }
}
