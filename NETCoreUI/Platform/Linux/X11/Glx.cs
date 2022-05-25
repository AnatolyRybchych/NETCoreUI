using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Linux.X11
{
    public static class Glx
    {
        public const string lib = "libGL.so";

        [DllImport(lib)]
        public static extern int glXQueryVersion(IntPtr display, out int minor, out int major);

        [DllImport(lib)]
        public static extern IntPtr glXGetFBConfigs(IntPtr display, int screen, out int countElements);

        [DllImport(lib)]
        public static extern IntPtr glXGetVisualFromFBConfig(IntPtr display, IntPtr fbc);

        [DllImport(lib)]
        public static extern int glXGetFBConfigAttrib(IntPtr display, IntPtr fbc, int attribute, out int value);

        [DllImport(lib)]
        public static extern IntPtr glXChooseFBConfig(IntPtr display, int screen, 
            [MarshalAs(UnmanagedType.LPArray)] int[] attribList , out int elementsCount);

        [DllImport(lib)]
        public static extern IntPtr glXCreateNewContext(IntPtr display, IntPtr fbc, int renderType, 
            IntPtr /*glx context*/ shareList,[MarshalAs(UnmanagedType.Bool)] bool dirrect);

        [DllImport(lib)]
        [return:MarshalAs(UnmanagedType.Bool)]
        public static extern bool glXMakeCurrent(IntPtr display, long drawable, IntPtr glxContext);

        [DllImport(lib)]
        public static extern void glXSwapBuffers(IntPtr display, long drawable);
    }
}
