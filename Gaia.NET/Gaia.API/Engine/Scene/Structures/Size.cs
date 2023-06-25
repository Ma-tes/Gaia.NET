namespace Gaia.NET.Gaia.API.Engine.Scene.Structures
{
    public struct Size<T> : IEquatable<Size<T>> where T : unmanaged, IEquatable<T>
    {
        public T Width { get; set; }
        public T Height { get; set; }

        public Size(T width, T height) 
        {
            Width = width;
            Height = height;
        }

        public bool Equals(Size<T> size) =>
            Width.Equals(size.Width) && Height.Equals(size.Height);
    }
}
