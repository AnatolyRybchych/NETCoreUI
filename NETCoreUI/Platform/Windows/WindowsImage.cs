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
        public WindowsImage(int width, int height, byte[]? data = null) : base(width, height, data)
        {
        }

        protected override IntPtr Create(IntPtr hdc, int width, int height, object? data)
        {
            if(data != null)
            {
                byte[] bmpBits = (byte[])data;
                int dataSize = width * height * 4;
                IntPtr bits = Marshal.AllocHGlobal(dataSize);
                Marshal.Copy(bmpBits, 0, bits, Math.Min(bmpBits.Length, dataSize));
                IntPtr result = WinApi.CreateBitmap(width, height, 1, 32, bits);
                Marshal.FreeHGlobal(bits);
                return result;
            }
            else
            {
                return WinApi.CreateBitmap(width, height, 1, 32, IntPtr.Zero);
            }
            
        }

        public Bitmap CreateBitmap32()
        {
            BITMAPINFO bi = WinApi.GetHbitmapBitmapinfo(WindowsGraphics.Hdc, HBitmap);

            byte[] bits = new byte[bi.bmiHeader.biSizeImage];
            IntPtr bitsPtr = Marshal.AllocHGlobal(bits.Length);

            WinApi.GetDIBits(WindowsGraphics.Hdc, HBitmap, 0, (uint)bi.bmiHeader.biHeight, bitsPtr, in bi);
            Marshal.Copy(bitsPtr, bits, 0, bits.Length);
            Marshal.FreeHGlobal(bitsPtr);

            return new Bitmap(bi.bmiHeader.biWidth, bi.bmiHeader.biHeight, bi.bmiHeader.biWidth * bi.bmiHeader.biBitCount / 8, bi.bmiHeader.biPlanes, bi.bmiHeader.biBitCount, bits);
        }
    }
}
