using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static X11.X;

namespace NETCoreUI.Platform.Linux.X11.CSX
{
    public class QueryPointer
    {
        public IntPtr Display { get; private set; }
        public long Window { get; private set; }

        IntPtr root;
        IntPtr child;
        IntPtr rootX;
        IntPtr rootY;
        IntPtr x;
        IntPtr y;
        IntPtr mask;

        public long Root => Marshal.PtrToStructure<long>(root);
        public long Child => Marshal.PtrToStructure<long>(child);
        public int RootX => Marshal.PtrToStructure<int>(rootX);
        public int RootY => Marshal.PtrToStructure<int>(rootY);
        public int X => Marshal.PtrToStructure<int>(x);
        public int Y => Marshal.PtrToStructure<int>(y);
        public uint Mask => Marshal.PtrToStructure<uint>(mask);

        public void Query() => XQueryPointer(Display, Window, root, child, rootX, rootY, x, y, mask);

        public QueryPointer(IntPtr display, long window)
        {
            Display = display;
            Window = window;

            root = Marshal.AllocHGlobal(sizeof(long));
            child = Marshal.AllocHGlobal(sizeof(long));
            rootX = Marshal.AllocHGlobal(sizeof(int));
            rootY = Marshal.AllocHGlobal(sizeof(int));
            x = Marshal.AllocHGlobal(sizeof(int));
            y = Marshal.AllocHGlobal(sizeof(int));
            mask = Marshal.AllocHGlobal(sizeof(uint));
        }

        ~QueryPointer()
        {
            Marshal.FreeHGlobal(root);
            Marshal.FreeHGlobal(child);
            Marshal.FreeHGlobal(rootX);
            Marshal.FreeHGlobal(rootY);
            Marshal.FreeHGlobal(x);
            Marshal.FreeHGlobal(y);
            Marshal.FreeHGlobal(mask);
        }
    }
}
