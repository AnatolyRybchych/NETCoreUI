using NETCoreUI.Core;
using NETCoreUI.Core.Primitives;
using NETCoreUI.Platform.Linux.X11;
using NETCoreUI.Platform.Linux.X11.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using X11;

namespace NETCoreUI.Platform.Linux
{
    public class LinuxGraphicsContext : GraphicsContext
    {
        public IntPtr Display { get; private set; }
        public long Drawable { get; private set; }
        public IntPtr Gc { get; private set; }
        public bool FromPixmap { get; private set; }

        protected override LinuxOpenGlContext CreateGlContext() =>  new LinuxOpenGlContext(this);
        protected override ISimpleRenderer CreateSimpleRenderer() => new LinuxSimpleRenderer(this);

        public override void DrawImageIgnoreAlpha(IGraphicsImage image, Size size) => DrawImageIgnoreAlpha(image, size, new Point(0, 0));

        public override void DrawImageIgnoreAlpha(IGraphicsImage image, Size size, Point pos)
        {
            if(image is LinuxGraphicsImage)
            {
                X.XCopyArea(Display, ((LinuxGraphicsImage)image).Pixmap, Drawable, Gc, 0, 0, size.Width, size.Height, pos.X, pos.Y);
            }
        }

        public override void DrawImageApplyAlpha(IGraphicsImage image, Size size) => DrawImageApplyAlpha(image, size, new Point(0, 0));

        public override void DrawImageApplyAlpha(IGraphicsImage image, Size size, Point pos)
        {
            IntPtr img = X.XGetImage(Display, ((LinuxGraphicsImage)image).Pixmap, 0, 0, size.Width, size.Height, 1, LinuxImage.ZPixmap);
            if (img == IntPtr.Zero) throw new Exception($"Cannot get XImage from {image.GetType().Name}");
            X.XSetForeground(Display, Gc, 0xffffffff);
            X.XPutImage(Display, Drawable, Gc, img, 0, 0, pos.X, pos.Y, size.Width, size.Height);
            X.XDestroyImage(img);
        }

        public LinuxSimpleRenderer LinuxRenderer => (LinuxSimpleRenderer)SimpleRenderer;

        public LinuxGraphicsContext(IntPtr display, long drawable, bool fromPixmap = false)
        {
            FromPixmap = fromPixmap;
            Display = display;
            Drawable = drawable;
            Gc = X.XCreateGC(Display, Drawable, 0, IntPtr.Zero);
        }


        ~LinuxGraphicsContext()
        {
            X.XFreeGC(Display, Gc);
        }

        public class LinuxSimpleRenderer : ISimpleRenderer
        {
            public LinuxGraphicsContext Graphics { get; private set; }

            public IntPtr Display { get; private set; }
            public long Drawable { get; private set; }

            public IntPtr Gc => Graphics.Gc;

            public LinuxSimpleRenderer(LinuxGraphicsContext graphics)
            {
                Graphics = graphics;
                Display = graphics.Display;
                Drawable = graphics.Drawable;
            }

            public void FillAliasedCircle(Color color, Rect bounds)
            {
                X.XSetForeground(Display, Gc, color.XColor);
                X.XFillArc(Display, Drawable, Gc, bounds.X, bounds.Y, bounds.Width, bounds.Height, 0, 360 * 64);
            }

            public void FillAliasedRect(Color color, Rect rect)
            {
                X.XSetForeground(Display, Gc, color.XColor);
                X.XFillRectangle(Display, Drawable, Gc, rect.X, rect.Y, rect.Width, rect.Height);
                
            }

            public void FillAliasedArc(Color color, Point position, int radius, float angleStart, float angleEnd)
            {
                X.XSetForeground(Display, Gc, color.XColor);
                unchecked
                {
                    X.XFillArc(Display, Drawable, Gc, position.X, position.Y, radius * 2, radius * 2, (int)(angleStart * 64), (int)(angleEnd * 64));
                }
            }

            public void DrawAliasedLine(Color color, Point p1, Point p2)
            {
                X.XSetForeground(Display, Gc, color.XColor);
                X.XDrawLine(Display, Drawable, Gc, p1.X, p1.Y, p2.X, p2.Y);
            }
        }

        protected class LinuxOpenGlContext : IOpenGlContext
        {

            public LinuxGraphicsContext GraphicsContext { get; private set; }
            public IntPtr GlxContext { get; private set; }

            public LinuxOpenGlContext(LinuxGraphicsContext graphicsContext)
            {
                GraphicsContext = graphicsContext;

                if (GraphicsContext.FromPixmap) throw new NotImplementedException("opengl for pixmap");

                int drawableType = GraphicsContext.FromPixmap ? GLX_PIXMAP_BIT : GLX_WINDOW_BIT;

                int[] visualAttribs = new int[]
                {
                    GLX_X_RENDERABLE, TRUE,
                    GLX_DRAWABLE_TYPE, drawableType,
                    GLX_RENDER_TYPE, GLX_RGBA_BIT,
                    GLX_X_VISUAL_TYPE, GLX_TRUE_COLOR,
                    GLX_RED_SIZE, 8,
                    GLX_GREEN_SIZE, 8,
                    GLX_BLUE_SIZE, 8,
                    GLX_ALPHA_SIZE, 8,
                    GLX_DEPTH_SIZE, 24,
                    GLX_STENCIL_SIZE, 8,
                    GLX_DOUBLEBUFFER, TRUE,
                    ATTRIBS_END
                };

                int glxMinorVersion, glxMajorVersion;
                if (Glx.glXQueryVersion(GraphicsContext.Display, out glxMinorVersion, out glxMajorVersion) == 0
                    || ((glxMajorVersion == 1) && (glxMinorVersion < 3)) || (glxMajorVersion < 1)) throw 
                        new Exception("Required glx v1.3 or higher");

                int countEements;
                IntPtr fbcPtr = Glx.glXChooseFBConfig(GraphicsContext.Display, X.XDefaultScreen(GraphicsContext.Display), visualAttribs, out countEements);
                if (fbcPtr == IntPtr.Zero) throw new Exception("Failed to retrieve a framebuffer config");

                int best_fbc = -1, worst_fbc = -1, best_num_samp = -1, worst_num_samp = 999;
                for (int i = 0; i < countEements; i++)
                {
                    IntPtr fbc = Marshal.PtrToStructure<IntPtr>(fbcPtr + i * Marshal.SizeOf<IntPtr>());
                    IntPtr viPtr = Glx.glXGetVisualFromFBConfig(GraphicsContext.Display, fbc);

                    if(viPtr != IntPtr.Zero)
                    {
                        int samp_buf, samples;

                        Glx.glXGetFBConfigAttrib(GraphicsContext.Display, fbc, GLX_SAMPLE_BUFFERS, out samp_buf);
                        Glx.glXGetFBConfigAttrib(GraphicsContext.Display, fbc, GLX_SAMPLES, out samples);

                        XVisualInfo vi = Marshal.PtrToStructure<XVisualInfo>(viPtr);
                        if (best_fbc < 0 || samp_buf != 0 && samples > best_num_samp)
                        {
                            best_fbc = i;
                            best_num_samp = samples;
                        }
                        if (worst_fbc < 0 || samp_buf == 0 || samples < worst_num_samp)
                        {
                            worst_fbc = i;
                            worst_num_samp = samples;
                        }
                    }
                    X.XFree(viPtr);
                }

                IntPtr bestFbc = Marshal.PtrToStructure<IntPtr>(fbcPtr + best_fbc * Marshal.SizeOf<IntPtr>());

                GlxContext = Glx.glXCreateNewContext(GraphicsContext.Display, bestFbc, GLX_RGBA_TYPE, IntPtr.Zero, true);
                X.XFree(fbcPtr);
            }

            public void MakeCurrent() => Glx.glXMakeCurrent(GraphicsContext.Display, GraphicsContext.Drawable, GlxContext);
            public void SwapBuffers() => Glx.glXSwapBuffers(GraphicsContext.Display, GraphicsContext.Drawable);

            public const int GLX_X_RENDERABLE = 0x8012;
            public const int GLX_DRAWABLE_TYPE = 0x8010;
            public const int GLX_RENDER_TYPE = 0x8011;
            public const int GLX_X_VISUAL_TYPE = 0x22;
            public const int GLX_RED_SIZE = 8;
            public const int GLX_GREEN_SIZE = 9;
            public const int GLX_BLUE_SIZE = 10;
            public const int GLX_ALPHA_SIZE = 11;
            public const int GLX_DEPTH_SIZE = 12;
            public const int GLX_STENCIL_SIZE = 13;
            public const int GLX_DOUBLEBUFFER = 5;
            public const int GLX_WINDOW_BIT = 1;
            public const int GLX_PIXMAP_BIT = 2;
            public const int GLX_RGBA_BIT = 1;
            public const int GLX_TRUE_COLOR = 0x8002;
            public const int TRUE = 1;
            public const int ATTRIBS_END = 0;
            public const int GLX_SAMPLE_BUFFERS = 0x186a0;
            public const int GLX_SAMPLES = 0x186a1;
            public const int GLX_RGBA_TYPE = 0x8014;
        }
    }
}
