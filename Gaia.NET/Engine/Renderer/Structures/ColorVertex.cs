using System.Numerics;

namespace Gaia.NET.Engine.Renderer.Structures
{
    public ref struct ColorVertex
    {
        public Color Color { get; set; }
        public Vector2 Position { get; set; }

        public ColorVertex(Color color, Vector2 position) 
        {
            Color = color;
            Position = position;
        }
    }
}
