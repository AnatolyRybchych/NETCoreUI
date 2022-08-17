﻿using NETCoreUI.Core;
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
using System.Runtime.InteropServices;

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

        public override Point Position
        {
            get
            {
                RECT rect;
                WinApi.GetWindowRect(HWindow, out rect);
                return new Point(rect.left, rect.top);
            }
            set => WinApi.SetWindowPos(HWindow, IntPtr.Zero, value.X, value.Y, 0, 0, SWP.SWP_NOSIZE | SWP.SWP_NOZORDER);
        }

        public override Size Size
        {
            get
            {
                RECT rect;
                WinApi.GetWindowRect(HWindow, out rect);
                return new Size(rect.right - rect.left, rect.bottom - rect.top);
            }
            set => WinApi.SetWindowPos(HWindow, IntPtr.Zero, 0, 0, value.Width, value.Height, SWP.SWP_NOMOVE | SWP.SWP_NOZORDER);
        }

        public override Rect Rect
        {
            get
            {
                RECT rect;
                WinApi.GetWindowRect(HWindow, out rect);
                return new Rect(rect.left, rect.top, rect.right - rect.left, rect.bottom - rect.top);
            }
            set => WinApi.SetWindowPos(HWindow, IntPtr.Zero, value.X, value.Y, value.Width, value.Height, SWP.SWP_NOZORDER);
        }

        public override string Title
        {
            get
            {
                IntPtr text = Marshal.AllocHGlobal(100);
                int len = WinApi.GetWindowTextW(HWindow, text, 100);
                string? res = Marshal.PtrToStringUni(text, len);
                Marshal.FreeHGlobal(text);
                return res ?? "";
            }
            set => WinApi.SetWindowTextW(HWindow, value);
        }

        public WindowsGraphicsContext WindowsGraphics { get; private set; }
        public override GraphicsContext Graphics => WindowsGraphics;

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
            WindowsGraphics = new WindowsGraphicsContext(HWindow);
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
                    var tme = new TRACKMOUSEEVENT(hwnd, 1);
                    WinApi.TrackMouseEvent(ref tme);
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
                case WM.WM_PAINT:
                    PAINTSTRUCT ps;
                    IntPtr hdc = WinApi.BeginPaint(hwnd, out ps);
                    OnRedraw(new RedrawEventArgs(Graphics));
                    WinApi.EndPaint(hwnd, in ps);
                    return IntPtr.Zero;
                case WM.WM_SIZE:
                    dwLparam = (uint)(lparam.ToInt64() & 0x00000000ffffffff);
                    OnResize(new ResizeEventArgs(new Size(LOWORD(dwLparam), HIWORD(dwLparam))));
                    return IntPtr.Zero;
                case WM.WM_MOVE:
                    dwLparam = (uint)(lparam.ToInt64() & 0x00000000ffffffff);
                    OnMove(new MoveEventArgs(new Point(GET_X_LPARAM(dwLparam), GET_Y_LPARAM(dwLparam))));
                    return IntPtr.Zero;
                case WM.WM_MOUSEHOVER:
                    OnMouseEnter(new MouseEnterEventArgs());
                    return IntPtr.Zero;
                case WM.WM_MOUSELEAVE:
                    OnMouseLeave(new MouseLeaveEventArgs());
                    return IntPtr.Zero;
                case WM.WM_ACTIVATE:
                    if (wparam != IntPtr.Zero) OnFocus(new FocusEventArgs());
                    else OnUnFocus(new UnFocusEventArgs());
                    return IntPtr.Zero;
                default:
                    return WinApi.DefWindowProcW(hwnd, msg, wparam, lparam);
            }
        }

        public override void Close() => WinApi.DestroyWindow(HWindow);

        public override void Maximize() => WinApi.ShowWindow(HWindow, SW.Maximize);

        public override void Minimize() => WinApi.ShowWindow(HWindow, SW.Minimize);

        public override void Show() => WinApi.ShowWindow(HWindow, SW.Show);

        public override void ForceRedraw()
        {
            WinApi.InvalidateRect(HWindow, IntPtr.Zero, false);
        }

        ~NTWindow()
        {
        }
    }
}
