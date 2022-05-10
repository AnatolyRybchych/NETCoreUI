using NETCoreUI.Core;
using NETCoreUI.Core.Exceptions;
using NETCoreUI.Platform.Crossplatform;
using NETCoreUI.Platform.Windows.Win32;
using NETCoreUI.Platform.Windows.Win32.Types;
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

        public IntPtr HInstance { get; private set; }

        public NTEnvironmant()
        {
            ntUIThread = new NTUIThread();
            HInstance = WinApi.GetModuleHandleW(null);
        }

        public NTWindow CreateSpecificWindow(string title, WS_EX ex_styles, WS styles, int x, int y, int width, int height, IntPtr parent)
        {
            if (uiThread.IsCurrentThread)
                return new NTWindow(ntUIThread, HInstance, title, ex_styles, styles, x, y, width, height, parent);
            else
                throw new NotUIThreadException();
        }

        protected override IWIndow CreateBaseWindow(string title) => 
            new NTWindow(ntUIThread, HInstance, title, (WS_EX)0, WS.OVERLAPPEDWINDOW, 0, 0, 800, 600, IntPtr.Zero);

        protected override IWIndow CreateBaseWindow(string title, int width, int height) =>
            new NTWindow(ntUIThread, HInstance, title, (WS_EX)0, WS.OVERLAPPEDWINDOW, 0, 0, width, height, IntPtr.Zero);

        protected override IWIndow CreateBaseWindowWithoutTitleBar() =>
            new NTWindow(ntUIThread, HInstance, "", (WS_EX)0, WS.POPUPWINDOW, 0, 0, 800, 600, IntPtr.Zero);

        protected override IWIndow CreateBaseWindowWithoutTitleBar(int width, int height) =>
            new NTWindow(ntUIThread, HInstance, "", (WS_EX)0, WS.POPUPWINDOW, 0, 0, width, height, IntPtr.Zero);
    }
}
