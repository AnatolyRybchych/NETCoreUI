using NETCoreUI.Core;
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

        private static void CreateEnvironmant()
        {
            if (Environment.OSVersion.Platform == PlatformID.Unix)
                env = new Platform.Linux.LinuxEnvironamnt();
            else if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                env = new Platform.Windows.NTEnvironmant();
            else
                throw new PlatformNotSupportedException();
        }

        public static void SplitActionsByEnvironments(Action<Platform.Linux.LinuxEnvironamnt>? linuxAction, Action<Platform.Windows.NTEnvironmant>? windowsAction)
        {
            var env = GetEnvironmant();
            if (Environment.OSVersion.Platform == PlatformID.Unix)
                linuxAction?.Invoke((Platform.Linux.LinuxEnvironamnt)env);
            else if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                windowsAction?.Invoke((Platform.Windows.NTEnvironmant)env);
            else
                throw new PlatformNotSupportedException();
        }

        public static IEnvironmant GetEnvironmant()
        {
            if (env == null)
                CreateEnvironmant();
            return env;
        }
    }
}
