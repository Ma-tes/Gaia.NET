using Gaia.NET.Engine.Scene.Structures;

namespace Gaia.NET.Engine.Scene.Interfaces
{
    internal interface IWindow
    {
        public IntPtr? WindowPointer { get; }
        public WindowData WindowData { get; set; }
    }
}
