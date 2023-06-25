using System.Reflection;

namespace Gaia.NET.Gaia.API.Engine.Scene.Structures
{
    public readonly struct WindowData
    {
        public static WindowData Default { get; }
            = new(new Size<int>(800, 600), $"{Assembly.GetEntryAssembly()!.FullName}");

        public string Title { get; }
        public Size<int> WindowSize { get; }

        public WindowData(Size<int> windowSize, string title) 
        {
            WindowSize = windowSize;
            Title = title;
        }
    }
}
