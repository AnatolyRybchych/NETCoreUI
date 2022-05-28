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
        public int Type { get; }
        public int Width { get; }
        public int Height { get; }
        public int WidthBytes { get; }
        public int Planes { get; }
        public int BitsPixel { get; }

        public byte[] Bits { get; }

        public Bitmap(int width, int height, int widthBytes, uint planes, uint bitsPixel, byte[] bits)
        {
            unchecked
            {
                Type = 0;
                Width = width;
                Height = height;
                WidthBytes = widthBytes;
                Planes = (int)planes;
                BitsPixel = (int)bitsPixel;
                Bits = bits;
            }
        }

        public void SaveBmp(string path)
        {
            FileHeader hdr = new FileHeader(this);

            byte[] buffer = new byte[hdr.header.filesize];

            int hdrBmpSize = Marshal.SizeOf<FileHeader.Header>();
            IntPtr hdrBmp = Marshal.AllocHGlobal(hdrBmpSize);

            int hdrInfoSize = Marshal.SizeOf<FileHeader.InfoHeader>();
            IntPtr hdrInfo = Marshal.AllocHGlobal(hdrInfoSize);

            int colorTableFieldSize = Marshal.SizeOf<FileHeader.ColorTableField>();
            int colorTableSize = colorTableFieldSize * hdr.colorTable.Length;
            IntPtr colorTable = Marshal.AllocHGlobal(colorTableSize);

            Marshal.StructureToPtr(hdr.header, hdrBmp, false);
            Marshal.StructureToPtr(hdr.info, hdrInfo, false);
            for(int i =0; i < hdr.colorTable.Length; i++)
                Marshal.StructureToPtr(hdr.colorTable, colorTable + i * colorTableFieldSize, false);

            Marshal.Copy(hdrBmp, buffer, 0, hdrBmpSize);
            Marshal.Copy(hdrInfo, buffer, hdrBmpSize, hdrInfoSize);
            Marshal.Copy(colorTable, buffer, hdrBmpSize + hdrInfoSize, colorTableSize);
            Bits.CopyTo(buffer, hdrBmpSize + hdrInfoSize + colorTableSize);

            Marshal.FreeHGlobal(hdrBmp);
            Marshal.FreeHGlobal(hdrInfo);
            Marshal.FreeHGlobal(colorTable);

            File.WriteAllBytes(path, buffer);
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct FileHeader
        {
            public Header header;
            public InfoHeader info;
            public ColorTableField[] colorTable;

            public FileHeader(Bitmap bitmap)
            {
                uint fileHeaderSize = (uint)(Marshal.SizeOf<Header>() + Marshal.SizeOf<InfoHeader>());
                header = new Header((uint)(fileHeaderSize + bitmap.WidthBytes * bitmap.Height), fileHeaderSize);
                info = new InfoHeader((uint)bitmap.Width, (uint)bitmap.Height, (ushort)bitmap.Planes, (ushort)bitmap.BitsPixel);
                colorTable = new ColorTableField[0];
            }

            [StructLayout(LayoutKind.Explicit, Size = 14)]
            public struct Header
            {
                [FieldOffset(0)]
                public byte signeture1;
                [FieldOffset(1)]
                public byte signeture2;
                [FieldOffset(2)]
                public uint filesize;
                [FieldOffset(6)]
                public uint reserved;
                [FieldOffset(10)]
                public uint dataOffset;

                public Header(uint filesize, uint dataOffset)
                {
                    signeture1 = (byte)'B';
                    signeture2 = (byte)'M';
                    this.filesize = filesize;
                    reserved = 0;
                    this.dataOffset = dataOffset;
                }
            }

            [StructLayout(LayoutKind.Explicit, Size=40)]
            public struct InfoHeader
            {
                [FieldOffset(0)]
                public uint size;
                [FieldOffset(4)]
                public uint width;
                [FieldOffset(8)]
                public uint height;
                [FieldOffset(12)]
                public ushort planes;
                [FieldOffset(14)]
                public ushort bitsPerPixel;
                [FieldOffset(16)]
                public uint compression;
                [FieldOffset(20)]
                public uint imageSize;
                [FieldOffset(24)]
                public uint xPixelsPerM;
                [FieldOffset(28)]
                public uint yPixelsPerM;
                [FieldOffset(32)]
                public uint colorsUsed;
                [FieldOffset(36)]
                public uint importantColors;

                public InfoHeader(uint width, uint height, ushort planes, ushort bitsPerPixel, uint compression = 0, 
                    uint xPixelsPerM = 5000, uint yPixelsPerM = 5000, uint importantColors = 0)
                {
                    size = 40;
                    this.width = width;
                    this.height = height;
                    this.planes = planes;
                    this.bitsPerPixel = bitsPerPixel;
                    this.compression = compression;
                    this.imageSize = width * height * bitsPerPixel / 8;
                    this.xPixelsPerM = xPixelsPerM;
                    this.yPixelsPerM = yPixelsPerM;
                    this.colorsUsed = (uint)(1 << (bitsPerPixel - 1));
                    this.importantColors = importantColors;
                }
            }

            [StructLayout(LayoutKind.Explicit, Size =4)]
            public struct ColorTableField
            {
                [FieldOffset(0)]
                public byte red;
                [FieldOffset(1)]
                public byte green;
                [FieldOffset(2)]
                public byte blue;
                [FieldOffset(3)]
                public byte reserved;
            }
        }
    }
}
