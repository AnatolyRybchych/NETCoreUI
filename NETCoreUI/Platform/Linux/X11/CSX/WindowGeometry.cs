using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using static X11.X;

namespace NETCoreUI.Platform.Linux.X11.CSX
{
    public class WindowGeometry
    {
        public IntPtr Display { get; private set; }
        public long Window { get; private set; }

        private IntPtr root;
        private IntPtr x;
        private IntPtr y;
        private IntPtr width;
        private IntPtr height;
        private IntPtr border;
        private IntPtr depth;

        public long Root => Marshal.PtrToStructure<long>(root);
        public int X => Marshal.PtrToStructure<int>(x);
        public int Y => Marshal.PtrToStructure<int>(y);
        public int Width => unchecked((int)Marshal.PtrToStructure<uint>(width));
        public int Height => unchecked((int)Marshal.PtrToStructure<uint>(height));
        public int Border => unchecked((int)Marshal.PtrToStructure<uint>(border));
        public int Depth => unchecked((int)Marshal.PtrToStructure<uint>(depth));

        public void Get() => XGetGeometry(Display, Window, root, x, y, width, height, border, depth);
        
        

        public WindowGeometry(IntPtr display, long window)
        {
            Display = display;
            Window = window;

            root = Marshal.AllocHGlobal(sizeof(long));
            x = Marshal.AllocHGlobal(sizeof(int));
            y = Marshal.AllocHGlobal(sizeof(int));
            width = Marshal.AllocHGlobal(sizeof(uint));
            height = Marshal.AllocHGlobal(sizeof(uint));
            border = Marshal.AllocHGlobal(sizeof(uint));
            depth = Marshal.AllocHGlobal(sizeof(uint));
        }

        ~WindowGeometry()
        {
            Marshal.FreeHGlobal(root);
            Marshal.FreeHGlobal(x);
            Marshal.FreeHGlobal(y);
            Marshal.FreeHGlobal(width);
            Marshal.FreeHGlobal(height);
            Marshal.FreeHGlobal(border);
            Marshal.FreeHGlobal(depth);
        }
    }
}
