﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core.WindowEvents
{
    public delegate void LeftMouseDownEventHandler(object sender, IEnvironment environment, MouseButtonEventArgs e);
    public delegate void LeftMouseUpEventHandler(object sender, IEnvironment environment, MouseButtonEventArgs e);
    public delegate void RightMouseDownEventHandler(object sender, IEnvironment environment, MouseButtonEventArgs e);
    public delegate void RightMouseUpEventHandler(object sender, IEnvironment environment, MouseButtonEventArgs e);

    public class MouseButtonEventArgs: EventArgs
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public MouseButtonEventArgs(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
