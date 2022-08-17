using NETCoreUI.Core;
using NETCoreUI.Core.Exceptions;
using NETCoreUI.Core.Primitives;
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
        public IImage CreateImage(int width, int height) => CreateImageArgsChecked(width >= 1 ? width : 1, height >= 1 ? height : 1);
        public abstract IImage CreateImageArgsChecked(int width, int height);
        public IImage CreateImage(Color[,] bits)
        {
            int width = bits.GetLength(0);
            int height = bits.GetLength(1);
            width = width >= 1 ? width : 1;
            height = height >= 1 ? height : 1;

            byte[] bmpBits = new byte[width * height * 4];
            for (int x = 0; x < bits.GetLength(0); x++)
            {
                for (int y = 0; y < bits.GetLength(1); y++)
                {
                    int pix = (y * bits.GetLength(0) + x) * 4;
                    unchecked
                    {
                        bmpBits[pix + 3] = (byte)(bits[x, y].A * 255);
                        bmpBits[pix + 0] = (byte)(bits[x, y].B * 255);
                        bmpBits[pix + 1] = (byte)(bits[x, y].G * 255);
                        bmpBits[pix + 2] = (byte)(bits[x, y].R * 255);
                    }
                }
            }

            return CreateImage(new Bitmap(width, height, width * 4, 1, 32, bmpBits));
        }

        public IImage CreateImage(Color32RGB[,] bits)
        {
            int width = bits.GetLength(0);
            int height = bits.GetLength(1);
            width = width >= 1 ? width : 1;
            height = height >= 1 ? height : 1;

            byte[] bmpBits = new byte[width * height * 4];
            for(int y = 0; y < bits.GetLength(1); y++)
            {
                for (int x = 0; x < bits.GetLength(0); x++)
                {
                    int pix = (y * width + x) * 4;
                    bmpBits[pix + 1] = 255;
                    bmpBits[pix + 0] = bits[x,y].blue;
                    bmpBits[pix + 1] = bits[x,y].green;
                    bmpBits[pix + 2] = bits[x,y].red;
                }
            }

            return CreateImage(new Bitmap(width, height, width * 4, 1, 32, bmpBits));
        }
        public abstract IImage CreateImage(Bitmap bitmap);
        public abstract Size GetPrimaryDisplaySize();
    }
}
