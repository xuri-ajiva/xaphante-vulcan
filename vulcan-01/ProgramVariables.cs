using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using GlmSharp;
using SharpVk;
using SharpVk.Glfw;
using SharpVk.Khronos;
using SharpVk.Multivendor;
using SharpVk.Shanq;
using SharpVk.Spirv;

namespace vulcan_01
{
    internal partial class Program
    {
        #region Vars

        private const int SurfaceWidth = 800;
        private const int SurfaceHeight = 600;
        private static readonly DebugReportCallbackDelegate DebugReportDelegate = DebugReport;
        private Instance instance;
        private Surface surface;
        private PhysicalDevice physicalDevice;
        private Device device;
        private Queue graphicsQueue;
        private Queue presentQueue;
        private Queue transferQueue;
        private Swapchain swapChain;
        private Image[] swapChainImages;
        private ImageView[] swapChainImageViews;
        private RenderPass renderPass;
        private PipelineLayout pipelineLayout;
        private Pipeline pipeline;
        private ShaderModule fragShader;
        private ShaderModule vertShader;
        private Framebuffer[] frameBuffers;
        private CommandPool transientCommandPool;
        private CommandPool commandPool;
        private CommandBuffer[] commandBuffers;
        private Semaphore imageAvailableSemaphore;
        private Semaphore renderFinishedSemaphore;

        private Format swapChainFormat;
        private Extent2D swapChainExtent;

        private BufferManager bufferManager;

        private DeviceMemory indexBufferMemory;
        private DeviceMemory vertexBufferMemory;

        #endregion
        #region cpy

    #endregion

        #region Utils

        private QueueFamilyIndices FindQueueFamilies(PhysicalDevice device)
        {
            var indices = new QueueFamilyIndices();

            var queueFamilies = device.GetQueueFamilyProperties();

            for (uint index = 0; index < queueFamilies.Length && !indices.IsComplete; index++)
            {
                if (queueFamilies[index].QueueFlags.HasFlag(QueueFlags.Graphics))
                {
                    indices.GraphicsFamily = index;
                }

                if (device.GetSurfaceSupport(index, surface))
                {
                    indices.PresentFamily = index;
                }

                if (queueFamilies[index].QueueFlags.HasFlag(QueueFlags.Transfer) && !queueFamilies[index].QueueFlags.HasFlag(QueueFlags.Graphics))
                {
                    indices.TransferFamily = index;
                }
            }

            if (!indices.TransferFamily.HasValue)
            {
                indices.TransferFamily = indices.GraphicsFamily;
            }

            return indices;
        }

        private SurfaceFormat ChooseSwapSurfaceFormat(SurfaceFormat[] availableFormats)
        {
            if (availableFormats.Length == 1 && availableFormats[0].Format == Format.Undefined)
            {
                return new()
                {
                    Format = Format.B8G8R8A8UNorm,
                    ColorSpace = ColorSpace.SrgbNonlinear
                };
            }

            foreach (var format in availableFormats)
            {
                if (format.Format == Format.B8G8R8A8UNorm && format.ColorSpace == ColorSpace.SrgbNonlinear)
                {
                    return format;
                }
            }

            return availableFormats[0];
        }

        private PresentMode ChooseSwapPresentMode(PresentMode[] availablePresentModes)
        {
            return availablePresentModes.Contains(PresentMode.Mailbox)
                ? PresentMode.Mailbox
                : PresentMode.Fifo;
        }

        public Extent2D ChooseSwapExtent(SurfaceCapabilities capabilities)
        {
            if (capabilities.CurrentExtent.Width != uint.MaxValue)
            {
                return capabilities.CurrentExtent;
            }
            return new()
            {
                Width = Math.Max(capabilities.MinImageExtent.Width, Math.Min(capabilities.MaxImageExtent.Width, SurfaceWidth)),
                Height = Math.Max(capabilities.MinImageExtent.Height, Math.Min(capabilities.MaxImageExtent.Height, SurfaceHeight))
            };
        }

        SwapChainSupportDetails QuerySwapChainSupport(PhysicalDevice device)
        {
            return new()
            {
                Capabilities = device.GetSurfaceCapabilities(surface),
                Formats = device.GetSurfaceFormats(surface),
                PresentModes = device.GetSurfacePresentModes(surface)
            };
        }

        private bool IsSuitableDevice(PhysicalDevice device)
        {
            return device.EnumerateDeviceExtensionProperties(null).Any(extension => extension.ExtensionName == KhrExtensions.Swapchain)
                   && FindQueueFamilies(device).IsComplete;
        }

        private static uint[] LoadShaderData(string filePath, out int codeSize)
        {
            var fileBytes = File.ReadAllBytes(filePath);
            var shaderData = new uint[(int)Math.Ceiling(fileBytes.Length / 4f)];

            System.Buffer.BlockCopy(fileBytes, 0, shaderData, 0, fileBytes.Length);

            codeSize = fileBytes.Length;

            return shaderData;
        }

  #endregion

        private static Bool32 DebugReport(DebugReportFlags flags, DebugReportObjectType objectType, ulong @object, HostSize location, int messageCode, string layerPrefix, string message, IntPtr userData)
        {
            Debug.WriteLine(message);
            Console.WriteLine(message);

            return false;
        }

        private void Cleanup()
        {
            device.WaitIdle();

            renderFinishedSemaphore.Dispose();
            renderFinishedSemaphore = null;

            imageAvailableSemaphore.Dispose();
            imageAvailableSemaphore = null;

            commandPool.Dispose();
            commandPool = null;

            foreach (var frameBuffer in frameBuffers) frameBuffer.Dispose();
            frameBuffers = null;

            fragShader.Dispose();
            fragShader = null;

            vertShader.Dispose();
            vertShader = null;

            pipeline.Dispose();
            pipeline = null;

            pipelineLayout.Dispose();
            pipelineLayout = null;

            foreach (var imageView in swapChainImageViews) imageView.Dispose();
            swapChainImageViews = null;

            renderPass.Dispose();
            renderPass = null;

            swapChain.Dispose();
            swapChain = null;

            device.Dispose();
            device = null;

            surface.Dispose();
            surface = null;

            instance.Dispose();
            instance = null;

            CloseWindow();
        }

        private void RecreateSwapChain()
        {
            device.WaitIdle();

            commandPool.FreeCommandBuffers(commandBuffers);

            foreach (var frameBuffer in frameBuffers)
            {
                frameBuffer.Dispose();
            }
            frameBuffers = null;

            pipeline.Dispose();
            pipeline = null;

            pipelineLayout.Dispose();
            pipelineLayout = null;

            foreach (var imageView in swapChainImageViews)
            {
                imageView.Dispose();
            }
            swapChainImageViews = null;

            renderPass.Dispose();
            renderPass = null;

            swapChain.Dispose();
            swapChain = null;

            CreateSwapChain();
            CreateImageViews();
            CreateRenderPass();
            CreateGraphicsPipeline();
            CreateFrameBuffers();
            CreateCommandBuffers();
        }
    }

    internal struct QueueFamilyIndices
    {
        public uint? GraphicsFamily;
        public uint? PresentFamily;
        public uint? TransferFamily;

        public IEnumerable<uint> Indices
        {
            get
            {
                if (GraphicsFamily.HasValue)
                {
                    yield return GraphicsFamily.Value;
                }

                if (PresentFamily.HasValue && PresentFamily != GraphicsFamily)
                {
                    yield return PresentFamily.Value;
                }

                if (TransferFamily.HasValue && TransferFamily != PresentFamily && TransferFamily != GraphicsFamily)
                {
                    yield return TransferFamily.Value;
                }
            }
        }

        public bool IsComplete =>
            GraphicsFamily.HasValue
            && PresentFamily.HasValue
            && TransferFamily.HasValue;
    }

    internal struct SwapChainSupportDetails
    {
        public SurfaceCapabilities Capabilities;
        public SurfaceFormat[] Formats;
        public PresentMode[] PresentModes;
    }

    internal struct VertexOutput
    {
        [Location(0)] public vec3 Colour;

        [BuiltIn(BuiltIn.Position)] public vec4 Position;
    }

    internal struct FragmentInput
    {
        [Location(0)] public vec3 Colour;
    }

    internal struct FragmentOutput
    {
        [Location(0)] public vec4 Colour;
    }

    internal struct Vertex
    {
        public Vertex(vec2 position, vec3 colour)
        {
            Position = position;
            Colour = colour;
        }

        [Location(0)] public vec2 Position;

        [Location(1)] public vec3 Colour;

        public static VertexInputBindingDescription GetBindingDescription()
        {
            return new()
            {
                Binding = 0,
                Stride = (uint)Marshal.SizeOf<Vertex>(),
                InputRate = VertexInputRate.Vertex
            };
        }

        public static VertexInputAttributeDescription[] GetAttributeDescriptions()
        {
            return new[]
            {
                new VertexInputAttributeDescription
                {
                    Binding = 0,
                    Location = 0,
                    Format = Format.R32G32SFloat,
                    Offset = (uint)Marshal.OffsetOf<Vertex>("Position")
                },
                new VertexInputAttributeDescription
                {
                    Binding = 0,
                    Location = 1,
                    Format = Format.R32G32B32SFloat,
                    Offset = (uint)Marshal.OffsetOf<Vertex>("Colour")
                }
            };
        }
    }
}
