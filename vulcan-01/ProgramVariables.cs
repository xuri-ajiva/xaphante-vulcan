using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using SharpVk;
using SharpVk.Khronos;
using SharpVk.Multivendor;

namespace vulcan_01
{
    internal partial class Program
    {
        #region Vars

        private const int SurfaceWidth = 800;
        private const int SurfaceHeight = 600;
        private static readonly DebugReportCallbackDelegate DebugReportDelegate = DebugReport;
        private Instance? instance;
        private Surface? surface;
        internal PhysicalDevice physicalDevice;
        internal Device? device;
        private Queue graphicsQueue;
        private Queue presentQueue;
        internal Queue transferQueue;
        private Swapchain? swapChain;
        internal Image[] swapChainImages;
        private ImageView[]? swapChainImageViews;
        private RenderPass? renderPass;
        public PipelineLayout? pipelineLayout;
        private Pipeline? pipeline;
        private ShaderModule? fragShader;
        private ShaderModule? vertShader;
        private Framebuffer[]? frameBuffers;
        internal CommandPool transientCommandPool;
        private CommandPool? commandPool;
        private CommandBuffer[]? commandBuffers;
        private Semaphore? imageAvailableSemaphore;
        private Semaphore? renderFinishedSemaphore;

        private Format swapChainFormat;
        private Extent2D swapChainExtent;

        private BufferManager bufferManager;

        private long initialTimestamp;
        public DescriptorSet? descriptorSet;
        private DescriptorPool? descriptorPool;
        private DescriptorSetLayout? descriptorSetLayout;
        private ImageView textureImageView;
        private Sampler textureSampler;
        private ImageView depthImageView;
        private DeviceMemory depthImageMemory;
        private Image depthImage;

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

            indices.TransferFamily ??= indices.GraphicsFamily;

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

        private bool IsSuitableDevice(PhysicalDevice dvc)
        {
            var features = dvc.GetFeatures();

            return dvc.EnumerateDeviceExtensionProperties(null).Any(extension => extension.ExtensionName == KhrExtensions.Swapchain)
                   && FindQueueFamilies(dvc).IsComplete && features.SamplerAnisotropy;
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
            device?.WaitIdle();
            CleanupSwapChain();

            textureSampler.Dispose();
            textureImageView.Dispose();

            textureImage.Dispose();
            textureImageMemory.Free();

            descriptorSetLayout?.Dispose();
            descriptorSetLayout = null;

            bufferManager.Dispose();

            renderFinishedSemaphore?.Dispose();
            renderFinishedSemaphore = null;

            imageAvailableSemaphore?.Dispose();
            imageAvailableSemaphore = null;

            descriptorPool?.Dispose();
            descriptorPool = null;
            descriptorSet = null;

            commandPool?.Dispose();
            commandPool = null;
            commandBuffers = null;

            fragShader?.Dispose();
            fragShader = null;

            vertShader?.Dispose();
            vertShader = null;

            device?.Dispose();
            device = null;

            surface?.Dispose();
            surface = null;

            instance?.Dispose();
            instance = null;

            CloseWindow();
        }

        private void CleanupSwapChain()
        {
            depthImageView.Dispose();
            depthImage.Dispose();
            depthImageMemory.Free();

            if (frameBuffers != null)
                foreach (var frameBuffer in frameBuffers)
                    frameBuffer.Dispose();
            frameBuffers = null;

            commandPool?.FreeCommandBuffers(commandBuffers);

            pipeline?.Dispose();
            pipeline = null;

            pipelineLayout?.Dispose();
            pipelineLayout = null;

            renderPass?.Dispose();
            renderPass = null;

            swapChain?.Dispose();
            swapChain = null;

            if (swapChainImageViews != null)
                foreach (var imageView in swapChainImageViews)
                    imageView.Dispose();
            swapChainImageViews = null;

            descriptorPool?.Dispose();
        }

        private void RecreateSwapChain()
        {
            device?.WaitIdle();
            CleanupSwapChain();

            CreateSwapChain();
            CreateImageViews();
            CreateRenderPass();
            CreateGraphicsPipeline();
            CreateDepthResources();
            CreateFrameBuffers();
            //bufferManager.CreateUniformBuffer();   free in cleanup swapchain if created here
            CreateDescriptorPool();
            CreateDescriptorSet();
            CreateCommandBuffers();
        }
    }
}
