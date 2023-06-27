namespace Gaia.NET.Engine.Renderer
{
    internal readonly struct Color
    {
        public RGBSegment RGBSegment { get; }
        public uint HexadecimalCode { get; }

        public Color(byte red, byte green, byte blue) 
        {
            RGBSegment = new RGBSegment(red, green, blue);
            HexadecimalCode = CalculateHexadecimalCode(RGBSegment);
        }

        public Color(uint hexadecimalCode) 
        {
            HexadecimalCode = hexadecimalCode;
            RGBSegment = CalculateRGBSegment(HexadecimalCode);
        }

        public static RGBSegment CalculateRGBSegment(uint hexadecimalCode) =>
            new RGBSegment(
                GetShiftHexColor(hexadecimalCode, 16),
                GetShiftHexColor(hexadecimalCode, 8),
                GetShiftHexColor(hexadecimalCode, 0));
        public static uint CalculateHexadecimalCode(RGBSegment rgbSegment) =>
            (uint)((rgbSegment.R << 16) | (rgbSegment.G << 8) | rgbSegment.B);

        private static uint GetShiftHexColor(uint hexadecimalCode, int offset) =>
            (hexadecimalCode >> offset) & 0xFF;
    }
}
