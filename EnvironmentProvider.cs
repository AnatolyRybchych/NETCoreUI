﻿using NETCoreUI.Core;
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
                return env = new NTEnvironment();
            else
                throw new PlatformNotSupportedException();
        }

        public static void SplitActionsByEnvironments(Action<LinuxEnvironment>? linuxAction = null, 
            Action<NTEnvironment>? windowsAction = null)
        {
            if (Environment.OSVersion.Platform == PlatformID.Unix)
                linuxAction?.Invoke((LinuxEnvironment)GetEnvironment());
            else if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                windowsAction?.Invoke((NTEnvironment)GetEnvironment());
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
}
