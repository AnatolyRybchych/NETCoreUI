﻿
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
            });

            ev.JoinUIThread();
        }

        private static void Window_RightMouseButtonDown(object sender, IEnvironment environment, Core.WindowEvents.MouseButtonEventArgs e)
        {
            Console.WriteLine($"rigth mouse button {{{e.X}; {e.Y}}}");
        }
    }
}