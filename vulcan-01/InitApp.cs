using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SharpVk;
using SharpVk.Glfw;
using SharpVk.Khronos;
using Buffer = SharpVk.Buffer;

namespace vulcan_01
{
    internal partial class Program
    {
        private static async Task Main(string[] args)
        {
            var pg = new Program();
            pg.Run();
            await Task.Delay(1000);
            Environment.Exit(0);
        }
        
        private void Run()
        {
            InitWindow();
            InitVulkan();
            MainLoop();
            Cleanup();
        }

        private void InitWindow()
        {
            Glfw3.Init();

            Glfw3.WindowHint(WindowAttribute.ClientApi, 0);
            window = Glfw3.CreateWindow(800, 500, "First test", MonitorHandle.Zero, WindowHandle.Zero);
            Glfw3.SetWindowSizeCallback(window, RecreateSwapChain);

            glfw3.Glfw3.Public.SetWindowSizeLimits_0(window.RawHandle, 100,100, 10000,10000);
        }

        private void InitVulkan()
        {
            CreateInstance();
            CreateSurface();
            PickPhysicalDevice();
            CreateLogicalDevice();
            CreateSwapChain();
            CreateImageViews();
            CreateRenderPass();
            CreateShaderModules();
            CreateGraphicsPipeline();
            CreateFrameBuffers();
            CreateCommandPools();
            CreateBufferManager();
            bufferManager.AddBuffer(vertices, indices);
            CreateCommandBuffers();
            CreateSemaphores();
        }

        private void MainLoop()
        {
            while (!Glfw3.WindowShouldClose(window))
            {
                DrawFrame();

                Glfw3.PollEvents();
            }
        }

        private void DrawFrame()
        {
            var nextImage = swapChain.AcquireNextImage(uint.MaxValue, imageAvailableSemaphore, null);

            graphicsQueue.Submit(
                new SubmitInfo
                {
                    CommandBuffers = new[]
                    {
                        commandBuffers[nextImage]
                    },
                    SignalSemaphores = new[]
                    {
                        renderFinishedSemaphore
                    },
                    WaitDestinationStageMask = new[]
                    {
                        PipelineStageFlags.ColorAttachmentOutput
                    },
                    WaitSemaphores = new[]
                    {
                        imageAvailableSemaphore
                    }
                },
                null);

            presentQueue.Present(renderFinishedSemaphore, swapChain, nextImage, new Result[1]);
        }
    }
}
