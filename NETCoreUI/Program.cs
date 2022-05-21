
using NETCoreUI.Core;

namespace NETCoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnvironment ev = EnvironmentProvider.GetEnvironment();

            ev.StartUIThread();
            IWIndow window;
            ev.UIThread.Execute(() =>
            {
                window = ev.CreateWindow("Window");
                window.RightMouseButtonDown += Window_RightMouseButtonDown;
                window.LeftMouseButtonDown += Window_LeftMouseButtonDown;
                window.MouseMove += Window_MouseMove;
            });

            ev.JoinUIThread();
        }

        private static void Window_MouseMove(object sender, IEnvironment environment, Core.WindowEvents.MouseMoveEventArgs e)
        {
            Console.WriteLine($"mouseMove {{{e.X}; {e.Y}}}");
        }

        private static void Window_LeftMouseButtonDown(object sender, IEnvironment environment, Core.WindowEvents.MouseButtonEventArgs e)
        {
            Console.WriteLine($"left mouse button {{{e.X}; {e.Y}}}");
        }

        private static void Window_RightMouseButtonDown(object sender, IEnvironment environment, Core.WindowEvents.MouseButtonEventArgs e)
        {
            Console.WriteLine($"rigth mouse button {{{e.X}; {e.Y}}}");
        }
    }
}