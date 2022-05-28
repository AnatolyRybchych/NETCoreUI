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
    public class WindowsGraphicsImage : IGraphicsImage
    {
        public IntPtr HBitmap { get; private set; }

        public WindowsGraphicsContext WindowsGraphics { get; private set; }
        public GraphicsContext Graphics => WindowsGraphics;

        private Size size;
        public Size Size => size;

        public WindowsGraphicsImage(int width, int height)
        {
            size = new Size(width, height);
            IntPtr descktopDc = WinApi.GetDC(IntPtr.Zero);
            IntPtr bmpDc = WinApi.CreateCompatibleDC(descktopDc);
            WinApi.DeleteDC(descktopDc);

            HBitmap = Create(bmpDc, width, height);
            WinApi.SelectObject(bmpDc, HBitmap);

            WindowsGraphics = new WindowsGraphicsContext(bmpDc, true, true);
        }

        protected virtual IntPtr Create(IntPtr hdc, int width, int height) => WinApi.CreateBitmap(width, height, 1, 32, IntPtr.Zero);
    }
}
