using Gaia.NET.Engine.Scene.Structures;
using System.Numerics;

namespace Gaia.NET.Engine.Renderer.Interfaces
{
    internal interface IRenderer
    {
        public WindowData Window { get; }

        public void DrawPixel(Vector2 position, int scale)
    }
}
