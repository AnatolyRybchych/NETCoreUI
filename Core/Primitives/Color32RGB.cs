using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core.Primitives
{
    public class Color32RGB : Color
    {
        public byte red;
        public byte green;
        public byte blue;

        public Color32RGB() => red = green = blue = 0;

        public Color32RGB(byte r, byte g, byte b)
        {
            red = r;
            green = g;
            blue = b;
        }

        public override float R => red / 255.0f;

        public override float G => green / 255.0f;

        public override float B => blue / 255.0f;

        public override float A => 1.0f;
    }
}
