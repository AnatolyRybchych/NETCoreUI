using NETCoreUI.Core;
using NETCoreUI.Core.WindowEvents;
using NETCoreUI.Platform.Crossplatform.Primitives;
using NETCoreUI.Platform.Windows.Win32;
using NETCoreUI.Platform.Windows.Win32.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows
{
    public delegate IntPtr fnWndProc(IntPtr hwnd, WM msg, IntPtr wParam, IntPtr lParam);

    public delegate void WndProcHandler(IntPtr hwnd, WM msg, IntPtr wParam, IntPtr lParam);

    public class NTWindow : Crossplatform.Window
    {
        private static int counter = 0;

        public NTUIThread NTUIThread { get; private set; }
        public IntPtr HInstance { get; private set; }
        public IntPtr HWindow { get; private set; }

        public event WndProcHandler? WindowProc;

        public override IUIThread UIThread => NTUIThread;
        public override Point Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Size Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Rect Rect { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private string RegisterClass()
        {
            WNDCLASSEXW wc = new WNDCLASSEXW();
            wc.HInstance = HInstance;
            wc.CbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf<WNDCLASSEXW>();
            wc.LpfnWndProc = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(new fnWndProc(WndProc));
            wc.LpszClassName = $"CoreUIWnd{counter++}";

            if (WinApi.RegisterClassExW(in wc) == 0)
                throw new Exception("Cannot register window class");
            return wc.LpszClassName;
        }

        public NTWindow(NTUIThread uiThread, IntPtr hInstance, string title,WS_EX ex_styles, WS styles, int x, int y, int width, int height, IntPtr parent)
        {
            NTUIThread = uiThread;
            HInstance = hInstance;

            HWindow = WinApi.CreateWindowExW(ex_styles, RegisterClass(), title, styles, x, y, width, height, parent, IntPtr.Zero, HInstance, IntPtr.Zero);

            WinApi.ShowWindow(HWindow, SW.Normal);
            WinApi.UpdateWindow(HWindow);
        }

        protected virtual IntPtr WndProc(IntPtr hwnd, WM msg, IntPtr wparam, IntPtr lparam)
        {
            WindowProc?.Invoke(hwnd, msg, wparam, lparam);
            switch (msg)
            {
                case WM.MOUSEMOVE:
                    OnMouseMove(new MouseMoveEventArgs(0, 0));
                    break;
                case WM.LBUTTONDOWN:
                    OnLeftMouseButtonDown(new MouseButtonEventArgs(0, 0));
                    break;
                case WM.LBUTTONUP:
                    OnLeftMouseButtonUp(new MouseButtonEventArgs(0, 0));
                    break;
                case WM.RBUTTONDOWN:
                    OnRightMouseButtonDown(new MouseButtonEventArgs(0, 0));
                    break;
                case WM.RBUTTONUP:
                    OnRigthMouseButtonUp(new MouseButtonEventArgs(0, 0));
                    break;
            }
            return WinApi.DefWindowProcW(hwnd, msg, wparam, lparam);
        }

        public override void Close()
        {
            throw new NotImplementedException();
        }

        public override void Maximize()
        {
            throw new NotImplementedException();
        }

        public override void Minimize()
        {
            throw new NotImplementedException();
        }

        public override void Show()
        {
            throw new NotImplementedException();
        }

        ~NTWindow()
        {
        }
    }
}
