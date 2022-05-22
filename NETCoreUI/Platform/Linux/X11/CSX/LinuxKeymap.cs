using NETCoreUI.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Linux.X11.CSX
{
    public class LinuxKeymap
    {
        private Key[] map;

        public LinuxKeymap()
        {
            map = new Key[]
            {
                
            };
        }

        public Key Convert(int linuxKeyCode)
        {
            return Key.Unknown;
        }
    }
}
