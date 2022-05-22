using NETCoreUI.Core;
using NETCoreUI.Platform.Windows.Win32.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using static NETCoreUI.Platform.Windows.Win32.WinApi;

namespace NETCoreUI.Platform.Windows
{
    public class WindowsGraphicsContext : GraphicsContext
    {
        public IntPtr Hdc { get; private set; }
        private bool deleteDc;

        public WindowsGraphicsContext(IntPtr hdc, bool deleteDcAutomaticly)
        {
            deleteDc = deleteDcAutomaticly;
            Hdc = hdc;
        }

        public WindowsGraphicsContext(IntPtr hwnd) : this(GetDC(hwnd), true) { }
        public WindowsGraphicsContext(NTWindow window) : this(window.HWindow) { }

        ~WindowsGraphicsContext()
        {
            if (deleteDc) 
                DeleteDC(Hdc);
        }

        protected override IOpenGlContext CreateGlContext() => new WindowsOpenGlContext(this);

        protected class WindowsOpenGlContext : IOpenGlContext
        {
            public IntPtr Hglrc { get; private set; }
            public WindowsGraphicsContext GraphicsContext { get; private set; }

            public WindowsOpenGlContext(WindowsGraphicsContext graphicsContext)
            {
                GraphicsContext = graphicsContext;
                wglMakeCurrent(GraphicsContext.Hdc, IntPtr.Zero);

                PIXELFORMATDESCRIPTOR pfd = new PIXELFORMATDESCRIPTOR()
                {
                    nSize = (ushort)Marshal.SizeOf<PIXELFORMATDESCRIPTOR>(),
                    nVersion = 1,
                    dwFlags = (uint)(PFD.PFD_DRAW_TO_WINDOW | PFD.PFD_SUPPORT_OPENGL | PFD.PFD_DOUBLEBUFFER),
                    cColorBits = 32,
                    cDepthBits = 24,
                    cStencilBits = 8,
                };

                SetPixelFormat(GraphicsContext.Hdc, ChoosePixelFormat(GraphicsContext.Hdc, ref pfd), ref pfd);

                Hglrc = wglCreateContext(GraphicsContext.Hdc);
            }

            public void MakeCurrent() => wglMakeCurrent(GraphicsContext.Hdc, Hglrc);

            public void SwapBuffers() => Win32.WinApi.SwapBuffers(GraphicsContext.Hdc);

            ~WindowsOpenGlContext() => wglDeleteContext(Hglrc);
        }
    }
}
