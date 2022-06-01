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
        

        public LinuxImage(IntPtr display, int width, int heigth) : base(display, width, heigth)
        {
        }

        public LinuxImage(IntPtr display, int width, int heigth, byte[] data) :base(display, width, heigth, data)
        {

        }

        public Bitmap CreateBitmap32()
        {
            IntPtr image = XGetImage(Display, Pixmap, 0, 0, Size.Width, Size.Height, 1, ZPixmap);
            if (image == IntPtr.Zero) throw new BadImageFormatException($"cannot get XImage from {this}");

            XImage xImage = Marshal.PtrToStructure<XImage>(image);

            byte[] bits = new byte[xImage.bytes_per_line * xImage.height];
            Marshal.Copy(xImage.data, bits, 0, bits.Length);

            Bitmap result = new Bitmap(xImage.width, xImage.height, xImage.bytes_per_line, 0xffffffff, (uint)xImage.bits_per_pixel, bits);
            XDestroyImage(image);
            return result;
        }
    }
}
