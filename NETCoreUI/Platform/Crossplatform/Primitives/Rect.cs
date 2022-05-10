
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Crossplatform.Primitives
{

    public struct Rect
    {
        private Point position;
        private Size size;

        public Point Position { get { return position; } set { position = value; } }
        public Size Size { get { return size; } set { size = value; } }

        public int X
        {
            get { return position.X; }
            set => position.X = value;
        }

        public int Y
        {
            get { return position.Y; }
            set { position.Y = value; }
        }

        public int Width
        {
            get { return size.Width; }
            set { size.Width = value; }
        }

        public int Height
        {
            get { return size.Height; }
            set { size.Height = value; }
        }

        public Rect(Point position, Size size)
        {
            this.position = position;
            this.size = size;
        }

        public int Left => position.X;
        public int Top => position.Y;
        public int Right => position.X + size.Width;
        public int Bottom => position.Y + size.Height;

        public Rect(int x, int y, int width, int height) : this(new Point(x, y), new Size(width, height)) {}
        public Rect(int width, int height) : this(new Point(), new Size(width, height)) { }
    }
}
