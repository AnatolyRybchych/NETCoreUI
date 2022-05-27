using NETCoreUI.Core;
using NETCoreUI.Core.Primitives;
using NETCoreUI.Platform.Windows.Win32;
using NETCoreUI.Platform.Windows.Win32.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows
{
    public class WindowsImage : WindowsGraphicsImage, IImage
    {
        public WindowsImage(int width, int height) : base(width, height)
        {
        }

        public Bitmap CreateBitmap32()
        {
            BITMAPINFO bi = WinApi.GetHbitmapBitmapinfo(WindowsGraphics.Hdc, HBitmap);

            byte[] bits = new byte[bi.bmiHeader.biSizeImage];
            IntPtr bitsPtr = Marshal.AllocHGlobal(bits.Length);

            WinApi.GetDIBits(WindowsGraphics.Hdc, HBitmap, 0, (uint)bi.bmiHeader.biHeight, bitsPtr, in bi);
            Marshal.Copy(bitsPtr, bits, 0, bits.Length);
            Marshal.FreeHGlobal(bitsPtr);

            return new Bitmap(0, bi.bmiHeader.biWidth, bi.bmiHeader.biHeight, bi.bmiHeader.biWidth * bi.bmiHeader.biBitCount / 8, bi.bmiHeader.biPlanes, bi.bmiHeader.biBitCount, bits);
        }
    }
}
