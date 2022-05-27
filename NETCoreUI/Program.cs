
using NETCoreUI.Core;
using NETCoreUI.Core.Primitives;
using NETCoreUI.Platform.Windows;
using System.Runtime.InteropServices;

using static GL.GL;

namespace NETCoreUI
{
    class Program
    {

        static void Main(string[] args)
        {
            IEnvironment ev = EnvironmentProvider.GetEnvironment();

            
            IWIndow? window = null;
            
            ev.StartUIThread();
            ev.JoinUIThread();
        }

        private static void Window_UnFocus(object sender, IEnvironment environment, Core.WindowEvents.UnFocusEventArgs e)
        {
            Console.WriteLine("UnFocus");
        }

        private static void Window_Focus(object sender, IEnvironment environment, Core.WindowEvents.FocusEventArgs e)
        {
            Console.WriteLine("Focus");
        }

        private static void Window_MouseLeave(object sender, IEnvironment environment, Core.WindowEvents.MouseLeaveEventArgs e)
        {
            Console.WriteLine("Mouse leave");
        }

        private static void Window_MouseEnter(object sender, IEnvironment environment, Core.WindowEvents.MouseEnterEventArgs e)
        {
            Console.WriteLine("Mouse enter");
        }

        private static void Window_Move(object sender, IEnvironment environment, Core.WindowEvents.MoveEventArgs e)
        {
            Console.WriteLine($"Move {{{e.Position.X}, {e.Position.Y}}}");
        }

        private static void Window_Resize(object sender, IEnvironment environment, Core.WindowEvents.ResizeEventArgs e)
        {
            Console.WriteLine($"Resize {{{e.Size.Width}, {e.Size.Height}}}");
        }

        private static void Window_Redraw(object sender, IEnvironment environment, Core.WindowEvents.RedrawEventArgs e)
        {
            Console.WriteLine("Redraw");
            e.Graphics.SimpleRenderer.FillAliasedRect(new Color32RGB(140, 70, 35), new Rect(100, 100));
            e.Graphics.SimpleRenderer.FillAliasedCircle(new Color32RGB(140, 70, 35), new Rect(150, 0, 100, 100));
            e.Graphics.SimpleRenderer.FillAliasedArc(new Color32RGB(140, 70, 35),new Point(0, 150), 50, 20.0f, 130.0f);
            e.Graphics.SimpleRenderer.DrawAliasedLine(new Color32RGB(140, 70, 35), new Point(10, 100), new Point(190, 100));
        }

        private static void Window_KeyUp(object sender, IEnvironment environment, Core.WindowEvents.KeyEventArgs e)
        {
            Console.WriteLine($"KeyUp {e.Key}");
        }

        private static void Window_KeyDown(object sender, IEnvironment environment, Core.WindowEvents.KeyEventArgs e)
        {
            Console.WriteLine($"KeyDown {e.Key}");
        }

        private static void Window_HorisontalScroll(object sender, IEnvironment environment, Core.WindowEvents.MouseScrollEventArgs e)
        {
            Console.WriteLine($"horisontal scroll delta:{e.Delta}");
        }

        private static void Window_VericalScroll(object sender, IEnvironment environment, Core.WindowEvents.MouseScrollEventArgs e)
        {
            Console.WriteLine($"vertical scroll delta:{e.Delta}");
        }

        private static void Window_Mouse5ButtonUp(object sender, IEnvironment environment, Core.WindowEvents.MouseButtonEventArgs e)
        {
            Console.WriteLine($"release mouse5 button {{{e.X}; {e.Y}}}");
        }

        private static void Window_Mouse5ButtonDown(object sender, IEnvironment environment, Core.WindowEvents.MouseButtonEventArgs e)
        {
            Console.WriteLine($"mouse5 button {{{e.X}; {e.Y}}}");
        }

        private static void Window_Mouse4ButtonUp(object sender, IEnvironment environment, Core.WindowEvents.MouseButtonEventArgs e)
        {
            Console.WriteLine($"release mouse4 button {{{e.X}; {e.Y}}}");
        }

        private static void Window_Mouse4ButtonDown(object sender, IEnvironment environment, Core.WindowEvents.MouseButtonEventArgs e)
        {
            Console.WriteLine($"mouse4 button {{{e.X}; {e.Y}}}");
        }

        private static void Window_MiddleMouseButtonUp(object sender, IEnvironment environment, Core.WindowEvents.MouseButtonEventArgs e)
        {
            Console.WriteLine($"release middle mouse button {{{e.X}; {e.Y}}}");
        }

        private static void Window_MiddleMouseButtonDown(object sender, IEnvironment environment, Core.WindowEvents.MouseButtonEventArgs e)
        {
            Console.WriteLine($"middle mouse button {{{e.X}; {e.Y}}}");
        }

        private static void Window_LeftMouseButtonUp(object sender, IEnvironment environment, Core.WindowEvents.MouseButtonEventArgs e)
        {
            Console.WriteLine($"release left mouse button {{{e.X}; {e.Y}}}");
        }

        private static void Window_RightMouseButtonUp(object sender, IEnvironment environment, Core.WindowEvents.MouseButtonEventArgs e)
        {
            Console.WriteLine($"release right mouse button {{{e.X}; {e.Y}}}");
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