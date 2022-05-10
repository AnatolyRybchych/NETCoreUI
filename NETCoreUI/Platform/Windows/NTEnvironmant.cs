using NETCoreUI.Core;
using NETCoreUI.Platform.Crossplatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows
{
    public class NTEnvironmant : Crossplatform.Environmant
    {
        private NTUIThread ntUIThread;
        protected override UIThread uiThread => ntUIThread;

        public NTEnvironmant()
        {
            ntUIThread = new NTUIThread();
        }

        public override IWIndow CreateWindow()
        {
            throw new NotImplementedException();
        }
    }
}
