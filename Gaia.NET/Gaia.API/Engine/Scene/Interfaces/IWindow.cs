using Gaia.NET.Gaia.API.Engine.Scene.Structures;

namespace Gaia.NET.Gaia.API.Engine.Scene.Interfaces
{
    internal interface IWindow
    {
        public IntPtr? WindowPointer { get; }
        public WindowData WindowData { get; set; }
    }
}
