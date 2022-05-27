using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core.Primitives
{
    public class Bitmap
    {
        public Header BmpHeader { get; private set; }

        public int Type => BmpHeader.Type;
        public int Width => BmpHeader.Width;
        public int Height => BmpHeader.Height;
        public int WidthBytes => BmpHeader.WidthBytes;
        public int Planes => BmpHeader.Planes;
        public int BitsPixel => BmpHeader.BitsPixel;

        public byte[] Bits { get; }

        public Bitmap(int rype, int width, int height, int widthBytes, uint planes, uint bitsPixel, byte[] bits)
        {
            unchecked
            {
                BmpHeader = new Header(rype, width, height, widthBytes, planes, bitsPixel);
                Bits = bits;
            }
        }

        public void SaveBmp(string path)
        {
            int headerSize = Marshal.SizeOf<Header>();
            int bitsSize = BmpHeader.WidthBytes * BmpHeader.Height;
            IntPtr data = Marshal.AllocHGlobal(headerSize);
            Marshal.StructureToPtr(BmpHeader, data, false);

            byte[] buffer = new byte[headerSize + bitsSize];
            Marshal.Copy(data, buffer, 0, headerSize);

            for (int i = headerSize; i < headerSize + bitsSize - 2; i++)
                buffer[i] = Bits[i - headerSize];

            Marshal.FreeHGlobal(data);

            File.WriteAllBytes(path, buffer);
        }


        public struct Header
        {
            public int Type { get; }
            public int Width { get; }
            public int Height { get; }
            public int WidthBytes { get; }
            public int Planes { get; }
            public int BitsPixel { get; }
            public Header(int type, int width, int height, int widthBytes, uint planes, uint bitsPixel)
            {
                Type = type;
                Width = width;
                Height = height;
                WidthBytes = widthBytes;
                Planes = (int)planes;
                BitsPixel = (int)bitsPixel;
            }
        }
    }
}
