

using System;
using System.Threading.Tasks;
using System.Windows.Forms;
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
