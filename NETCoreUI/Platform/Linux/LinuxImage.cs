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
    public class LinuxImage : LinuxGraphicsImage, IImage
    {
        public const int XYPixmap = 1;

        public LinuxImage(IntPtr display, int width, int heigth) : base(display, width, heigth)
        {
        }

        public Bitmap CreateBitmap32()
        {
            IntPtr image = XGetImage(Display, Pixmap, 0, 0, Size.Width, Size.Height, 0, XYPixmap);
            XImage xImage = Marshal.PtrToStructure<XImage>(image);

            byte[] bits = new byte[xImage.bytes_per_line * xImage.height];
            Marshal.Copy(xImage.data, bits, 0, bits.Length);

            Bitmap result = new Bitmap(0, xImage.width, xImage.height, xImage.bytes_per_line, 1, (uint)xImage.bits_per_pixel, bits);
            XDestroyImage(image);
            return result;
        }
    }
}
