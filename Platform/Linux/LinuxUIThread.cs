using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using X11;

namespace NETCoreUI.Platform.Linux
{
    public class LinuxUIThread : Crossplatform.UIThread
    {
        public LinuxEnvironment LinuxEnvironmant => (LinuxEnvironment)Environment;

        private IntPtr unmanagedEvent;

        public LinuxUIThread(LinuxEnvironment environmant): base(environmant)
        {
            unmanagedEvent = Marshal.AllocHGlobal(XEvent.StructSize);
        }

        protected override void ReceiveMessages()
        {
            while (X.XPending(LinuxEnvironmant.Display) != 0)
            {
                X.XNextEvent(LinuxEnvironmant.Display, unmanagedEvent);
                XEvent xEvent = Marshal.PtrToStructure<XEvent>(unmanagedEvent);
                LinuxWindow.__NextEvent(in xEvent);
            }
            HandleActions();
        }

        ~LinuxUIThread()
        {
            Marshal.FreeHGlobal(unmanagedEvent);
        }
    }
}
