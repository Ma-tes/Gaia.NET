using Bgfx;
using Gaia.NET.Engine.Renderer.Interfaces;
using Gaia.NET.Engine.Renderer.Structures;
using Gaia.NET.Engine.Scene.Structures;

namespace Gaia.NET.Engine.Renderer.BxfxRendering
{
    internal sealed class BgfxRenderer : IRenderer
    {
        private unsafe bgfx.Init* initPointer;

        public WindowData Window { get; } = WindowData.Default;
        public bgfx.Resolution WindowResolution { get; }
        public unsafe bgfx.Init Initialization => *initPointer;

        public BgfxRenderer() { }
        public BgfxRenderer(WindowData windowData)
        {
            Window = windowData;
            WindowResolution = new bgfx.Resolution()
            {
                width = (uint)Window.WindowSize.Width,
                height = (uint)Window.WindowSize.Height,
                reset = (uint)bgfx.ResetFlags.Vsync
            };
        }

        public unsafe bool TryInitializate() 
        {
            (*initPointer).resolution = WindowResolution;
            return bgfx.init(initPointer);
        }

        public void DrawPixel(ColorVertex colorVertex, int scale)
        {
            bgfx.createver
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
