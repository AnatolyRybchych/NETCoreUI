﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core
{
    public interface IUIThread
    {
        IEnvironment Environment { get; }
        void Execute(Action action);
        public void Stop();
        bool IsCurrentThread { get; }
    }
}
