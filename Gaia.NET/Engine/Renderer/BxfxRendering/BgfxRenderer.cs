using Bgfx;
using Gaia.NET.Engine.Renderer.Interfaces;
using Gaia.NET.Engine.Renderer.Structures;
using Gaia.NET.Engine.Scene.Structures;

namespace Gaia.NET.Engine.Renderer.BxfxRendering
{
    internal sealed class BgfxRenderer : IRenderer
    {
        private readonly unsafe bgfx.Init* bgfxInitialization;

        public WindowData Window { get; } = WindowData.Default;
        public unsafe bgfx.Init Initialization => *bgfxInitialization;

        public BgfxRenderer() { }
        public BgfxRenderer(WindowData windowData)
        {
            Window = windowData;
        }

        public unsafe bool TryInitializate() =>
            bgfx.init(bgfxInitialization);

        public void DrawPixel(ColorVertex colorVertex, int scale)
        {
        }

        public ValueTask DrawPixelAsync(ColorVertex colorVertex, int scale) =>
            throw new NotImplementedException();

        public void UpdateBufferFrame()
        {
        }

        public ValueTask UpdateBufferFrameAsync() =>
            throw new NotImplementedException();
    }
}
