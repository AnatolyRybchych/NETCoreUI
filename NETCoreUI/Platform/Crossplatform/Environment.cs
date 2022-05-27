using NETCoreUI.Core;
using NETCoreUI.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static NETCoreUI.Core.Exceptions.RequireUiThread;

namespace NETCoreUI.Platform.Crossplatform
{
    public abstract class Environment : IEnvironment
    {
        protected abstract UIThread uiThread { get; }

        protected abstract IWIndow CreateBaseWindow(string title);
        protected abstract IWIndow CreateBaseWindow(string title, int width, int height);
        protected abstract IWIndow CreateBaseWindowWithoutTitleBar();
        protected abstract IWIndow CreateBaseWindowWithoutTitleBar(int width, int height);

        public IUIThread UIThread => uiThread;
        public void JoinUIThread() => uiThread.Join();
        public void StartUIThread() => uiThread.Start();

        public IWIndow CreateWindow(string title)
        {
#if DEBUG
            RequireUIThread(UIThread);
#endif
            return CreateBaseWindow(title);

        }

        public IWIndow CreateWindow(string title, int width, int height)
        {
#if DEBUG
            RequireUIThread(UIThread);
#endif
            return CreateBaseWindow(title, width, height);

        }

        public IWIndow CreateWindowWithoutTitleBar()
        {
#if DEBUG
            RequireUIThread(UIThread);
#endif
            return CreateBaseWindowWithoutTitleBar();
        }

        public IWIndow CreateWindowWithoutTitleBar(int width, int height)
        {
#if DEBUG
            RequireUIThread(UIThread);
#endif
            return CreateBaseWindowWithoutTitleBar(width, height);

        }

        public abstract IGraphicsImage CreateGraphicsImage(int width, int height);
    }
}
