
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NETCoreUI.Core.Exceptions
{
    public static class RequireUiThread
    {
        public static void RequireUIThread(IUIThread uIThread)
        {
            if (uIThread.IsCurrentThread == false) throw new NotUIThreadException();
        }
    }
}
