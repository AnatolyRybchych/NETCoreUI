
using NETCoreUI.Core;

namespace NETCoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnvironmant ev = EnvironmantProvider.GetEnvironmant();

            ev.StartUIThread();
            ev.UIThread.Execute(() =>
            {
                IWIndow window = ev.CreateWindow("Window");
            });

            ev.JoinUIThread();
        }
    }
}