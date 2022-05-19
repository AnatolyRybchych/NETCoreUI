
using NETCoreUI.Core;

namespace NETCoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnvironment ev = EnvironmentProvider.GetEnvironment();

            ev.StartUIThread();
            ev.UIThread.Execute(() =>
            {
                IWIndow window = ev.CreateWindow("Window");
                window.RightMouseButtonDown += Window_RightMouseButtonDown;
            });

            ev.JoinUIThread();
        }

        private static void Window_RightMouseButtonDown(object sender, Core.WindowEvents.MouseButtonEventArgs e)
        {
            Console.WriteLine("qwe");
        }
    }
}