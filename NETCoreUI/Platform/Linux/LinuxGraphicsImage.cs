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

        public LinuxGraphicsImage(IntPtr display, int width, int heigth, byte[] data)
        {
            size = new Size(width, heigth);
            Display = display;
            Root = X.XDefaultRootWindow(Display);

            IntPtr bitsPtr = Marshal.AllocHGlobal(width * heigth * 4);
            Marshal.Copy(data, 0, bitsPtr, data.Length);
            Pixmap = XCreatePixmapFromBitmapData(Display, Root, bitsPtr , width, heigth, 0, 0, 24);
            Marshal.FreeHGlobal(bitsPtr);

            LinuxGraphics = new LinuxGraphicsContext(Display, Pixmap, true);
        }

        ~LinuxGraphicsImage()
        {
            XFreePixmap(Display, Pixmap);
        }
    }
}
