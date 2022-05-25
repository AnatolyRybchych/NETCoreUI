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
        [DllImport("libglx.so")]
        public static extern int glXQueryVersion(System.IntPtr display, out int minor, out int major);

        [DllImport("libglx.so")]
        public static extern IntPtr glXGetFBConfigs(System.IntPtr display, int screen, out int countElements);

        [DllImport("libglx.so")]
        public static extern IntPtr glXGetVisualFromFBConfig(System.IntPtr display, IntPtr fbc);

        [DllImport("libglx.so")]
        public static extern int glXGetFBConfigAttrib(System.IntPtr display, IntPtr fbc, int attribute, out int value);

        [DllImport("libglx.so")]
        public static extern IntPtr glXChooseFBConfig(System.IntPtr display, int screen, 
            [MarshalAs(UnmanagedType.LPArray)] int[] attribList , out int elementsCount);

        [DllImport("libglx.so")]
        public static extern IntPtr glXCreateNewContext(System.IntPtr display, IntPtr fbc, int renderType, 
            IntPtr /*glx context*/ shareList,[MarshalAs(UnmanagedType.Bool)] bool dirrect);

        [DllImport("libglx.so")]
        [return:MarshalAs(UnmanagedType.Bool)]
        public static extern bool glXMakeCurrent(System.IntPtr display, long drawable, IntPtr glxContext);

        [DllImport("libglx.so")]
        public static extern void glXSwapBuffers(System.IntPtr display, IntPtr glxContext);
    }
}
