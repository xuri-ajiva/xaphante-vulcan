using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
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
            var r = new Random();
            new Thread(() =>
            {
                Thread.Sleep(2000);
                var i = 0;
                while (true)
                {
                    i++;

                    Thread.Sleep(100);
                    var i1 = i;
                    pg.applicationQueue.Enqueue(delegate
                    {
                        //pg.RecreateSwapChain();
                        var bi = pg.bufferManager.Buffers[0];

                        {
                            var size = pg.indices.Length;
                            var ne = new ushort[pg.indices.Length];
                            for (int j = 0; j < ne.Length; j++)
                            {
                                ne[j] = (ushort)r.Next(0, pg.vertices.Length);
                            }

                            var bs = pg.bufferManager.CreateCopyBuffer(ref ne, out var sb, out var sm);

                            pg.bufferManager.CopyBuffer(sb, bi.IndexBuffer, bs);

                            sb.Dispose();
                            sm.Free();

                            bi.IndexBufferMemory.Unmap();
                        }
                        {
                            float SingXv(float def)
                            {
                                var si = MathF.Abs(MathF.Sin(i1 / 100f + def * (MathF.PI / 2)));
                                return si;
                            }

                            Vertex[] vn = new Vertex[pg.vertices.Length];
                            for (int j = 0; j < vn.Length; j++)
                            {
                                vn[j] = new Vertex(new((float)(r.NextDouble() * 2 - 1), (float)(r.NextDouble() * 2 - 1f)), new((float)(r.NextDouble()), (float)(r.NextDouble()), (float)(r.NextDouble())));
                            }

                            var bs = pg.bufferManager.CreateCopyBuffer(ref vn, out var sb, out var sm);

                            pg.bufferManager.CopyBuffer(sb, bi.VertexBuffer, bs);

                            sb.Dispose();
                            sm.Free();

                            bi.IndexBufferMemory.Unmap();
                        }
                    });
                }
            }).Start();

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

        private readonly Queue<Action> applicationQueue = new();

        private void UpdateApplication()
        {
            if (applicationQueue.TryDequeue(out var action))
                action?.Invoke();
        }
    }
}
