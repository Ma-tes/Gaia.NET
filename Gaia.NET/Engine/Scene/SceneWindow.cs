using Bgfx;
using Gaia.NET.Engine.Scene.Interfaces;
using Gaia.NET.Engine.Scene.Structures;
using Silk.NET.GLFW;
using System.Runtime.CompilerServices;

namespace Gaia.NET.Engine.Scene
{
    public class SceneWindow : IWindow, IDisposable
    {
        private bool isDisposed = false;
        private unsafe bool isRunning => !GlfwApi.WindowShouldClose(WindowHandle);

#nullable disable
        internal Glfw GlfwApi { get; private set; }
        internal unsafe WindowHandle* WindowHandle { get; private set; }

        public IntPtr? WindowPointer { get; internal protected set; }
        public WindowData WindowData { get; set; } = WindowData.Default;
        public Action OnExecuteEvent { get; set; }

        public SceneWindow() { }
        public SceneWindow(WindowData windowData)
        {
            WindowData = windowData;
        }

        public virtual bool CreateInitialization() 
        {
            GlfwApi = Glfw.GetApi();
            GlfwApi.Init();

            WindowPointer = CreateWindowHandle(WindowData);
            return WindowPointer is not null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ExecuteEventHandler(int swapInterval = 0)
        {
            GlfwApi.SwapInterval(swapInterval);
            while (isRunning && !isDisposed)
            {
                GlfwApi.WaitEvents();
                GlfwApi.PollEvents();
                unsafe { GlfwApi.SwapBuffers(WindowHandle); }

                if (OnExecuteEvent.Target is not null)
                    OnExecuteEvent();
            }
        }

        private unsafe IntPtr? CreateWindowHandle(WindowData windowData) 
        {
            IntPtr returnWindowHandle = (IntPtr)GlfwApi.CreateWindow(windowData.WindowSize.Width,
                windowData.WindowSize.Width, windowData.Title, null, null);

            if (returnWindowHandle != IntPtr.Zero) 
            {
                WindowHandle* returnHandle = (WindowHandle*)returnWindowHandle;
                GlfwApi.MakeContextCurrent(returnHandle);
                WindowHandle = returnHandle;
                return returnWindowHandle;
            }
            return null;
        }

        public unsafe void Dispose()
        {
            if (WindowPointer is not null)
                GlfwApi.DestroyWindow(WindowHandle);
            bgfx.shutdown();
            isDisposed = true;
        }
    }
}
