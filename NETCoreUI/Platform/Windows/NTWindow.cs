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

using static NETCoreUI.Platform.Windows.CSWindows.Win32Macro;

namespace NETCoreUI.Platform.Windows
{
    public delegate IntPtr fnWndProc(IntPtr hwnd, WM msg, IntPtr wParam, IntPtr lParam);

    public delegate void WndProcHandler(IntPtr hwnd, WM msg, IntPtr wParam, IntPtr lParam);

    public class NTWindow : Crossplatform.Window
    {
        private static int counter = 0;
        private fnWndProc __wndProcDelegate;

        public NTUIThread NTUIThread { get; private set; }
        public IntPtr HInstance { get; private set; }
        public IntPtr HWindow { get; private set; }
        public NTEnvironment NTEnvironamnt => (NTEnvironment)Environment;

        public event WndProcHandler? WindowProc;

        public override IUIThread UIThread => NTUIThread;
        public override Point Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Size Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Rect Rect { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Title { get => "qwe"; set => throw new NotImplementedException(); }

        private string RegisterClass()
        {
            WNDCLASSEXW wc = new WNDCLASSEXW();
            wc.HInstance = HInstance;
            wc.CbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf<WNDCLASSEXW>();
            wc.LpfnWndProc = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(__wndProcDelegate);
            wc.LpszClassName = $"CoreUIWnd{counter++}";

            if (WinApi.RegisterClassExW(in wc) == 0)
                throw new Exception("Cannot register window class");
            return wc.LpszClassName;
        }

        public NTWindow(NTEnvironment environment, NTUIThread uiThread, IntPtr hInstance, string title,WS_EX ex_styles, WS styles, int x, int y, int width, int height, IntPtr parent):base(environment)
        {
            __wndProcDelegate = WndProc;
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
                case WM.WM_MOUSEMOVE:
                    int dwLparam = lparam.ToInt32();
                    OnMouseMove(new MouseMoveEventArgs(GET_X_LPARAM(dwLparam), GET_Y_LPARAM(dwLparam)));
                    break;
                case WM.WM_LBUTTONDOWN:
                    dwLparam = lparam.ToInt32();
                    OnLeftMouseButtonDown(new MouseButtonEventArgs(GET_X_LPARAM(dwLparam), GET_Y_LPARAM(dwLparam)));
                    break;
                case WM.WM_LBUTTONUP:
                    dwLparam = lparam.ToInt32();
                    OnLeftMouseButtonUp(new MouseButtonEventArgs(GET_X_LPARAM(dwLparam), GET_Y_LPARAM(dwLparam)));
                    break;
                case WM.WM_RBUTTONDOWN:
                    dwLparam = lparam.ToInt32();
                    OnRightMouseButtonDown(new MouseButtonEventArgs(GET_X_LPARAM(dwLparam), GET_Y_LPARAM(dwLparam)));
                    break;
                case WM.WM_RBUTTONUP:
                    dwLparam = lparam.ToInt32();
                    OnRigthMouseButtonUp(new MouseButtonEventArgs(GET_X_LPARAM(dwLparam), GET_Y_LPARAM(dwLparam)));
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
