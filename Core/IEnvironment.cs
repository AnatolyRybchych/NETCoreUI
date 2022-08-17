using NETCoreUI.Core.Primitives;
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
        IGraphicsImage CreateGraphicsImage(int width, int height);//most simple image, (graphics buffer)
        IImage CreateImage(int width, int height);
        IImage CreateImage(Color[,] bits);//image intialized by bits
        IImage CreateImage(Color32RGB[,] bits);//image intialized by bits using Color32RGB, should be faster than abstract Color
        IImage CreateImage(Bitmap bitmap);//image intialized by bitmap data
        Size GetPrimaryDisplaySize();
        void JoinUIThread();
        void StartUIThread();
    }
}
