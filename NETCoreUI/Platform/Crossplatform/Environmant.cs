using NETCoreUI.Core;
using NETCoreUI.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Crossplatform
{
    public abstract class Environmant : IEnvironmant
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
            if (uiThread.IsCurrentThread)
                return CreateBaseWindow(title);
            else
                throw new NotUIThreadException();
#else
            return CreateBaseWindow(title);
#endif
        }

        public IWIndow CreateWindow(string title, int width, int height)
        {
#if DEBUG
            if (uiThread.IsCurrentThread)
                return CreateBaseWindow(title, width, height);
            else
                throw new NotUIThreadException();
#else
            return CreateBaseWindow(title, width, height);
#endif
        }

        public IWIndow CreateWindowWithoutTitleBar()
        {
#if DEBUG
            if (uiThread.IsCurrentThread)
                return CreateBaseWindowWithoutTitleBar();
            else
                throw new NotUIThreadException();
#else
            return CreateBaseWindowWithoutTitleBar();
#endif
        }

        public IWIndow CreateWindowWithoutTitleBar(int width, int height)
        {
#if DEBUG
            if (uiThread.IsCurrentThread)
                return CreateBaseWindowWithoutTitleBar(width, height);
            else
                throw new NotUIThreadException();
#else
            return CreateBaseWindowWithoutTitleBar(width, height);
#endif
        }
    }
}
