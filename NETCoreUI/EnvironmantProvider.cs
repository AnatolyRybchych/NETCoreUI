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
        public static IEnvironmant CreateEnvironmantForCurrentOS()
        {
            if (Environment.OSVersion.Platform == PlatformID.Unix)
                return new Platform.Linux.LinuxEnvironamnt();
            else if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                return new Platform.Windows.NTEnvironmant();
            else
                throw new PlatformNotSupportedException();
        }
    }
}
