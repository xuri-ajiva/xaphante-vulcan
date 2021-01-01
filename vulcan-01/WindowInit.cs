#define WIN_32

using System.Collections.Generic;
using System.Diagnostics;
#if WIN_32

using System;
using System.Windows.Forms;
using SharpVk.Khronos;
using System.Drawing;

#else

using SharpVk.Glfw;

#endif

namespace vulcan_01
{
    internal partial class Program
    {
#if WIN_32
        private Form window;

        private void CreateSurface()
        {
            surface = instance.CreateWin32Surface(IntPtr.Zero, window.Handle);
        }
        
        private IEnumerable<string> GetRequiredInstanceExtensions()
        {
           return new[]{ "VK_KHR_surface", "VK_KHR_win32_surface"};
        }

        private void InitWindow()
        {
            window = new()
            {
                Text = "Vulkan",
                ClientSize = new(SurfaceWidth, SurfaceHeight),
                MinimumSize = new(SurfaceWidth / 2, SurfaceHeight / 2),
                MaximumSize = new(SurfaceWidth * 2, SurfaceHeight * 2),
            };
                                             
            window.ClientSizeChanged += (x, y) => RecreateSwapChain();
        }

        private void MainLoop()
        {
            window.Show();
            
            initialTimestamp = Stopwatch.GetTimestamp();
            
            while (!window.IsDisposed)
            {
                //UpdateApplication();
                UpdateUniformBuffer();
                DrawFrame();

                Application.DoEvents();
            }
        }

        private void CloseWindow()
        {
            window.Close();
            window.Dispose();
        }

#else
        private WindowHandle window;

        private void CreateSurface()
        {
            surface = instance.CreateGlfw3Surface(window);
        }

        private void InitWindow()
        {
            Glfw3.Init();

            Glfw3.WindowHint(WindowAttribute.ClientApi, 0);
            window = Glfw3.CreateWindow(SurfaceWidth, SurfaceHeight, "First test", MonitorHandle.Zero, WindowHandle.Zero);
            Glfw3.SetWindowSizeCallback(window, (a, b, c) =>
            {
                RecreateSwapChain();
            });

            glfw3.Glfw3.Public.SetWindowSizeLimits_0(window.RawHandle, SurfaceWidth / 2, SurfaceHeight / 2, SurfaceWidth * 2, SurfaceHeight);
        }

        private void MainLoop()
        {

            this.initialTimestamp = Stopwatch.GetTimestamp();

            while (!Glfw3.WindowShouldClose(window))
            {
                DrawFrame();

                Glfw3.PollEvents();
            }
        }

        private void CloseWindow()
        {
            Glfw3.DestroyWindow(window);

            Glfw3.Terminate();
        }

        private IEnumerable<string> GetRequiredInstanceExtensions()
        {
            return Glfw3.GetRequiredInstanceExtensions();
        }
#endif
    }
}
