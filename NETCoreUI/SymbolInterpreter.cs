using NETCoreUI.Core;
using NETCoreUI.Platform.Linux;
using NETCoreUI.Platform.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI
{
    public static class SymbolInterpreter
    {
        public static LinuxEnvironment ToLinux(this IEnvironment env) => (LinuxEnvironment)env;
        public static NTEnvironment ToWindows(this IEnvironment env) => (NTEnvironment)env;

        public static LinuxWindow ToLinux(this IWIndow wnd) => (LinuxWindow)wnd;
        public static NTWindow ToWindows(this IWIndow wnd) => (NTWindow)wnd;

        public static LinuxUIThread ToLinux(this IUIThread uith) => (LinuxUIThread)uith;
        public static NTUIThread ToWindows(this IUIThread uith) => (NTUIThread)uith;

        public static LinuxGraphicsContext ToLinux(this GraphicsContext g) => (LinuxGraphicsContext)g;
        public static WindowsGraphicsContext ToWindows(this GraphicsContext g) => (WindowsGraphicsContext)g;
    }
}
