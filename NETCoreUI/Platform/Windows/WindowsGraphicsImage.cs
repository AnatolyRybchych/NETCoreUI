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

        public WindowsGraphicsImage(int width, int height)
        {
            IntPtr descktopDc = WinApi.GetDC(IntPtr.Zero);
            IntPtr bmpDc = WinApi.CreateCompatibleDC(descktopDc);
            WinApi.DeleteDC(descktopDc);

            HBitmap = Create(bmpDc, width, height);
            WinApi.SelectObject(bmpDc, HBitmap);

            WindowsGraphics = new WindowsGraphicsContext(bmpDc, true);
        }

        protected virtual IntPtr Create(IntPtr hdc, int width, int height) => WinApi.CreateCompatibleBitmap(hdc, width, height);
    }
}
