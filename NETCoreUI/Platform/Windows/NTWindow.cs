using NETCoreUI.Core;
using NETCoreUI.Core.WindowEvents;
using NETCoreUI.Core.Primitives;
using NETCoreUI.Platform.Windows.Win32;
using NETCoreUI.Platform.Windows.Win32.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static NETCoreUI.Platform.Windows.CSWindows.Win32Macro;
using NETCoreUI.Platform.Windows.CSWindows;

namespace NETCoreUI.Platform.Windows
{
    public delegate IntPtr fnWndProc(IntPtr hwnd, WM msg, IntPtr wParam, IntPtr lParam);

    public delegate void WndProcHandler(IntPtr hwnd, WM msg, IntPtr wParam, IntPtr lParam);

    public class NTWindow : Crossplatform.Window
    {
        private static readonly WindowsKeymap Keymap = new WindowsKeymap();
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
                    uint dwLparam = (uint)(lparam.ToInt64() & 0x00000000ffffffff);
                    OnMouseMove(new MouseMoveEventArgs(GET_X_LPARAM(dwLparam), GET_Y_LPARAM(dwLparam)));
                    return IntPtr.Zero;
                case WM.WM_LBUTTONDOWN:
                    dwLparam = (uint)(lparam.ToInt64() & 0x00000000ffffffff);
                    OnLeftMouseButtonDown(new MouseButtonEventArgs(GET_X_LPARAM(dwLparam), GET_Y_LPARAM(dwLparam)));
                    return IntPtr.Zero;
                case WM.WM_LBUTTONUP:
                    dwLparam = (uint)(lparam.ToInt64() & 0x00000000ffffffff);
                    OnLeftMouseButtonUp(new MouseButtonEventArgs(GET_X_LPARAM(dwLparam), GET_Y_LPARAM(dwLparam)));
                    return IntPtr.Zero;
                case WM.WM_RBUTTONDOWN:
                    dwLparam = (uint)(lparam.ToInt64() & 0x00000000ffffffff);
                    OnRightMouseButtonDown(new MouseButtonEventArgs(GET_X_LPARAM(dwLparam), GET_Y_LPARAM(dwLparam)));
                    return IntPtr.Zero;
                case WM.WM_RBUTTONUP:
                    dwLparam = (uint)(lparam.ToInt64() & 0x00000000ffffffff);
                    OnRigthMouseButtonUp(new MouseButtonEventArgs(GET_X_LPARAM(dwLparam), GET_Y_LPARAM(dwLparam)));
                    return IntPtr.Zero;
                case WM.WM_MBUTTONDOWN:
                    dwLparam = (uint)(lparam.ToInt64() & 0x00000000ffffffff);
                    OnMiddleMouseButtonDown(new MouseButtonEventArgs(GET_X_LPARAM(dwLparam), GET_Y_LPARAM(dwLparam)));
                    return IntPtr.Zero;
                case WM.WM_MBUTTONUP:
                    dwLparam = (uint)(lparam.ToInt64() & 0x00000000ffffffff);
                    OnMiddleMouseButtonUp(new MouseButtonEventArgs(GET_X_LPARAM(dwLparam), GET_Y_LPARAM(dwLparam)));
                    return IntPtr.Zero;
                case WM.WM_XBUTTONDOWN:
                    dwLparam = (uint)(lparam.ToInt64() & 0x00000000ffffffff);
                    uint dwWparam = (uint)(wparam.ToInt64() & 0x00000000ffffffff);
                    if(HIWORD(dwWparam) == 1) OnMouse4ButtonDown(new MouseButtonEventArgs(GET_X_LPARAM(dwLparam), GET_Y_LPARAM(dwLparam)));
                    else OnMouse5ButtonDown(new MouseButtonEventArgs(GET_X_LPARAM(dwLparam), GET_Y_LPARAM(dwLparam)));
                    return new IntPtr(1);
                case WM.WM_XBUTTONUP:
                    dwLparam = (uint)(lparam.ToInt64() & 0x00000000ffffffff);
                    dwWparam = (uint)(wparam.ToInt64() & 0x00000000ffffffff);
                    if (HIWORD(dwWparam) == 1) OnMouse4ButtonUp(new MouseButtonEventArgs(GET_X_LPARAM(dwLparam), GET_Y_LPARAM(dwLparam)));
                    else OnMouse5ButtonUp(new MouseButtonEventArgs(GET_X_LPARAM(dwLparam), GET_Y_LPARAM(dwLparam)));
                    return new IntPtr(1);
                case WM.WM_MOUSEWHEEL:
                    dwLparam = (uint)(lparam.ToInt64() & 0x00000000ffffffff);
                    dwWparam = (uint)(wparam.ToInt64() & 0x00000000ffffffff);
                    OnVerticalScroll(new MouseScrollEventArgs(GET_WHEEL_DELTA_WPARAM(dwWparam) > 0 ? 1 : -1));
                    return IntPtr.Zero;
                case WM.WM_MOUSEHWHEEL:
                    dwLparam = (uint)(lparam.ToInt64() & 0x00000000ffffffff);
                    dwWparam = (uint)(wparam.ToInt64() & 0x00000000ffffffff);
                    OnHorisontalScroll(new MouseScrollEventArgs(GET_WHEEL_DELTA_WPARAM(dwWparam) > 0 ? 1 : -1));
                    return IntPtr.Zero;
                case WM.WM_SYSKEYDOWN:
                case WM.WM_KEYDOWN:
                    dwLparam = (uint)(lparam.ToInt64() & 0x00000000ffffffff);
                    dwWparam = (uint)(wparam.ToInt64() & 0x00000000ffffffff);
                    
                    if ((HIWORD(dwLparam) & 0x4000) != 0x4000)
                        OnKeyDown(new KeyEventArgs(Keymap.Convert((VK)LOWORD(dwWparam))));
                    return IntPtr.Zero;
                case WM.WM_SYSKEYUP:
                case WM.WM_KEYUP:
                    dwWparam = (uint)(wparam.ToInt64() & 0x00000000ffffffff);
                    OnKeyUp(new KeyEventArgs(Keymap.Convert((VK)LOWORD(dwWparam))));
                    return IntPtr.Zero;
                default:
                    return WinApi.DefWindowProcW(hwnd, msg, wparam, lparam);
            }
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
