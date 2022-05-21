using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core
{
    public interface IUIThread
    {
        IEnvironment Environment { get; }

        //executes action in UI thread after handling events
        //can be called reqursively to handle on each event cycle
        void Execute(Action action);
        public void Stop();
        bool IsCurrentThread { get; }
    }
}
