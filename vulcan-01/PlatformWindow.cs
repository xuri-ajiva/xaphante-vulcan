#define WIN_32

using System;
using System.Collections.Generic;
using SharpVk;
using SharpVk.Khronos;

#if WIN_32
using System.Windows.Forms;
#else
using SharpVk.Glfw;

#endif

namespace vulcan_01
{
    public class PlatformWindow : IPlatformWindow
    {
        public event EventHandler OnFrame;
        public event EventHandler OnResize;
        public Surface Surface { get; private set; }

#if WIN_32
        private Form window;

        public void CreateSurface(Instance instance)
        {
            Surface = instance.CreateWin32Surface(IntPtr.Zero, window.Handle);
        }

        public IEnumerable<string> GetRequiredInstanceExtensions()
        {
            return new[]
            {
                "VK_KHR_surface", "VK_KHR_win32_surface"
            };
        }

        public void InitWindow(int surfaceWidth, int surfaceHeight)
        {
            window = new()
            {
                Text = "Vulkan",
                ClientSize = new(surfaceWidth, surfaceHeight),
                MinimumSize = new(surfaceWidth / 2, surfaceHeight / 2),
                MaximumSize = new(surfaceWidth * 2, surfaceHeight * 2),
            };

            window.ClientSizeChanged += (x, y) => OnResize(this, y);
        }

        public void MainLoop()
        {
            window.Show();

            while (!window.IsDisposed)
            {
                OnFrame?.Invoke(this, EventArgs.Empty);

                Application.DoEvents();
            }
        }

        public void CloseWindow()
        {
            window.Close();
            window.Dispose();
        }

#else
        private WindowHandle window;

        public void CreateSurface(Instance instance)
        {
            Surface = instance.CreateGlfw3Surface(window);
        }

        public void InitWindow(int surfaceWidth, int surfaceHeight)
        {
            Glfw3.Init();

            Glfw3.WindowHint(WindowAttribute.ClientApi, 0);
            window = Glfw3.CreateWindow(surfaceWidth, surfaceHeight, "First test", MonitorHandle.Zero, WindowHandle.Zero);
            Glfw3.SetWindowSizeCallback(window, (a, b, c) =>
            {
                OnResize.Invoke(this, EventArgs.Empty);
            });

            glfw3.Glfw3.Public.SetWindowSizeLimits_0(window.RawHandle, surfaceWidth / 2, surfaceHeight / 2, surfaceWidth * 2, surfaceHeight);
        }

        public void MainLoop()
        {
            while (!Glfw3.WindowShouldClose(window))
            {
                OnFrame.Invoke(this, EventArgs.Empty);

                Glfw3.PollEvents();
            }
        }

        public void CloseWindow()
        {
            Glfw3.DestroyWindow(window);

            Glfw3.Terminate();
        }

        public IEnumerable<string> GetRequiredInstanceExtensions()
        {
            return Glfw3.GetRequiredInstanceExtensions();
        }
#endif
    }
    public interface IPlatformWindow
    {
        public void InitWindow(int SurfaceWidth, int surfaceHeight);
        public IEnumerable<string> GetRequiredInstanceExtensions();
        public void CreateSurface(Instance instance);
        public void MainLoop();
        public void CloseWindow();
        public event EventHandler OnFrame;
        public event EventHandler OnResize;
        public SharpVk.Khronos.Surface Surface { get; }
    }
}
