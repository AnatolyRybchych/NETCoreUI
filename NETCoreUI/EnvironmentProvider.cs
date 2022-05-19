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
    public static class EnvironmentProvider
    {
        private static IEnvironment? env = null;

        private static IEnvironment CreateEnvironment()
        {
            if (Environment.OSVersion.Platform == PlatformID.Unix)
                return env = new LinuxEnvironment();
            else if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                return env = new NTEnvironmant();
            else
                throw new PlatformNotSupportedException();
        }

        public static void SplitActionsByEnvironments(Action<LinuxEnvironment>? linuxAction, 
            Action<NTEnvironmant>? windowsAction)
        {
            if (Environment.OSVersion.Platform == PlatformID.Unix)
                linuxAction?.Invoke((LinuxEnvironment)GetEnvironment());
            else if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                windowsAction?.Invoke((NTEnvironmant)GetEnvironment());
            else
                throw new PlatformNotSupportedException();
        }

        public static IEnvironment GetEnvironment()
        {
            if (env == null)
                return CreateEnvironment();
            else
                return env;
        }
    }

    public static class SymbolInterpreter
    {
        public static LinuxEnvironment ToLinux(this IEnvironment env) => (LinuxEnvironment)env;
        public static NTEnvironmant ToWindows(this IEnvironment env) => (NTEnvironmant)env;

        public static LinuxWindow ToLinux(this IWIndow wnd) => (LinuxWindow)wnd;
        public static NTWindow ToWindows(this IWIndow wnd) => (NTWindow)wnd;

        public static LinuxUIThread ToLinux(this IUIThread uith) => (LinuxUIThread)uith;
        public static NTUIThread ToWindows(this IUIThread uith) => (NTUIThread)uith;
    }
}
