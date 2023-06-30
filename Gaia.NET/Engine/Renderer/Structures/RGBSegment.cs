namespace Gaia.NET.Engine.Renderer.Structures
{
    public readonly struct RGBSegment
    {
        public byte R { get; }
        public byte G { get; }
        public byte B { get; }

        public RGBSegment(byte red, byte green, byte blue)
        {
            R = red;
            G = green;
            B = blue;
        }
        public RGBSegment(uint red, uint green, uint blue)
        {
            R = (byte)red;
            G = (byte)green;
            B = (byte)blue;
        }
    }
}
