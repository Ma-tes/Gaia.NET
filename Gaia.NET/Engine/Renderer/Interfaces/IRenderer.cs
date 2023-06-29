using Gaia.NET.Engine.Renderer.Structures;
using Gaia.NET.Engine.Scene.Structures;

namespace Gaia.NET.Engine.Renderer.Interfaces
{
    internal interface IRenderer : IDisposable
    {
        public WindowData Window { get; }

        public bool TryInitializate();

        public void DrawPixel(ColorVertex colorVertex, int scale);
        public ValueTask DrawPixelAsync(ColorVertex colorVertex, int scale);

        public void UpdateBufferFrame();
        public ValueTask UpdateBufferFrameAsync();
    }
}
