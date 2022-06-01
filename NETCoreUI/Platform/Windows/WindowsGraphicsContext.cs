using NETCoreUI.Core;
using NETCoreUI.Core.Primitives;
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
        public bool FromBitmap;
        private bool deleteDc;

        public WindowsGraphicsContext(IntPtr hdc, bool deleteDcAutomaticly, bool fromBitmap = false)
        {
            FromBitmap = fromBitmap;
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
        protected override ISimpleRenderer CreateSimpleRenderer() => new WindowsSimpleRenderer(this);

        public override void DrawImageIgnoreAlpha(IGraphicsImage image, Size size) => DrawImageIgnoreAlpha(image, size, new Point());

        public override void DrawImageIgnoreAlpha(IGraphicsImage image, Size size, Point pos)
        {
            BitBlt(Hdc, pos.X, pos.Y, size.Width, size.Height, image.Graphics.ToWindows().Hdc, 0, 0);
        }

        public /*override*/ void DrawImageApplyAlpha(IGraphicsImage image, Size size) => DrawImageApplyAlpha(image, size, new Point(0, 0));

        public /*override*/ void DrawImageApplyAlpha(IGraphicsImage image, Size size, Point pos)
        {
            AlphaBlend(Hdc, pos.X, pos.Y, size.Width, size.Height, image.Graphics.ToWindows().Hdc, 0, 0, size.Width, size.Height, new BLENDFUNCTION(255));
        }

        public WindowsSimpleRenderer WindowsRenderer => (WindowsSimpleRenderer)SimpleRenderer;

        public class WindowsSimpleRenderer:ISimpleRenderer
        {
            public WindowsGraphicsContext Graphics { get; private set; }
            private IntPtr hdc;

            public WindowsSimpleRenderer(WindowsGraphicsContext graphics)
            {
                Graphics = graphics;
                hdc = Graphics.Hdc;
            }

            public void FillAliasedRect(Color color, Rect rect)
            {
                IntPtr brush = CreateSolidBrush(color.COLORREF);
                Win32.WinApi.FillRect(hdc, new RECT()
                {
                    left = rect.Left,
                    top = rect.Top,
                    right = rect.Right,
                    bottom = rect.Bottom
                },
                brush);
                DeleteObject(brush);
            }

            public void FillAliasedCircle(Color color, Rect bounds)
            {
                IntPtr brush = CreateSolidBrush(color.COLORREF);
                IntPtr pen = CreatePen();
                SelectObject(hdc, brush);
                SelectObject(hdc, pen);
                Ellipse(hdc, bounds.Left, bounds.Top, bounds.Right, bounds.Bottom);
                DeleteObject(pen);
                DeleteObject(brush);
            }

            public void FillAliasedArc(Color color, Point position, int radius, float angleStart, float angleEnd)
            {
                IntPtr brush = CreateSolidBrush(color.COLORREF);
                SelectObject(hdc, brush);
                BeginPath(hdc);
                MoveToEx(hdc, position.X + radius, position.Y + radius, IntPtr.Zero);
                AngleArc(hdc, position.X + radius, position.Y + radius, unchecked((uint)radius), angleStart, angleEnd);
                EndPath(hdc);
                FillPath(hdc);
                DeleteObject(brush);
            }

            public void DrawAliasedLine(Color color, Point p1, Point p2)
            {
                IntPtr pen = CreatePen(0, 1, color.COLORREF);
                SelectObject(hdc, pen);
                BeginPath(hdc);
                MoveToEx(hdc, p1.X, p1.Y, IntPtr.Zero);
                LineTo(hdc, p2.X, p2.Y);
                EndPath(hdc);
                StrokePath(hdc);
                DeleteObject(pen);
            }
        }

        protected class WindowsOpenGlContext : IOpenGlContext
        {
            public IntPtr Hglrc { get; private set; }
            public WindowsGraphicsContext GraphicsContext { get; private set; }

            public WindowsOpenGlContext(WindowsGraphicsContext graphicsContext)
            {
                GraphicsContext = graphicsContext;
                wglMakeCurrent(GraphicsContext.Hdc, IntPtr.Zero);

                if (GraphicsContext.FromBitmap) throw new NotImplementedException("opengl for bitmap");

                PFD target = GraphicsContext.FromBitmap ? PFD.PFD_DRAW_TO_BITMAP : PFD.PFD_DRAW_TO_WINDOW;

                PIXELFORMATDESCRIPTOR pfd = new PIXELFORMATDESCRIPTOR()
                {
                    nSize = (ushort)Marshal.SizeOf<PIXELFORMATDESCRIPTOR>(),
                    nVersion = 1,
                    dwFlags = (uint)(target | PFD.PFD_SUPPORT_OPENGL | PFD.PFD_DOUBLEBUFFER),
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
