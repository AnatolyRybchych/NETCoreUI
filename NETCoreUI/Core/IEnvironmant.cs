using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core
{
    public interface IEnvironmant
    {
        IUIThread UIThread { get; }
        IWIndow CreateWindowWithoutTitleBar();
        IWIndow CreateWindowWithoutTitleBar(int width, int height);
        IWIndow CreateWindow(string title);
        IWIndow CreateWindow(string title, int width, int height);
        void JoinUIThread();
        void StartUIThread();
    }
}
