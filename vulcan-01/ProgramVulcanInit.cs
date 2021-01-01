using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using GlmSharp;
using SharpVk;
using SharpVk.Khronos;
using SharpVk.Multivendor;
using SharpVk.Shanq;
using SharpVk.Shanq.GlmSharp;

namespace vulcan_01
{
    internal partial class Program
    {
        private void CreateInstance()
        {
            var enabledLayers = new List<string>();

            //VK_LAYER_LUNARG_api_dump
            //VK_LAYER_LUNARG_standard_validation

            void AddAvailableLayer(string layerName)
            {
                if (Instance.EnumerateLayerProperties().Any(x => x.LayerName == layerName)) enabledLayers.Add(layerName);
            }

            AddAvailableLayer("VK_LAYER_LUNARG_standard_validation");
            AddAvailableLayer("VK_LAYER_KHRONOS_validation");

            instance = Instance.Create(
                enabledLayers.ToArray(),
                GetRequiredInstanceExtensions().Append(ExtExtensions.DebugReport).ToArray(),
                applicationInfo: new ApplicationInfo
                {
                    ApplicationName = "vc-01",
                    ApplicationVersion = new(0, 1, 0),
                    EngineName = "xaphante",
                    EngineVersion = new(0, 0, 1),
                    ApiVersion = new(1, 0, 0)
                });

            instance.CreateDebugReportCallback(DebugReportDelegate, DebugReportFlags.Error | DebugReportFlags.Warning | DebugReportFlags.Information);

            foreach (var extension in Instance.EnumerateExtensionProperties()) Console.WriteLine($"Extension available: {extension.ExtensionName}");

            foreach (var layer in Instance.EnumerateLayerProperties()) Console.WriteLine($"Layer available: {layer.LayerName}, {layer.Description}");
        }

        #region cpy

        private void PickPhysicalDevice()
        {
            var availableDevices = instance.EnumeratePhysicalDevices();

            physicalDevice = availableDevices.First(IsSuitableDevice);
        }

        private void CreateLogicalDevice()
        {
            var queueFamilies = FindQueueFamilies(physicalDevice);

            device = physicalDevice.CreateDevice(queueFamilies.Indices
                    .Select(index => new DeviceQueueCreateInfo
                    {
                        QueueFamilyIndex = index,
                        QueuePriorities = new[]
                        {
                            1f
                        }
                    }).ToArray(),
                null,
                KhrExtensions.Swapchain);

            graphicsQueue = device.GetQueue(queueFamilies.GraphicsFamily.Value, 0);
            presentQueue = device.GetQueue(queueFamilies.PresentFamily.Value, 0);
            transferQueue = device.GetQueue(queueFamilies.TransferFamily.Value, 0);
        }

        private void CreateSwapChain()
        {
            var swapChainSupport = QuerySwapChainSupport(physicalDevice);

            var imageCount = swapChainSupport.Capabilities.MinImageCount + 1;
            if (swapChainSupport.Capabilities.MaxImageCount > 0 && imageCount > swapChainSupport.Capabilities.MaxImageCount)
            {
                imageCount = swapChainSupport.Capabilities.MaxImageCount;
            }

            var surfaceFormat = ChooseSwapSurfaceFormat(swapChainSupport.Formats);

            var queueFamilies = FindQueueFamilies(physicalDevice);

            var indices = queueFamilies.Indices.ToArray();

            var extent = ChooseSwapExtent(swapChainSupport.Capabilities);

            swapChain = device.CreateSwapchain(surface,
                imageCount,
                surfaceFormat.Format,
                surfaceFormat.ColorSpace,
                extent,
                1,
                ImageUsageFlags.ColorAttachment,
                indices.Length == 1
                    ? SharingMode.Exclusive
                    : SharingMode.Concurrent,
                indices,
                swapChainSupport.Capabilities.CurrentTransform,
                CompositeAlphaFlags.Opaque,
                ChooseSwapPresentMode(swapChainSupport.PresentModes),
                true,
                swapChain);

            swapChainImages = swapChain.GetImages();
            swapChainFormat = surfaceFormat.Format;
            swapChainExtent = extent;
        }

        private void CreateImageViews()
        {
            swapChainImageViews = swapChainImages
                .Select(image => device.CreateImageView(image,
                    ImageViewType.ImageView2d,
                    swapChainFormat,
                    ComponentMapping.Identity,
                    new()
                    {
                        AspectMask = ImageAspectFlags.Color,
                        BaseMipLevel = 0,
                        LevelCount = 1,
                        BaseArrayLayer = 0,
                        LayerCount = 1
                    }))
                .ToArray();
        }

        private void CreateRenderPass()
        {
            renderPass = device.CreateRenderPass(
                new AttachmentDescription
                {
                    Format = swapChainFormat,
                    Samples = SampleCountFlags.SampleCount1,
                    LoadOp = AttachmentLoadOp.Clear,
                    StoreOp = AttachmentStoreOp.Store,
                    StencilLoadOp = AttachmentLoadOp.DontCare,
                    StencilStoreOp = AttachmentStoreOp.DontCare,
                    InitialLayout = ImageLayout.Undefined,
                    FinalLayout = ImageLayout.PresentSource
                },
                new SubpassDescription
                {
                    DepthStencilAttachment = new AttachmentReference
                    {
                        Attachment = Constants.AttachmentUnused
                    },
                    PipelineBindPoint = PipelineBindPoint.Graphics,
                    ColorAttachments = new[]
                    {
                        new AttachmentReference(0, ImageLayout.ColorAttachmentOptimal)
                    }
                },
                new[]
                {
                    new SubpassDependency
                    {
                        SourceSubpass = Constants.SubpassExternal,
                        DestinationSubpass = 0,
                        SourceStageMask = PipelineStageFlags.BottomOfPipe,
                        SourceAccessMask = AccessFlags.MemoryRead,
                        DestinationStageMask = PipelineStageFlags.ColorAttachmentOutput,
                        DestinationAccessMask = AccessFlags.ColorAttachmentRead | AccessFlags.ColorAttachmentWrite
                    },
                    new SubpassDependency
                    {
                        SourceSubpass = 0,
                        DestinationSubpass = Constants.SubpassExternal,
                        SourceStageMask = PipelineStageFlags.ColorAttachmentOutput,
                        SourceAccessMask = AccessFlags.ColorAttachmentRead | AccessFlags.ColorAttachmentWrite,
                        DestinationStageMask = PipelineStageFlags.BottomOfPipe,
                        DestinationAccessMask = AccessFlags.MemoryRead
                    }
                });
        }

        private void CreateShaderModules()
        {
            ShaderModule CreateShader(string path)
            {
                var shaderData = LoadShaderData(path, out var codeSize);

                return device.CreateShaderModule(codeSize, shaderData);
            }

            vertShader = CreateShader(@".\Shaders\vert.spv");

            fragShader = CreateShader(@".\Shaders\frag.spv");
            /*
vertShader = device.CreateVertexModule(shanq => from input in shanq.GetInput<Vertex>()
from ubo in shanq.GetBinding<UniformBufferObject>(0)
let transform = ubo.Proj * ubo.View * ubo.Model
select new VertexOutput
{
Position = transform * new vec4(input.Position, 0, 1),
Colour = input.Colour
});

fragShader = device.CreateFragmentModule(shanq => from input in shanq.GetInput<FragmentInput>()
let colour = new vec4(input.Colour, 1)
select new FragmentOutput
{
Colour = colour
});         */
        }

        private void CreateGraphicsPipeline()
        {
            var bindingDescription = Vertex.GetBindingDescription();
            var attributeDescriptions = Vertex.GetAttributeDescriptions();

            pipelineLayout = device.CreatePipelineLayout(descriptorSetLayout, null);

            pipeline = device.CreateGraphicsPipelines(null, new[]
            {
                new GraphicsPipelineCreateInfo
                {
                    Layout = pipelineLayout,
                    RenderPass = renderPass,
                    Subpass = 0,
                    VertexInputState = new()
                    {
                        VertexBindingDescriptions = new[]
                        {
                            bindingDescription
                        },
                        VertexAttributeDescriptions = attributeDescriptions
                    },
                    InputAssemblyState = new()
                    {
                        PrimitiveRestartEnable = false,
                        Topology = PrimitiveTopology.TriangleList
                    },
                    ViewportState = new()
                    {
                        Viewports = new[]
                        {
                            new Viewport
                            {
                                X = 0f,
                                Y = 0f,
                                Width = swapChainExtent.Width,
                                Height = swapChainExtent.Height,
                                MaxDepth = 1,
                                MinDepth = 0
                            }
                        },
                        Scissors = new[]
                        {
                            new Rect2D
                            {
                                Offset = new Offset2D(),
                                Extent = swapChainExtent
                            }
                        }
                    },
                    RasterizationState = new()
                    {
                        DepthClampEnable = false,
                        RasterizerDiscardEnable = false,
                        PolygonMode = PolygonMode.Fill,
                        LineWidth = 1,
                        CullMode = CullModeFlags.Back,
                        FrontFace = FrontFace.CounterClockwise,
                        DepthBiasEnable = false
                    },
                    MultisampleState = new()
                    {
                        SampleShadingEnable = false,
                        RasterizationSamples = SampleCountFlags.SampleCount1,
                        MinSampleShading = 1
                    },
                    ColorBlendState = new()
                    {
                        Attachments = new[]
                        {
                            new PipelineColorBlendAttachmentState
                            {
                                ColorWriteMask = ColorComponentFlags.R
                                                 | ColorComponentFlags.G
                                                 | ColorComponentFlags.B
                                                 | ColorComponentFlags.A,
                                BlendEnable = false,
                                SourceColorBlendFactor = BlendFactor.One,
                                DestinationColorBlendFactor = BlendFactor.Zero,
                                ColorBlendOp = BlendOp.Add,
                                SourceAlphaBlendFactor = BlendFactor.One,
                                DestinationAlphaBlendFactor = BlendFactor.Zero,
                                AlphaBlendOp = BlendOp.Add
                            }
                        },
                        LogicOpEnable = false,
                        LogicOp = LogicOp.Copy,
                        BlendConstants = (0, 0, 0, 0)
                    },
                    Stages = new[]
                    {
                        new PipelineShaderStageCreateInfo
                        {
                            Stage = ShaderStageFlags.Vertex,
                            Module = vertShader,
                            Name = "main"
                        },
                        new PipelineShaderStageCreateInfo
                        {
                            Stage = ShaderStageFlags.Fragment,
                            Module = fragShader,
                            Name = "main"
                        }
                    },
                }
            }).Single();
        }

        private void CreateFrameBuffers()
        {
            Framebuffer Create(ImageView imageView) => device.CreateFramebuffer(renderPass,
                imageView,
                swapChainExtent.Width,
                swapChainExtent.Height,
                1);

            frameBuffers = swapChainImageViews.Select(Create).ToArray();
        }

        private void CreateCommandPools()
        {
            var queueFamilies = FindQueueFamilies(physicalDevice);

            transientCommandPool = device.CreateCommandPool(queueFamilies.TransferFamily.Value, CommandPoolCreateFlags.Transient);

            commandPool = device.CreateCommandPool(queueFamilies.GraphicsFamily.Value);
        }

        private void CreateCommandBuffers()
        {
            commandPool.Reset(CommandPoolResetFlags.ReleaseResources);

            commandBuffers = device.AllocateCommandBuffers(commandPool, CommandBufferLevel.Primary, (uint)frameBuffers.Length);

            for (var index = 0; index < frameBuffers.Length; index++)
            {
                var commandBuffer = commandBuffers[index];

                commandBuffer.Begin(CommandBufferUsageFlags.SimultaneousUse);

                commandBuffer.BeginRenderPass(renderPass,
                    frameBuffers[index],
                    new(new(), swapChainExtent),
                    new ClearValue[]
                    {
                        new ClearColorValue(.1f, .1f, .1f, 1)
                    },
                    SubpassContents.Inline);

                commandBuffer.BindPipeline(PipelineBindPoint.Graphics, pipeline);

                bufferManager.BindAllAndDraw(commandBuffer);

                commandBuffer.EndRenderPass();

                commandBuffer.End();
            }
        }

        private void CreateSemaphores()
        {
            imageAvailableSemaphore = device.CreateSemaphore();
            renderFinishedSemaphore = device.CreateSemaphore();
        }

    #endregion

        private void CreateBufferManager()
        {
            bufferManager = new(this);
        }

        private void CreateDescriptorSetLayout()
        {
            descriptorSetLayout = device.CreateDescriptorSetLayout(
                new DescriptorSetLayoutBinding
                {
                    Binding = 0,
                    DescriptorType = DescriptorType.UniformBuffer,
                    StageFlags = ShaderStageFlags.Vertex | ShaderStageFlags.Fragment,
                    DescriptorCount = 1
                });
        }

        private void CreateDescriptorPool()
        {
            descriptorPool = device.CreateDescriptorPool(
                1,
                new DescriptorPoolSize
                {
                    DescriptorCount = 1,
                    Type = DescriptorType.UniformBuffer
                });
        }

        private void CreateDescriptorSet()
        {
            descriptorSet = device.AllocateDescriptorSets(descriptorPool, descriptorSetLayout).Single();

            device.UpdateDescriptorSets(
                new WriteDescriptorSet
                {
                    BufferInfo = new[]
                    {
                        new DescriptorBufferInfo
                        {
                            Buffer = bufferManager.UniformBuffer,
                            Offset = 0,
                            Range = (ulong)Unsafe.SizeOf<UniformBufferObject>()
                        }
                    },
                    DescriptorCount = 1,
                    DestinationSet = descriptorSet,
                    DestinationBinding = 0,
                    DestinationArrayElement = 0,
                    DescriptorType = DescriptorType.UniformBuffer
                }, null);
        }

        private void CreateDevice()
        {
           
            PickPhysicalDevice();
            CreateLogicalDevice();
        }
    }
}
