﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core
{
    public interface IEnvironmant
    {
        IUIThread UIThread { get; }
        IWIndow CreateWindow();
        void JoinUIThread();
    }
}
