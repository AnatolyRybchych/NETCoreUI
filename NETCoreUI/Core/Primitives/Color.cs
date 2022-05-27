using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core.Primitives
{
    public abstract class Color
    {
        public abstract float R { get; }
        public abstract float G { get; }
        public abstract float B { get; }
        public abstract float A { get; }

        public uint COLORREF => unchecked((uint)((byte)(B * 255) << 16) | (uint)((byte)(G * 255) << 8) | (uint)((byte)(R * 255)));
        public uint XColor => unchecked((uint)((byte)(R * 255) << 16) | (uint)((byte)(G * 255) << 8) | (uint)((byte)(B * 255)));
    }
}
