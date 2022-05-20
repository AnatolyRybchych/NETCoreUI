using NETCoreUI.Platform.Windows.Win32;
using NETCoreUI.Platform.Windows.Win32.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows
{
    public class NTUIThread : Crossplatform.UIThread
    {
        private MSG message;

        public NTEnvironment NTEnvironment => (NTEnvironment)Environment;

        public NTUIThread(NTEnvironment environment):base(environment)
        {
            message = new MSG();
        }

        protected override void ReceiveMessages()
        {
            switch (WinApi.MsgWaitForMultipleObjectsEx(0, IntPtr.Zero, 12, QS.ALLINPUT, 0))
            {
                case WAIT.OBJECT_0:
                    while (WinApi.PeekMessageW(out message, IntPtr.Zero, 0, 0, PM.REMOVE))
                    {
                        if (message.Message == WM.QUIT)
                            Stop();
                        WinApi.TranslateMessage(in message);
                        WinApi.DispatchMessageW(in message);
                    };
                    break;
                case WAIT.TIMEOUT:
                    HandleActions();
                    break;
            }
        }
    }
}
