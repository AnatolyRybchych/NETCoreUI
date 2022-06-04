
using NETCoreUI.Core;
using NETCoreUI.Core.Primitives;
using NETCoreUI.Platform.Linux;
using NETCoreUI.Platform.Windows;
using System.Runtime.InteropServices;

using OpenTK.Graphics.OpenGL;
using static OpenTK.Graphics.OpenGL.GL;

namespace NETCoreUI
{

    class GlBindingProvider
    {

        public OpenTK.IBindingsContext Get()
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT) 
                return new WindowsGlBinding();
            else 
                return new LinuxGlBinding();
        }

        private class LinuxGlBinding : OpenTK.IBindingsContext
        {
            [DllImport("libdl.so")]
            protected static extern IntPtr dlopen(string filename, int flags);

            [DllImport("libdl.so")]
            protected static extern IntPtr dlsym(IntPtr handle, string symbol);

            [DllImport("libdl.so")]
            protected static extern IntPtr dlclose(IntPtr handle);

            private IntPtr glLib;
            private const string Lib = "libGL.so";
            const int RTLD_NOW = 2; // for dlopen's flags 

            public LinuxGlBinding()
            {
                glLib = dlopen(Lib, RTLD_NOW);
                if (glLib == IntPtr.Zero) throw new DllNotFoundException(Lib);
            }

            public IntPtr GetProcAddress(string procName) => dlsym(glLib, procName);

            ~LinuxGlBinding() => dlclose(glLib);
        }

        private class WindowsGlBinding : OpenTK.IBindingsContext
        {
            [DllImport("kernel32.dll")]
            private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

            [DllImport("kernel32.dll")]
            private static extern IntPtr LoadLibraryW([MarshalAs(UnmanagedType.LPWStr)] string libName);

            [DllImport("kernel32.dll")] 
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool FreeLibrary(IntPtr hModule);

            private IntPtr glLib;
            private const string Lib = "opengl32.dll";

            public WindowsGlBinding()
            {
                glLib = LoadLibraryW(Lib);
                if (glLib == IntPtr.Zero) throw new DllNotFoundException(Lib);
            }

            public IntPtr GetProcAddress(string procName) => GetProcAddress(glLib, procName);

            ~WindowsGlBinding() => FreeLibrary(glLib);
        }
    }


    class Program
    {

        static void Main(string[] args)
        {

            IEnvironment ev = EnvironmentProvider.GetEnvironment();

            LoadBindings(new GlBindingProvider().Get());


            IWIndow? window = null;
            ev.UIThread.Execute(() =>
            {
                window = ev.CreateWindow("Window");

                window.Rect = new Rect(200, 200, 200, 200);
                window.Title = "wfdsfgds";

                window.RightMouseButtonDown += Window_RightMouseButtonDown;
                window.RightMouseButtonUp += Window_RightMouseButtonUp;

                window.LeftMouseButtonDown += Window_LeftMouseButtonDown;
                window.LeftMouseButtonUp += Window_LeftMouseButtonUp;

                window.MiddleMouseButtonDown += Window_MiddleMouseButtonDown;
                window.MiddleMouseButtonUp += Window_MiddleMouseButtonUp;

                window.Mouse4ButtonDown += Window_Mouse4ButtonDown;
                window.Mouse4ButtonUp += Window_Mouse4ButtonUp;

                window.Mouse5ButtonDown += Window_Mouse5ButtonDown;
                window.Mouse5ButtonUp += Window_Mouse5ButtonUp;

                window.VericalScroll += Window_VericalScroll;

                window.MouseMove += Window_MouseMove;
                window.HorisontalScroll += Window_HorisontalScroll;

                window.KeyDown += Window_KeyDown;
                window.KeyUp += Window_KeyUp;

                window.Redraw += Window_Redraw;

                window.Resize += Window_Resize;
                window.Move += Window_Move;

                window.MouseEnter += Window_MouseEnter;
                window.MouseLeave += Window_MouseLeave;

                window.Focus += Window_Focus;
                window.UnFocus += Window_UnFocus;
            });
            ev.StartUIThread();
            ev.JoinUIThread();
        }

        private static void Window_Redraw(object sender, IEnvironment environment, Core.WindowEvents.RedrawEventArgs e)
        {
            e.Graphics.GlContext.MakeCurrent();
            
            ClearColor(1.0f, 0.0f, 0.0f, 1.0f);
            Clear(ClearBufferMask.ColorBufferBit);
            e.Graphics.GlContext.SwapBuffers();
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