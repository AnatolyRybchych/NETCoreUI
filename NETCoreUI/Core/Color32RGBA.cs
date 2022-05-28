using NETCoreUI.Core.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core
{
    internal class Color32RGBA: Color32RGB
    {
        public byte alpha;

        public Color32RGBA(byte r, byte g, byte b, byte a): base(r, g, b)
        {
            alpha = a;
        }
        public override float A => alpha / 255.0f;
    }
}
