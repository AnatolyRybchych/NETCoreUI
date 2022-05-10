using NETCoreUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Crossplatform
{
    public abstract class Environmant : IEnvironmant
    {
        protected abstract UIThread uiThread { get; }
        public IUIThread UIThread => uiThread;

        public abstract IWIndow CreateWindow();

        public void JoinUIThread()
        {
            uiThread.Join();
        }
    }
}
