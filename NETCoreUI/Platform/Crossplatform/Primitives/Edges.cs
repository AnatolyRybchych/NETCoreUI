using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Crossplatform.Primitives;
{
    public struct Edges
    {
        private int left;
        private int top;
        private int right;
        private int bottom;

        public int Left { get { return left; } set { left = value; } }
        public int Top { get { return top; } set { top = value; } }
        public int Right { get { return right; } set { right = value; } }
        public int Bottom { get { return bottom; } set { bottom = value; } }

        public Edges(int left, int top, int right, int bottom)
        {
            this.left = left;
            this.top = top;
            this.right = right;
            this.bottom = bottom;
        }
    }
}
