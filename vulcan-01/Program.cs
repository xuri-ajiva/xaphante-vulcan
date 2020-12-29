using System;
using System.Threading.Tasks;
using SharpVk;
using SharpVk.Glfw;
using SharpVk.Khronos;

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
        }

        private readonly Vertex[] vertices =
        {
            new(new(-0.5f, -0.5f), new(1.0f, 0.0f, 0.0f)), new(new(0.5f, -0.5f), new(0.0f, 1.0f, 0.0f)), new(new(0.5f, 0.5f), new(0.0f, 0.0f, 1.0f)), new(new(-0.5f, 0.5f), new(1.0f, 1.0f, 1.0f))
        };

        private readonly ushort[] indices =
        {
            0, 1, 2, 2, 3, 0
        };
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
            CreateVertexBuffers(vertices);
            CreateIndexBuffer(indices);
            CreateCommandBuffers(indices);
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
