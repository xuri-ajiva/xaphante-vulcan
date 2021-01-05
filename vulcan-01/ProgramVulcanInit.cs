using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using GlmSharp;
using SharpVk;
using SharpVk.Khronos;
using SharpVk.Multivendor;
using SharpVk.Shanq.GlmSharp;
using Buffer = SharpVk.Buffer;
using Image = SharpVk.Image;

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
                if (Instance.EnumerateLayerProperties().Any(x => x.LayerName == layerName))
                    enabledLayers.Add(layerName);
            }

            AddAvailableLayer("VK_LAYER_LUNARG_standard_validation");
            AddAvailableLayer("VK_LAYER_KHRONOS_validation");

            instance = Instance.Create(
                enabledLayers.ToArray(),
                window.GetRequiredInstanceExtensions().Append(ExtExtensions.DebugReport).ToArray(),
                applicationInfo: new ApplicationInfo
                {
                    ApplicationName = "vc-01",
                    ApplicationVersion = new(0, 1, 0),
                    EngineName = "xaphante",
                    EngineVersion = new(0, 0, 1),
                    ApiVersion = new(1, 0, 0)
                });

            instance.CreateDebugReportCallback(DebugReportDelegate, DebugReportFlags.Error | DebugReportFlags.Warning | DebugReportFlags.Information | DebugReportFlags.PerformanceWarning);

            foreach (var extension in Instance.EnumerateExtensionProperties())
                Console.WriteLine($"Extension available: {extension.ExtensionName}");

            foreach (var layer in Instance.EnumerateLayerProperties())
                Console.WriteLine($"Layer available: {layer.LayerName}, {layer.Description}");
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

            var queueFamilyIndices = queueFamilies.Indices.ToArray();

            var extent = ChooseSwapExtent(swapChainSupport.Capabilities);

            swapChain = device.CreateSwapchain(surface,
                imageCount,
                surfaceFormat.Format,
                surfaceFormat.ColorSpace,
                extent,
                1,
                ImageUsageFlags.ColorAttachment,
                queueFamilyIndices.Length == 1
                    ? SharingMode.Exclusive
                    : SharingMode.Concurrent,
                queueFamilyIndices,
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
                .Select(image => CreateImageView(image, swapChainFormat, ImageAspectFlags.Color))
                .ToArray();
        }

        private void CreateRenderPass()
        {
            renderPass = device.CreateRenderPass(
                new AttachmentDescription[]
                {
                    new()
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
                    new()
                    {
                        Format = FindDepthFormat(),
                        Samples = SampleCountFlags.SampleCount1,
                        LoadOp = AttachmentLoadOp.Clear,
                        StoreOp = AttachmentStoreOp.DontCare,
                        StencilLoadOp = AttachmentLoadOp.DontCare,
                        StencilStoreOp = AttachmentStoreOp.DontCare,
                        InitialLayout = ImageLayout.Undefined,
                        FinalLayout = ImageLayout.DepthStencilAttachmentOptimal
                    }
                },
                new SubpassDescription
                {
                    DepthStencilAttachment = new(1, ImageLayout.DepthStencilAttachmentOptimal),
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
                        DestinationStageMask = PipelineStageFlags.ColorAttachmentOutput | PipelineStageFlags.EarlyFragmentTests,
                        DestinationAccessMask = AccessFlags.ColorAttachmentRead | AccessFlags.ColorAttachmentWrite | AccessFlags.DepthStencilAttachmentRead
                    },
                    new SubpassDependency
                    {
                        SourceSubpass = 0,
                        DestinationSubpass = Constants.SubpassExternal,
                        SourceStageMask = PipelineStageFlags.ColorAttachmentOutput | PipelineStageFlags.EarlyFragmentTests,
                        SourceAccessMask = AccessFlags.ColorAttachmentRead | AccessFlags.ColorAttachmentWrite | AccessFlags.DepthStencilAttachmentRead,
                        DestinationStageMask = PipelineStageFlags.BottomOfPipe,
                        DestinationAccessMask = AccessFlags.MemoryRead
                    },
                });
        }

        private void CreateShaderModules()
        {
            ShaderModule? CreateShader(string path)
            {
                var shaderData = LoadShaderData(path, out var codeSize);

                return device?.CreateShaderModule(codeSize, shaderData);
            }

            vertShader = CreateShader(@".\Shaders\vert.spv");

            fragShader = CreateShader(@".\Shaders\frag.spv");
            /*        
              vertShader = device.CreateVertexModule(shank => from input in shank.GetInput<Vertex>()
                  from ubo in shank.GetBinding<UniformBufferObject>(0)
                  let transform = ubo.Proj * ubo.View * ubo.Model
                  select new VertexOutput
                  {
                      Position = transform * new vec4(input.Position, 1),
                      Colour = input.Colour
                  });
  
              fragShader = device.CreateFragmentModule(shank => from input in shank.GetInput<FragmentInput>()
                  from sampler in shank.GetSampler2d<vec4,vec2>(1,1) 
                  let colour = sampler.Sample(input.Position.xy)//new vec4(input.Color,1)
                  select new FragmentOutput
                  {
                      Colour = colour
                  });*/
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
                                MinDepth = 0,
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
                    DepthStencilState = new()
                    {
                        DepthTestEnable = true,
                        DepthWriteEnable = true,
                        DepthCompareOp = CompareOp.Less,
                        DepthBoundsTestEnable = false,
                        MinDepthBounds = 0,
                        MaxDepthBounds = 1,
                        StencilTestEnable = false,
                        Back = new(),
                        Flags = new(),
                    }
                }
            }).Single();
        }

        private void CreateFrameBuffers()
        {
            Framebuffer Create(ImageView imageView) => device.CreateFramebuffer(renderPass,
                new[]
                {
                    imageView, depthImageView
                },
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
                        new ClearColorValue(.1f, .1f, .1f, 1), new ClearDepthStencilValue(1, 0)
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
                new DescriptorSetLayoutBinding[]
                {
                    new()
                    {
                        Binding = 0,
                        DescriptorType = DescriptorType.UniformBuffer,
                        StageFlags = ShaderStageFlags.Vertex,
                        DescriptorCount = 1
                    },
                    new()
                    {
                        Binding = 1,
                        DescriptorCount = 1,
                        DescriptorType = DescriptorType.CombinedImageSampler,
                        StageFlags = ShaderStageFlags.Fragment,
                    }
                });
        }

        private void CreateDescriptorPool()
        {
            descriptorPool = device.CreateDescriptorPool(
                1,
                new DescriptorPoolSize[]
                {
                    new()
                    {
                        DescriptorCount = 1,
                        Type = DescriptorType.UniformBuffer
                    },
                    new()
                    {
                        DescriptorCount = 1,
                        Type = DescriptorType.CombinedImageSampler
                    }
                });
        }

        private void CreateDescriptorSet()
        {
            descriptorSet = device.AllocateDescriptorSets(descriptorPool, descriptorSetLayout).Single();

            device.UpdateDescriptorSets(
                new WriteDescriptorSet[]
                {
                    new()
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
                    },
                    new()
                    {
                        ImageInfo = new[]
                        {
                            new DescriptorImageInfo
                            {
                                Sampler = textureSampler,
                                ImageView = textureImageView,
                                ImageLayout = ImageLayout.ShaderReadOnlyOptimal
                            }
                        },
                        DescriptorCount = 1,
                        DestinationSet = descriptorSet,
                        DestinationBinding = 1,
                        DestinationArrayElement = 0,
                        DescriptorType = DescriptorType.CombinedImageSampler,
                    }
                }, null);
        }

        private void CreateDevice()
        {
            PickPhysicalDevice();
            CreateLogicalDevice();
        }

        private void CreateDepthResources()
        {
            var depthFormat = FindDepthFormat();

            CreateImage(swapChainExtent.Width, swapChainExtent.Height, depthFormat, ImageTiling.Optimal, ImageUsageFlags.DepthStencilAttachment, MemoryPropertyFlags.DeviceLocal, out depthImage, out depthImageMemory);
            depthImageView = CreateImageView(depthImage, depthFormat, ImageAspectFlags.Depth);

            TransitionImageLayout(depthImage, depthFormat, ImageLayout.Undefined, ImageLayout.DepthStencilAttachmentOptimal);
        }

        private Format FindDepthFormat()
        {
            return FindSupportedFormat(new[]
                {
                    Format.D32SFloat, Format.D32SFloatS8UInt, Format.D24UNormS8UInt
                },
                ImageTiling.Optimal,
                FormatFeatureFlags.DepthStencilAttachment
                //VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT
            );
        }

        private Format FindSupportedFormat(IEnumerable<Format> candidates, ImageTiling tiling, FormatFeatureFlags features)
        {
            foreach (var format in candidates)
            {
                var props = physicalDevice.GetFormatProperties(format);

                switch (tiling)
                {
                    case ImageTiling.Linear when (props.LinearTilingFeatures & features) == features:
                        return format;
                    case ImageTiling.Optimal when (props.OptimalTilingFeatures & features) == features:
                        return format;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(tiling), tiling, "failed to find supported format!");
                }
            }

            throw new ArgumentOutOfRangeException(nameof(candidates), candidates, "failed to find supported format!");
        }

        private ImageView CreateImageView(Image image, Format format, ImageAspectFlags aspectFlags)
        {
            return device.CreateImageView(image, ImageViewType.ImageView2d, format, ComponentMapping.Identity, new()
            {
                AspectMask = aspectFlags,
                BaseMipLevel = 0,
                LevelCount = 1,
                BaseArrayLayer = 0,
                LayerCount = 1,
            });
        }

        private void CreateImage(uint width, uint height, Format format, ImageTiling tiling, ImageUsageFlags usage, MemoryPropertyFlags properties, out Image image, out DeviceMemory imageMemory)
        {
            image = device.CreateImage(ImageType.Image2d, format, new Extent3D(width, height, 1), 1, 1, SampleCountFlags.SampleCount1, tiling, usage, SharingMode.Exclusive, ArrayProxy<uint>.Null, ImageLayout.Undefined);

            var memRequirements = device.GetImageMemoryRequirements2(new()
            {
                Image = image
            });

            imageMemory = device.AllocateMemory(memRequirements.MemoryRequirements.Size, bufferManager.FindMemoryType(memRequirements.MemoryRequirements.MemoryTypeBits, properties), new()
            {
                Image = image,
            });

            device.BindImageMemory2(new BindImageMemoryInfo
            {
                Image = image,
                Memory = imageMemory,
                MemoryOffset = 0,
            });
        }

        private Image textureImage;
        private DeviceMemory textureImageMemory;

        private void CreateTextureImage()
        {
            unsafe
            {
                var img = System.Drawing.Image.FromFile("logo.png");
                var bm = new Bitmap(img);
                var scp0 = bm.LockBits(new(0, 0, bm.Width, bm.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppPArgb);

                uint texWidth = (uint)bm.Width;
                uint texHeight = (uint)bm.Height;
                uint imageSize = (uint)(texWidth * texHeight * 4);

                bufferManager.CreateBuffer(imageSize, BufferUsageFlags.TransferSource, MemoryPropertyFlags.HostVisible | MemoryPropertyFlags.HostCached, out var stagingBuffer, out var stagingBufferMemory);

                var map = stagingBufferMemory.Map(0, imageSize, MemoryMapFlags.None);

                ImageHelper.ArgbCopyMap((ImageHelper.Argb32R*)scp0.Scan0.ToPointer(), (ImageHelper.Rgba32*)map.ToPointer(), texWidth * texHeight);
                //ImageHelper.ArgbCopyMap((byte*)scp0.Scan0.ToPointer(), (byte*)map.ToPointer(), texWidth * texHeight);
                //System.Buffer.MemoryCopy(scp0.Scan0.ToPointer(), map.ToPointer(), imageSize, imageSize);

                stagingBufferMemory.Unmap();
                bm.UnlockBits(scp0);

                CreateImage(texWidth, texHeight, Format.R8G8B8A8Srgb, ImageTiling.Optimal, ImageUsageFlags.TransferDestination | ImageUsageFlags.Sampled, MemoryPropertyFlags.DeviceLocal, out textureImage, out textureImageMemory);

                TransitionImageLayout(textureImage, Format.R8G8B8A8Srgb, ImageLayout.Undefined, ImageLayout.TransferDestinationOptimal);
                CopyBufferToImage(stagingBuffer, textureImage, texWidth, texHeight);
                TransitionImageLayout(textureImage, Format.R8G8B8A8Srgb, ImageLayout.TransferDestinationOptimal, ImageLayout.ShaderReadOnlyOptimal);

                stagingBuffer.Destroy();
                stagingBufferMemory.Free();
            }
        }

        private CommandBuffer BeginSingleTimeCommands()
        {
            var commandBuffer = device.AllocateCommandBuffers(commandPool, CommandBufferLevel.Primary, 1);
            commandBuffer[0].Begin(CommandBufferUsageFlags.OneTimeSubmit);

            return commandBuffer[0];
        }

        private void EndSingleTimeCommands(CommandBuffer commandBuffer)
        {
            commandBuffer.End();

            graphicsQueue.Submit(new SubmitInfo()
            {
                CommandBuffers = new[]
                {
                    commandBuffer
                },
            }, null);

            graphicsQueue.WaitIdle();
            commandPool.FreeCommandBuffers(commandBuffer);
        }

        bool HasStencilComponent(Format format)
        {
            return format == Format.D32SFloatS8UInt || format == Format.D24UNormS8UInt;
        }

        private void TransitionImageLayout(Image image, Format format, ImageLayout oldLayout, ImageLayout newLayout)
        {
            CommandBuffer commandBuffer = BeginSingleTimeCommands();

            ImageSubresourceRange subresourceRange = new()
            {
                BaseMipLevel = 0,
                LevelCount = 1,
                BaseArrayLayer = 0,
                LayerCount = 1
            };

            if (newLayout == ImageLayout.DepthStencilAttachmentOptimal)
            {
                subresourceRange.AspectMask = ImageAspectFlags.Depth;

                if (HasStencilComponent(format)) subresourceRange.AspectMask |= ImageAspectFlags.Stencil;
            }
            else
            {
                subresourceRange.AspectMask = ImageAspectFlags.Color;
            }

            var barrier = new ImageMemoryBarrier
            {
                OldLayout = oldLayout,
                NewLayout = newLayout,
                Image = image,
                SubresourceRange = subresourceRange,
            };

            //barrier.SourceQueueFamilyIndex = VK_QUEUE_FAMILY_IGNORED;
            //barrier.DestinationQueueFamilyIndex = VK_QUEUE_FAMILY_IGNORED;

            PipelineStageFlags sourceStage;
            PipelineStageFlags destinationStage;

            switch (oldLayout)
            {
                case ImageLayout.Undefined when newLayout == ImageLayout.TransferDestinationOptimal:
                    barrier.SourceAccessMask = 0;
                    barrier.DestinationAccessMask = AccessFlags.TransferWrite;

                    sourceStage = PipelineStageFlags.TopOfPipe;
                    destinationStage = PipelineStageFlags.Transfer;
                    break;
                case ImageLayout.TransferDestinationOptimal when newLayout == ImageLayout.ShaderReadOnlyOptimal:
                    barrier.SourceAccessMask = AccessFlags.TransferWrite;
                    barrier.DestinationAccessMask = AccessFlags.ShaderRead;

                    sourceStage = PipelineStageFlags.Transfer;
                    destinationStage = PipelineStageFlags.FragmentShader;
                    break;
                case ImageLayout.Undefined when newLayout == ImageLayout.DepthStencilAttachmentOptimal:
                    barrier.SourceAccessMask = 0;
                    barrier.DestinationAccessMask = AccessFlags.DepthStencilAttachmentRead | AccessFlags.DepthStencilAttachmentWrite;

                    sourceStage = PipelineStageFlags.TopOfPipe;
                    destinationStage = PipelineStageFlags.EarlyFragmentTests;
                    break;
                default:
                    throw new ArgumentException("unsupported layout transition!");
            }

            commandBuffer.PipelineBarrier(sourceStage, destinationStage, ArrayProxy<MemoryBarrier>.Null, ArrayProxy<BufferMemoryBarrier>.Null, barrier);

            EndSingleTimeCommands(commandBuffer);
        }

        private void CopyBufferToImage(Buffer buffer, Image image, uint width, uint height)
        {
            var commandBuffer = BeginSingleTimeCommands();

            commandBuffer.CopyBufferToImage(buffer, image, ImageLayout.TransferDestinationOptimal, new BufferImageCopy()
            {
                BufferOffset = 0,
                BufferRowLength = 0,
                BufferImageHeight = 0,
                ImageOffset = new(),
                ImageExtent = new(width, height, 0),
                ImageSubresource = new()
                {
                    AspectMask = ImageAspectFlags.Color,
                    MipLevel = 0,
                    BaseArrayLayer = 0,
                    LayerCount = 1,
                }
            });

            EndSingleTimeCommands(commandBuffer);
        }

        private void CreateTextureImageView()
        {
            textureImageView = CreateImageView(textureImage, Format.R8G8B8A8Srgb, ImageAspectFlags.Color);
        }

        private void CreateTextureSampler()
        {
            PhysicalDeviceProperties properties = physicalDevice.GetProperties();

            textureSampler = device.CreateSampler(Filter.Linear, Filter.Linear, SamplerMipmapMode.Linear, SamplerAddressMode.Repeat,
                SamplerAddressMode.Repeat, SamplerAddressMode.Repeat, default, true, properties.Limits.MaxSamplerAnisotropy,
                false, CompareOp.Always, default, default, BorderColor.IntOpaqueBlack, false);
        }
    }
    internal class ImageHelper
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Rgba32
        {
            public byte r;
            public byte g;
            public byte b;
            public byte a;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct Argb32
        {
            public byte b;
            public byte g;
            public byte r;
            public byte a;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct Argb32R
        {
            public readonly byte b;
            public readonly byte g;
            public readonly byte r;
            public readonly byte a;
        }

        public static unsafe void ArgbCopyMap(Argb32R* from, Rgba32* to, uint pixelCount)
        {
            for (var i = 0; i < pixelCount; i++)
            {
                to->r = from->r;
                to->b = from->b;
                to->g = from->g;
                to->a = from->a;

                to++;
                from++;
            }
        }

        public static unsafe void ArgbCopyMap(byte* from, byte* to, uint pixelCount)
        {
            for (var i = 0; i < pixelCount; i++)
            {
                *(to + 0) = *(from + 2);
                *(to + 1) = *(from + 0);
                *(to + 2) = *(from + 1);
                *(to + 3) = *(from + 3);

                to += sizeof(int);
                from += sizeof(int);
            }
        }
    }
}
