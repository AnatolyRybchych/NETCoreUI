using NETCoreUI.Core;
using NETCoreUI.Core.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using X11;
using static X11.X;

namespace NETCoreUI.Platform.Linux
{
    public class LinuxGraphicsImage : IGraphicsImage
    {
        public const int XYBitmap = 0;
        public const int XYPixmap = 1;
        public const int ZPixmap = 2;
        

        public long Pixmap { get; private set; }
        public IntPtr Display { get; private set; }
        public long Root { get; private set; }

        public LinuxGraphicsContext LinuxGraphics { get; private set; }
        public GraphicsContext Graphics => LinuxGraphics;

        private Size size;
        public Size Size => size;

        public LinuxGraphicsImage(IntPtr display, int width, int heigth)
        {
            size = new Size(width, heigth);
            Display = display;
            Root = X.XDefaultRootWindow(Display);

            Pixmap = XCreatePixmap(Display, Root, width, heigth, 24);
            LinuxGraphics = new LinuxGraphicsContext(Display, Pixmap, true);
        }

        public LinuxGraphicsImage(IntPtr display, int width, int heigth, byte[] data):this(display, width, heigth)
        {
            IntPtr bitsPtr = Marshal.AllocHGlobal(width * heigth * 4);
            Marshal.Copy(data, 0, bitsPtr, data.Length);


            IntPtr img = XCreateImage(Display, XDefaultVisual(Display, XDefaultScreen(Display)), 1, XYBitmap, 0, bitsPtr, width, heigth, 32, width * 4);
            Console.WriteLine($"{XPutImage(Display, this.LinuxGraphics.Drawable, this.LinuxGraphics.Gc, img, 0, 0, 0, 0, width, heigth)}");
            XDestroyImage(img);
            Console.WriteLine("1");
            Marshal.FreeHGlobal(bitsPtr);
            Console.WriteLine("2");
        }

        ~LinuxGraphicsImage()
        {
            XFreePixmap(Display, Pixmap);
        }
    }
}
