    using NETCoreUI.Platform.Windows.Win32.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows.Win32
{
    public static class WinApi
    {

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        [return:MarshalAs(UnmanagedType.Bool)]
        public static extern IntPtr InvalidateRect(IntPtr hwnd, IntPtr rect, bool Erase);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern IntPtr InvalidateRect(IntPtr hwnd, in RECT rect, bool Erase);

        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(SM metric);

        [DllImport("user32.dll")]
        public static extern IntPtr BeginPaint(IntPtr hwnd, out PAINTSTRUCT ps);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndPaint(IntPtr hwnd, in PAINTSTRUCT ps);

        [DllImport("opengl32.dll")]
        public static extern IntPtr wglCreateContext(IntPtr hdc);

        [DllImport("opengl32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool wglDeleteContext(IntPtr hGlRc);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteDC(IntPtr hdc);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AngleArc(IntPtr hdc, int x, int y, uint r, float startAngle, float endAngle);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AbortPath(IntPtr hdc);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BeginPath(IntPtr hdc);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseFigure(IntPtr hdc);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndPath(IntPtr hdc);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FillPath(IntPtr hdc);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool StrokePath(IntPtr hdc);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool StrokeAndFillPath(IntPtr hdc);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveToEx(IntPtr hdc, int x, int y, IntPtr prevPointRet);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LineTo(IntPtr hdc, int x, int y);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateCompatibleDC(IntPtr hdc);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int width, int height);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateDIBSection(IntPtr hdc, in BITMAPINFO bmpInfo, uint usage, out IntPtr bits, IntPtr hSection, ushort offset);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateBitmap(int width, int height, uint planes, uint bitsCount, IntPtr initData);

        [DllImport("gdi32.dll")]
        public static extern int GetObject(IntPtr obj, int size, IntPtr data);

        [DllImport("gdi32.dll")]
        public static extern int GetDIBits(IntPtr hdc, IntPtr hBitmap, uint start, uint lines, IntPtr bitsOut, in BITMAPINFO bitmapInfo, uint usage = 0);

        [DllImport("gdi32.dll")]
        public static extern int GetDIBits(IntPtr hdc, IntPtr hBitmap, uint start, uint lines, IntPtr bits, IntPtr bitmapInfo, uint usage = 0);

        public static BITMAPINFO GetHbitmapBitmapinfo(IntPtr hdc, IntPtr hBitmap)
        {
            BITMAPINFO __bmi = new BITMAPINFO();
            __bmi.bmiHeader.biSize = (uint)Marshal.SizeOf<BITMAPINFOHEADER>();

            IntPtr bmi = Marshal.AllocHGlobal(Marshal.SizeOf<BITMAPINFO>());
            Marshal.StructureToPtr(__bmi, bmi, false);

            GetDIBits(hdc, hBitmap, 0, 0, IntPtr.Zero, bmi);
            BITMAPINFO result = Marshal.PtrToStructure<BITMAPINFO>(bmi);
            Marshal.FreeHGlobal(bmi);
            return result;
        }

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool Ellipse(IntPtr hdc, int left, int top, int rigth, int bottom);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BitBlt(IntPtr hdc, int x, int y, int cx, int cy, IntPtr srcDc, int srcX, int srcY, uint rop = 0x00CC0020);

        [DllImport("Msimg32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AlphaBlend(IntPtr hdc, int x, int y, int cx, int cy, IntPtr srcDc, int srcX, int srcY, int srcCx, int srcCy, BLENDFUNCTION blendfunc);

        [DllImport("user32.dll")]
        public static extern int FillRect(IntPtr hdc, in RECT rect, IntPtr brush);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT rect);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyWindow(IntPtr hwnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hwnd, IntPtr hwndAfter, int x, int y, int width, int height, SWP flags);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowTextW(IntPtr hwnd, [MarshalAs(UnmanagedType.LPWStr)]string text);

        [DllImport("user32.dll")]
        public static extern int GetWindowTextW(IntPtr hwnd, IntPtr text, int textMaxLen);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateSolidBrush(uint colorref);

        [DllImport("gdi32.dll")]
        public static extern IntPtr SelectObject(IntPtr hdc, IntPtr obj);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreatePen(int style = 5, int width = 0, uint colorref = 0);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteObject(IntPtr gdiObj);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TrackMouseEvent(ref TRACKMOUSEEVENT trackEv);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetPixelFormat(IntPtr hdc, int format, ref PIXELFORMATDESCRIPTOR pfd);

        [DllImport("gdi32.dll")]
        public static extern int ChoosePixelFormat(IntPtr hdc, ref PIXELFORMATDESCRIPTOR pfd);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SwapBuffers(IntPtr hdc);

        [DllImport("opengl32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool wglMakeCurrent(IntPtr hdc, IntPtr hGlRc);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekMessageW(out MSG lpMsg, IntPtr hwnd, UInt32 msgFilterMin = 0, uint msgFiletMax = 0, PM removeMsg = PM.REMOVE);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMessageW(out MSG lpMsg, IntPtr hwnd, UInt32 msgFilterMin = 0, uint msgFiletMax = 0);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TranslateMessage(in MSG lpMsg);

        [DllImport("user32.dll")]
        public static extern IntPtr DispatchMessageW(in MSG lpMsg);

        [DllImport("user32.dll")]
        public static extern UInt16 RegisterClassExW(in WNDCLASSEXW wc);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateWindowExW(WS_EX dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName,
            [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, WS dwStyle, Int32 X, Int32 Y, Int32 nWidth, Int32 nHeight,
            IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lpParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr GetModuleHandleW([MarshalAs(UnmanagedType.LPWStr)] string? moduleName);

        [DllImport("user32.dll")]
        public static extern UInt16 ShowWindow(IntPtr hwnd, SW show);

        [DllImport("user32.dll")]
        public static extern UInt16 UpdateWindow(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern IntPtr DefWindowProcW(IntPtr hwnd, WM msg, IntPtr wparam, IntPtr lparam);

        [DllImport("user32.dll")]
        public static extern WAIT MsgWaitForMultipleObjectsEx(UInt32 count, in IntPtr handles, UInt32 miliseconds, QS wakeMask, UInt32 Flags);


    }
}
