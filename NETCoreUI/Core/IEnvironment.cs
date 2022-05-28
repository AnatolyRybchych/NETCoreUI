using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core
{
    public interface IEnvironment
    {
        IUIThread UIThread { get; }
        IWIndow CreateWindowWithoutTitleBar();
        IWIndow CreateWindowWithoutTitleBar(int width, int height);
        IWIndow CreateWindow(string title);
        IWIndow CreateWindow(string title, int width, int height);
        IGraphicsImage CreateGraphicsImage(int width, int height);
        IImage CreateImage(int width, int height);
        void JoinUIThread();
        void StartUIThread();
    }
}
