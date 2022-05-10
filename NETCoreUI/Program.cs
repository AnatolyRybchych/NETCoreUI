
using NETCoreUI.Core;

namespace NETCoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnvironmant ev = EnvironmantProvider.CreateEnvironmantForCurrentOS();

            ev.JoinUIThread();
        }
    }
}