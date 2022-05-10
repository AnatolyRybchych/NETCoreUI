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
    public static class EnvironmantProvider
    {
        private static IEnvironmant? env = null;

        private static IEnvironmant CreateEnvironmant()
        {
            if (Environment.OSVersion.Platform == PlatformID.Unix)
                return env = new LinuxEnvironamnt();
            else if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                return env = new NTEnvironmant();
            else
                throw new PlatformNotSupportedException();
        }

        public static void SplitActionsByEnvironments(Action<LinuxEnvironamnt>? linuxAction, 
            Action<NTEnvironmant>? windowsAction)
        {
            if (Environment.OSVersion.Platform == PlatformID.Unix)
                linuxAction?.Invoke((LinuxEnvironamnt)GetEnvironmant());
            else if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                windowsAction?.Invoke((NTEnvironmant)GetEnvironmant());
            else
                throw new PlatformNotSupportedException();
        }

        public static IEnvironmant GetEnvironmant()
        {
            if (env == null)
                return CreateEnvironmant();
            else
                return env;
        }
    }

    public static class WindowInterpreter
    {
        public static LinuxEnvironamnt ToLinux(this IEnvironmant env) => (LinuxEnvironamnt)env;
        public static NTEnvironmant ToWindows(this IEnvironmant env) => (NTEnvironmant)env;

        public static LinuxWindow ToLinux(this IWIndow wnd) => (LinuxWindow)wnd;
        public static NTWindow ToWindows(this IWIndow wnd) => (NTWindow)wnd;

        public static LinuxUIThread ToLinux(this IUIThread uith) => (LinuxUIThread)uith;
        public static NTUIThread ToWindows(this IUIThread uith) => (NTUIThread)uith;
    }
}
